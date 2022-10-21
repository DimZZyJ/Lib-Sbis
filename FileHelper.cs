using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Sbis
{
    public class FileHelper
    {
        public FileInfo[] GetFilesInfoList()
        {
            string Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\zip";
            DirectoryInfo directoryInfo = new DirectoryInfo(Dir);
            FileInfo[] files = directoryInfo.GetFiles("*.zip");
            string tmp = Dir + @"\Счет-фактура полученный № 7775 от 16.09.2022 на сумму 67100.00.zip";
            GetXMLFromZip(tmp);
            return files;
        }
        public void GetXMLFromZip(string path)
        {
            using (var zip = ZipFile.Open(path,ZipArchiveMode.Read))
            {
                var smt = zip.Entries;
            }
        }
        //TODO: организуй парсинг xml из архива
        //TODO: Парсин из массива 

    }
}
