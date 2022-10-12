using Newtonsoft.Json;
using SBISLib.DocumentClasses;
using SBISLib.HTTP_request_classes;
using System;
using System.Collections;
using System.Runtime.InteropServices;

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
            string docJson;
            DocumentRequest documentRequest = new DocumentRequest();
            if (sessionid != null)
            {
                docJson = documentRequest.GetDocument(sessionid);
                DocObject.Rootobject rootobject = JsonConvert.DeserializeObject<DocObject.Rootobject>(docJson);
                DocObject.Документ[] документ = rootobject.result.Документ;
                for (int i = 0; i < документ.Length; i++)
                {
                    docslist.Add(документ[i]);
                }
                return docslist;
            }
            else
            {
                Console.WriteLine("no session id");
                return null;
            }
        }

        public ArrayList GetDocumentsFilter(string type, string dateFrom = null, string dateTo = null)
        {
            ArrayList docslist = new ArrayList();
            string docJson;
            DocumentRequest documentRequest = new DocumentRequest();
            DocFilter docfilter = new DocFilter(type);
            if (dateFrom != null)
                docfilter.ДатаС = dateFrom;
            if (dateTo != null)
                docfilter.ДатаПо = dateTo;
            documentRequest.DocFilter = docfilter;
            docJson = documentRequest.GetDocument(sessionid);
            DocObject.Rootobject rootobject = JsonConvert.DeserializeObject<DocObject.Rootobject>(docJson);
            DocObject.Документ[] документ = rootobject.result.Документ;
            for (int i = 0; i < документ.Length; i++)
            {
                docslist.Add(документ[i]);
            }
            return docslist;
            
        }
    }
}
