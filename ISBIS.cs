using Lib_Sbis.SimpleObjects;
using SBISLib.DocumentClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Sbis
{
    [InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("1E6B2DD6-841A-4317-B3C6-EBA46D1A200C")]
    public interface ISBIS
    {
        void Connect(string login, string password);
        void Disconnect();
        ArrayList GetDocuments();
        ArrayList GetDocumentsTypeFilter(string type, string inn,string dateFrom , string dateTo);
        ArrayList GetDocumentsByFilterObject(SimpleDocFilter simpleDocFilter);
        SimpleDocFilter GetFilterObject();
    }
}
