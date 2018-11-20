using System;
using Newtonsoft.Json;
using Alexa.NET.Response;
using Alexa.NET.Request;
using Amazon.Lambda.Core;
using Alexa.NET.Request.Type;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AlexaDontDie
{
    public class Function
    {
        private SkillResponse response = null;
        private ILambdaContext context = null;

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
                response = new SkillResponse();
                response.Response = new ResponseBody();
                response.Response.ShouldEndSession = false;
                response.Version = "1.0";

                if (input.GetRequestType() == typeof(LaunchRequest))
                {
                    ProcessLaunchRequest(response.Response);
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
            (innerResponse as SsmlOutputSpeech).Ssml = "<speak>Welcome to Don't Die. Try not to die.</speak>";
            response.OutputSpeech = innerResponse;
            IOutputSpeech prompt = new PlainTextOutputSpeech();
            (prompt as PlainTextOutputSpeech).Text = "Say yes or no";
            response.Reprompt = new Reprompt()
            {
                OutputSpeech = prompt
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


