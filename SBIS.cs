using Lib_Sbis.Document;
using Lib_Sbis.SimpleObjects;
using Newtonsoft.Json;
using SBISLib.DocumentClasses;
using SBISLib.HTTP_request_classes;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
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
            DocumentRequest documentRequest = new DocumentRequest();
            
            DocFilter docfilter = new DocFilter(type,new Навигация("0"));
            if (dateFrom != null)
                docfilter.ДатаС = dateFrom;
            if (dateTo != null)
                docfilter.ДатаПо = dateTo;
            if (inn != null)
            {
                Контрагент контрагент = new Контрагент();
                Свюл свюл = new Свюл{ИНН = inn};
                контрагент.СвЮЛ = свюл;
                docfilter.Контрагент = контрагент;
            }
                
            documentRequest.DocFilter = docfilter;


            ArrayList docslist = RequestAndSerialize(documentRequest);
            if (docslist.Count == 0 && inn != null)
            {
                docfilter.Контрагент.СвЮЛ = null;
                Свфл свфл = new Свфл{ИНН = inn};
                docfilter.Контрагент.СвФЛ = свфл;
                docslist = RequestAndSerialize(documentRequest);
            }
            return docslist;
        }
        public ArrayList GetDocumentsByFilterObject(SimpleDocFilter simpleDocFilter)
        {
            string inn = simpleDocFilter.ИНН;
            DocFilter docfilter = ParseSimpleObject(simpleDocFilter);
            DocumentRequest documentRequest = new DocumentRequest();
            documentRequest.DocFilter = docfilter;
            ArrayList docslist = RequestAndSerialize(documentRequest);
            if (docslist.Count == 0 && inn != null)
            {
                docfilter.Контрагент.СвЮЛ = null;
                Свфл свфл = new Свфл { ИНН = inn };
                docfilter.Контрагент.СвФЛ = свфл;
                docslist = RequestAndSerialize(documentRequest);
            }
            return docslist;
        }
        public void GetDocumentPdf(Object obj)
        {
            Документ документ = (Документ)obj;
            string extension = "pdf";
            string link = документ.СсылкаНаPDF;
            if (link != "")
            {
                DocumentRequest document = new DocumentRequest();
                document.GetDocumentFile(sessionid, link, extension,документ.Название);
            }
        }
        public void GetDocumentArchive(Object obj)
        {
            Документ документ = (Документ)obj;
            string extension = "zip";
            string link = документ.СсылкаНаАрхив;
            if (link != "")
            {
                DocumentRequest document = new DocumentRequest();
                document.GetDocumentFile(sessionid,link,extension,документ.Название);
            }
        }
        public void GetDocumentsArchives(ArrayList doclist)
        {
            Документ[] документы = new Документ[doclist.Count];
            документы = FillDocumentArray(документы,doclist);
            string link;
            string extension = "zip";
            DocumentRequest document = new DocumentRequest();
            for (int i = 0; i < документы.Length; i++)
            {
                try
                {
                    link = документы[i].СсылкаНаАрхив;
                    document.GetDocumentFile(sessionid, link, extension, документы[i].Название);
                }
                catch (Exception ex)
                {
                    ExeptionWriter(ex);
                }

            }
        }

        private static void ExeptionWriter(Exception ex)
        {
            string Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            StreamWriter sw = new StreamWriter(Dir + @"\errorlog.txt", true);
            sw.WriteLine(ex.Message);
            sw.Close();
        }

        public void ExtractXMLsFromArchives()
        {
            FileHelper fileHelper = new FileHelper();
            fileHelper.ExtractXMLFromArchives();
        }
        public ArrayList DeserializeXMLs()
        {
            ArrayList DeserializedObjects = new ArrayList();
            FileHelper fileHelper = new FileHelper();
            var DirList = fileHelper.GetDirectoryInfoArray("xml");
            for (int i = 0; i < DirList.Length; i++)
            {
                try 
                {
                    FileInfo[] files = DirList[i].GetFiles("doc*");
                    for (int j = 0; j < files.Length; j++)
                    {
                        var DeserializedObject = fileHelper.DeserializeXML(DirList[i].FullName + @"\" + files[j].Name, typeof(СчетФактура.Файл));
                        DeserializedObjects.Add(DeserializedObject);
                    }
                }
                catch (Exception ex)
                {
                    ExeptionWriter(ex);
                }
            }
            return DeserializedObjects;
        }
        public void GetDocumentsPdfs(ArrayList doclist)
        {
            Документ[] документы = new Документ[doclist.Count];
            документы = FillDocumentArray(документы, doclist);
            string link;
            string extension = "pdf";
            DocumentRequest document = new DocumentRequest();
            for (int i = 0; i < документы.Length; i++)
            {
                link = документы[i].СсылкаНаPDF;
                document.GetDocumentFile(sessionid, link, extension, документы[i].Название);
            }
        }
        public void DeleteDocuments(string type)
        {
            string Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\"+type;
            Directory.Delete(Dir, true);
        }
        public SimpleDocFilter GetFilterObject()
        {
            SimpleDocFilter filter = new SimpleDocFilter();
            return filter;
        }       
        ArrayList RequestAndSerialize(DocumentRequest documentRequest)
        {
            //TODO: Реализуй ограничение по выдаче документов
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
        Документ[] FillDocumentArray(Документ[] документ,ArrayList doclist)
        {
            for (int i = 0; i < doclist.Count; i++)
            {
                документ[i] = (Документ)doclist[i];
            }

            return документ;
        }
        ArrayList FillDocList(ArrayList docslist, Документ[] документ)
        {
            for (int i = 0; i < документ.Length; i++)
            {
                docslist.Add(документ[i]);
            }
            return docslist;
        }
        DocFilter ParseSimpleObject(SimpleDocFilter simpleDocFilter)
        {
            DocFilter docfilter = new DocFilter(simpleDocFilter.Тип, new Навигация("0"));
            docfilter.ДатаС = simpleDocFilter.ДатаС;
            docfilter.ДатаПо=simpleDocFilter.ДатаПо;
            docfilter.Направление = simpleDocFilter.Направление;
            docfilter.Состояние = simpleDocFilter.Состояние;
            if (simpleDocFilter.Email != null || simpleDocFilter.ИдентификаторСПП != null || simpleDocFilter.ИдентификаторИС != null || simpleDocFilter.Телефон != null||simpleDocFilter.ИНН!=null)
            {
                Контрагент контрагент = new Контрагент();
                контрагент.Email = simpleDocFilter.Email;
                контрагент.ИдентификаторИС = simpleDocFilter.ИдентификаторИС;
                контрагент.ИдентификаторСПП = simpleDocFilter.ИдентификаторСПП;
                контрагент.Телефон = simpleDocFilter.Телефон;
                if (simpleDocFilter.ИНН != null)
                {
                    Свюл свюл = new Свюл();
                    свюл.ИНН = simpleDocFilter.ИНН;
                    контрагент.СвЮЛ = свюл;
                }
                docfilter.Контрагент = контрагент;
            }
            return docfilter;
        }

        public string FieldToString(object aParent, string aFieldName)
        {
            PropertyInfo prop = aParent.GetType().GetProperty(aFieldName);
            if (prop != null)
                return prop.GetValue(aParent).ToString();
            else
                return "empty sring";
        }

        public ArrayList ArrayToArrayList(object aParent,string aFieldName)
        {
            PropertyInfo prop = aParent.GetType().GetProperty(aFieldName);
            object[] array = (object[])prop.GetValue(aParent);
            ArrayList arrayList = new ArrayList();
            
            for (int i = 0; i < array.Length; i++)
            {
                arrayList.Add(array[i]);
            }
            return arrayList;
        }

        public ArrayList CreateArrayList()
        {
            ArrayList arrayList = new ArrayList();
            return arrayList;
        }

        public ArrayList AddToArrayList(ArrayList arrayList, object obj)
        {
            arrayList.Add(obj);
            return arrayList;   
        }
    }
}
