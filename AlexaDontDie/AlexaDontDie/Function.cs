using System;
using Newtonsoft.Json;
using Alexa.NET.Response;
using Alexa.NET.Request;
using Amazon.Lambda.Core;
using Alexa.NET.Request.Type;
using System.Text.RegularExpressions;
using System.Collections.Generic;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AlexaDontDie
{
    public class Function
    {
        private SkillResponse response = null;
        private ILambdaContext context = null;
        public static Resource resource = new Resource();

        /// <summary>
        /// Application entry point
        /// </summary>
        /// <param name="input"></param>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext ctx)
        {
            context = ctx;
            try
            {
                response = new SkillResponse
                {
                    Response = new ResponseBody()
                };
                response.Response.ShouldEndSession = false;
                response.Version = "1.0";

                if (input.GetRequestType() == typeof(LaunchRequest))
                {
                    ProcessLaunchRequest(response.Response);
                }
                else if (input.GetRequestType() == typeof(IntentRequest))
                {
                    ProcessIntentRequest(input);
                }
                Log(JsonConvert.SerializeObject(response));
                return response;
            }
            catch (Exception ex)
            {
                Log($"error : {ex.Message}");
            }
            return null;
        }

        private void ProcessLaunchRequest(ResponseBody response)
        {
            IOutputSpeech innerResponse = new SsmlOutputSpeech();
            (innerResponse as SsmlOutputSpeech).Ssml = SsmlDecorate(resource.LaunchMessage);
            response.OutputSpeech = innerResponse;
            IOutputSpeech prompt = new PlainTextOutputSpeech();
            (prompt as PlainTextOutputSpeech).Text = resource.LaunchMessageReprompt;
            response.Reprompt = new Reprompt()
            {
                OutputSpeech = prompt
            };
        }

        private IOutputSpeech ProcessIntentRequest(SkillRequest input)
        {
            IOutputSpeech innerResponse = new PlainTextOutputSpeech();

            var intentName = ((IntentRequest)input.Request).Intent.Name;

            switch (intentName)
            {
                case BuiltInIntent.Yes:
                    innerResponse = new SsmlOutputSpeech();
                    (innerResponse as SsmlOutputSpeech).Ssml = ProcessYesIntent(input.Session.Attributes);
                    break;
                case BuiltInIntent.No:
                    innerResponse = new SsmlOutputSpeech();
                    (innerResponse as SsmlOutputSpeech).Ssml = ProcessNoIntent(input.Session.Attributes);
                    break;
                case BuiltInIntent.Cancel:
                case BuiltInIntent.Stop:
                    (innerResponse as PlainTextOutputSpeech).Text = resource.StopMessage;
                    response.Response.ShouldEndSession = true;
                    break;
                case BuiltInIntent.Help:
                    (innerResponse as PlainTextOutputSpeech).Text = resource.HelpMessage;
                    break;
                default:
                    (innerResponse as PlainTextOutputSpeech).Text = resource.HelpReprompt;
                    break;
            }
            if (innerResponse.Type == "SSML")
            {
                BuildCard(resource.SkillName, (innerResponse as SsmlOutputSpeech).Ssml);
                (innerResponse as SsmlOutputSpeech).Ssml = SsmlDecorate((innerResponse as SsmlOutputSpeech).Ssml);
            }

            return innerResponse;
        }

        private string ProcessYesIntent(Dictionary<string, object> attributes)
        {
            if (attributes.Count == 0)
            {
                attributes.Add("Question", 2);
                response.SessionAttributes = attributes;
                return "Excellent!";
            }
            return null;
        }

        private string ProcessNoIntent(Dictionary<string, object> attributes)
        {
            if (attributes.Count == 0)
            {
                response.Response.ShouldEndSession = true;
                return "Boo!";
            }
            return null;
        }

        private string SsmlDecorate(string speech)
        {
            return $"<speak>{speech}</speak>";
        }
        private void BuildCard(string title, string output)
        {
            if (!String.IsNullOrEmpty(output))
            {
                output = Regex.Replace(output, @"<.*?>", "");
                response.Response.Card = new SimpleCard()
                {
                    Title = title,
                    Content = output,
                };
            };
        }
        private void Log(string text)
        {
            if (context != null)
            {
                context.Logger.LogLine(text);
            }
        }
    }
}


