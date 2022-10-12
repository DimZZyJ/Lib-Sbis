
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;

namespace SBISLib.HTTP_request_classes
{
    public class HttpConnection : HttpRequest
    {


        public string Login { get; set; }
        public string Password { get; set; }
        public string sessionid { get; set; }
        public HttpConnection(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public string GetSessionId()
        {
            return sessionid;
        }

        public void Connect()
        {
            string jsonRequets = $"{{\r\n   \"jsonrpc\": \"2.0\",\r\n   \"method\": \"СБИС.Аутентифицировать\",\r\n   \"params\": {{\r\n      \"Параметр\": {{\r\n         \"Логин\": \"{Login}\",\r\n         \"Пароль\": \"{Password}\"\r\n      }}\r\n   }},\r\n   \"id\": 0\r\n}}";
            string link = "https://online.sbis.ru/auth/service/";
            string Json = Request(jsonRequets, link);
            var jo = JObject.Parse(Json);
            sessionid = jo["result"].ToString();
        }

        public void Disconnect()
        {
            string jsonRequest= "{\r\n  \"jsonrpc\": \"2.0\",\r\n  \"method\": \"СБИС.Выход\",\r\n  \"params\": {},\r\n  \"id\": 0\r\n}";
            string link = "https://online.sbis.ru/auth/service/";
            Request(jsonRequest, link,sessionid);
        }
    }
}

