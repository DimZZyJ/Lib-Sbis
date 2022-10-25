using Lib_Sbis.Document;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Xml.Serialization;

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
                        entry.ExtractToFile(pathout+@"\"+i+".xml");
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
                GetXMLFromZip(zipsInfo[i].FullName, Dir +@"\xml\"+zipsInfo[i].Name);
            }
            
        }
        public СчетФактура.Файл DeserializeXML()
        {
            СчетФактура.Файл счетФактура;
            string path = @"C:\Users\it-3\source\repos\ConsoleAppTEST\bin\Debug\xmls\Счет-фактура полученный № 8760 от 13.10.2022 на сумму 227311.20.zip\0.xml";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(СчетФактура.Файл));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                счетФактура = (СчетФактура.Файл)xmlSerializer.Deserialize(fs);
            }
            return счетФактура;
        }
    }
}
