using System;
using Newtonsoft.Json.Linq;

namespace Apache.OpenWhisk.UnicodeTests.Dotnet
{
    public class Unicode
    {
        public JObject Main(JObject args)
        {
            string delimiter = args["delimiter"].ToString();
            JObject message = new JObject();
            string output = $"{delimiter} ☃ {delimiter}";
            message.Add("winter", new JValue(output));
            Console.WriteLine(output);
            return (message);
        }
    }
}