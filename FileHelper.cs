using Lib_Sbis.Document;
using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Xml.Serialization;

namespace Lib_Sbis
{
    public class FileHelper
    {
        public void ExtractXMLFromArchives()//exeption writer suda
        {
            string Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            FileInfo[] zipsInfo = GetFilesInfoArray();
            for (int i = 0; i < zipsInfo.Length; i++)
            {
                try
                {
                    GetXMLFromZip(zipsInfo[i].FullName, Dir + @"\xml\" + zipsInfo[i].Name);
                }
                catch (Exception ex)
                {
                    StreamWriter sw = new StreamWriter(Dir + @"\errorlog.txt", true);
                    string time = DateTime.Now.ToString();
                    sw.WriteLine(time+" "+ex.Message);
                    sw.Close();
                }
            }
            
            
            
            
        }
        public FileInfo[] GetFilesInfoArray(string extension=null)
        {
            if (extension == null)
                extension = "zip";
            string Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\"+extension;
            DirectoryInfo directoryInfo = new DirectoryInfo(Dir);
            FileInfo[] files = directoryInfo.GetFiles("*."+extension);
            return files;
        }
        public DirectoryInfo[] GetDirectoryInfoArray(string extension=null)
        {
            if (extension == null)
                extension = "zip";
            string Dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+@"\"+extension;
            DirectoryInfo directoryInfo = new DirectoryInfo(Dir);
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            return directories;
        }
        void GetXMLFromZip(string pathin,string pathout)
        {
            Directory.CreateDirectory(pathout);
            using (var zip = ZipFile.Open(pathin,ZipArchiveMode.Read))
            {
                int i = 0; ;
                foreach (var entry in zip.Entries)
                {
                    if (entry.Name.EndsWith(".xml") && entry.Name.StartsWith("ON_NSCHFDOPPR"))
                    {
                        entry.ExtractToFile(pathout+@"\doc"+i+".xml");
                    }
                    i++;
                }
                
            }
        }
        public Object DeserializeXML(string path, Type type)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                var doc = xmlSerializer.Deserialize(fs);
                return doc;
            }
        }
    }
}
