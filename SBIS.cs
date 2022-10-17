using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SBISLib.DocumentClasses;
using SBISLib.HTTP_request_classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static SBISLib.DocumentClasses.DocObject;

namespace Lib_Sbis
{
    [ClassInterface(ClassInterfaceType.None), Guid("7EA2F7ED-2046-4AC3-A0A0-34CB508C8D21"), ProgId("Lib-Sbis.SBIS")]
    public class SBIS : ISBIS
    {
        private string sessionid = null;
        private HttpConnection connection=null;

        public void Connect(string login, string password)
        {
            connection = new HttpConnection(login, password);
            connection.Connect();
            sessionid = connection.GetSessionId();
        }
        
        public void Disconnect()
        {
            if (sessionid != null)
            {
                connection.Disconnect();
            }
        }

        public ArrayList GetDocuments()
        {
            ArrayList docslist = new ArrayList();
            DocumentRequest documentRequest = new DocumentRequest();
            DocFilter docfilter = new DocFilter("ДоговорДок", new Навигация("0"));
            documentRequest.DocFilter = docfilter;
            if (sessionid != null)
            {
                
                docslist = RequestAndSerialize(documentRequest);
                return docslist;
            }
            else
            {
                Console.WriteLine("no session id");
                return null;
            }


        }

        public ArrayList GetDocumentsTypeFilter(string type, string inn = null, string dateFrom = null, string dateTo = null)
        {
            //TODO: Реализуй ограничение по выдаче документов
            DocumentRequest documentRequest = new DocumentRequest();
            
            DocFilter docfilter = new DocFilter(type,new Навигация("0"));
            if (dateFrom != null)
                docfilter.ДатаС = dateFrom;
            if (dateTo != null)
                docfilter.ДатаПо = dateTo;
            if (inn != null)
            {
                Контрагент контрагент = new Контрагент();
                Свюл свюл = new Свюл();
                свюл.ИНН = inn;
                контрагент.СвЮЛ = свюл;
                docfilter.Контрагент = контрагент;
            }
                
            documentRequest.DocFilter = docfilter;


            ArrayList docslist = RequestAndSerialize(documentRequest);
            if (docslist.Count == 0 && inn != null)
            {
                docfilter.Контрагент.СвЮЛ = null;
                Свфл свфл = new Свфл();
                свфл.ИНН = inn;
                docfilter.Контрагент.СвФЛ = свфл;
                docslist = RequestAndSerialize(documentRequest);
            }
            return docslist;
        }
        ArrayList FillDocList(ArrayList docslist,Документ[] документ)
        {
            for (int i = 0; i < документ.Length; i++)
            {
                docslist.Add(документ[i]);
            }
            return docslist;
        }
        ArrayList RequestAndSerialize(DocumentRequest documentRequest)
        {
            ArrayList docslist = new ArrayList();
            string docJson = documentRequest.GetDocument(sessionid);
            Rootobject rootobject = JsonConvert.DeserializeObject<Rootobject>(docJson);
            string more = rootobject.result.Навигация.ЕстьЕще;
            int page = int.Parse(rootobject.result.Навигация.Страница);
            Документ[] документы = rootobject.result.Документ;
            docslist = FillDocList(docslist, документы);
            while (more == "Да")
            {
                page++;
                documentRequest.DocFilter.Навигация.Страница=page.ToString();
                docJson = documentRequest.GetDocument(sessionid);
                rootobject = JsonConvert.DeserializeObject<Rootobject>(docJson);
                документы = rootobject.result.Документ;
                more = rootobject.result.Навигация.ЕстьЕще;
                docslist = FillDocList(docslist, документы);
                
            }
            return docslist;
        }
    }
}
