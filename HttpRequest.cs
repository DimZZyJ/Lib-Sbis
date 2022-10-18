using System.IO;
using System.Net;

namespace SBISLib.HTTP_request_classes
{
    public class HttpRequest
    {
        public static string Request(string link, string json = null, string sessionid = null, string method = null)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            httpWebRequest.ContentType = "application/json-rpc;charset=utf-8";
            httpWebRequest.Method = "POST";
            if (method != null)
                httpWebRequest.Method = method.ToUpper();
            if (sessionid != null)
                httpWebRequest.Headers.Add("X-SBISSessionID:" + sessionid);
            if (httpWebRequest.Method == "POST")
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                //TODO:Реализуй метод для получения и записи зип архива
                if (httpWebRequest.Method == "GET")
                {
                    using (var s = httpWebRequest.GetResponse().GetResponseStream())
                    {
                        using (var w = File.OpenWrite(@"C:\MyFile.zip"))
                        {
                            s.CopyTo(w);
                        }
                    }
                }
                var answer = streamReader.ReadToEnd();
                return answer;
            }
        }
    }
}