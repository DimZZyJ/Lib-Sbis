using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Lib_Sbis
{
    public class FileHelper
    {
        FileInfo[] GetFilesInfoList()
        {
            string Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\zip";
            DirectoryInfo directoryInfo = new DirectoryInfo(Dir);
            FileInfo[] files = directoryInfo.GetFiles("*.zip");
            return files;
        }
        void GetXMLFromZip(string pathin,string pathout)
        {
            Directory.CreateDirectory(pathout);
            using (var zip = ZipFile.Open(pathin,ZipArchiveMode.Read))
            {
                int i = 0; ;
                foreach (var entry in zip.Entries)
                {
                    if (entry.Name.EndsWith(".xml"))
                    {
                        entry.ExtractToFile(pathout+@"\"+i+".xml");//уменьшить путь
                    }
                    i++;
                }
                
            }
        }
        public void ExtractXMLFromArchives()
        {
            string Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            FileInfo[] zipsInfo = GetFilesInfoList();
            for (int i = 0; i < zipsInfo.Length; i++)
            {
                GetXMLFromZip(zipsInfo[i].FullName, Dir +@"\xmls\"+zipsInfo[i].Name);
            }

        }
        //TODO: организуй парсинг xml из архива
        //TODO: Парсин из массива 

    }
}
