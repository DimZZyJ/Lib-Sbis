using Newtonsoft.Json;
using SBISLib.DocumentClasses;
using System;

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
            return Json;

        }

    }
}
