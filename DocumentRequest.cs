using Newtonsoft.Json;
using SBISLib.DocumentClasses;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SBISLib.HTTP_request_classes
{
    public class DocumentRequest : HttpRequest
    {
        public DocFilter DocFilter { get; set; }
       
        public string GetDocument(string sessionid)
        {
            string jsonRequest = "{\r\n  \"jsonrpc\": \"2.0\",\r\n  \"method\": \"СБИС.СписокДокументов\",\r\n  \"params\": {\r\n    \"Фильтр\": {\r\n      \"Тип\": \"ДоговорДок\",\r\n      \"Навигация\": {\r\n        \"РазмерСтраницы\": \"200\",\r\n        \"Страница\":\"0\"\r\n      }\r\n    }\r\n  },\r\n  \"id\": 0\r\n}";
            if (DocFilter != null)
            {
                
                string filter = JsonConvert.SerializeObject(DocFilter,Formatting.Indented, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
                jsonRequest = "{\r\n  \"jsonrpc\": \"2.0\",\r\n  \"method\": \"СБИС.СписокДокументов\",\r\n  \"params\": {\r\n    \"Фильтр\": " + filter + "\r\n  },\r\n  \"id\": 0\r\n}";

            }
            string link = "https://online.sbis.ru/service/?srv=1";
            string Json = Request(link,jsonRequest,  sessionid);
            //GetSomethingAsync(sessionid);
            return Json;

        }
        //TODO: Организуй передачу ссылки на архив
        public void GetSomethingAsync(string sessionid)
        {
            string link = "https://online.sbis.ru/service/?method=%D0%A4%D0%B0%D0%BA%D1%82%D1%83%D1%80%D0%B0%D0%92%D1%85.%D0%A1%D0%BE%D1%85%D1%80%D0%B0%D0%BD%D0%B8%D1%82%D1%8C%D0%9D%D0%B0%D0%94%D0%B8%D1%81%D0%BA%D0%A0%D0%B5%D0%B4%D0%B0%D0%BA%D1%86%D0%B8%D1%8E&params=eyLQmNC00J4iOiIyODk2In0%3D&protocol=3&id=0&srv=1";
            var result = Request(link,null,sessionid,"GET");
            


        }
    }
}
