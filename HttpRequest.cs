using System.IO;
using System.Net;

namespace SBISLib.HTTP_request_classes
{
    public class HttpRequest
    {
        public static string Request(string json, string link, string sessionid = null)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            httpWebRequest.ContentType = "application/json-rpc;charset=utf-8";
            httpWebRequest.Method = "POST";
            if (sessionid != null)
                httpWebRequest.Headers.Add("X-SBISSessionID:" + sessionid);
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var resultJson = streamReader.ReadToEnd();
                return resultJson;
            }
        }
    }
}