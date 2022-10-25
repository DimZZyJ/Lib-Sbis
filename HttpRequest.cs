using System.IO;
using System.Net;

namespace SBISLib.HTTP_request_classes
{
    public class HttpRequest
    {
        public static string RequestPost(string link, string json = null, string sessionid = null)
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
                var answer = streamReader.ReadToEnd();
                return answer;
            }
        }
        public static void RequestGet(string link,string path, string sessionid)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            httpWebRequest.ContentType = "application/json-rpc;charset=utf-8";
            httpWebRequest.Method = "GET";
            if (sessionid != null)
                httpWebRequest.Headers.Add("X-SBISSessionID:" + sessionid);
            using (var s = httpWebRequest.GetResponse().GetResponseStream())
            {
                using (var w = File.OpenWrite(path))
                {
                    s.CopyTo(w);
                }
            }
        }
    }
}