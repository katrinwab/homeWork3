using System;
using System.IO;
using System.Xml;

namespace MVVMExample.Model
{
    abstract class SubjectXmlList
    {
        protected readonly string NameXml;

        protected SubjectXmlList(string nameXml)
        {
            NameXml = bingPathToAppDir(nameXml);
        }

        private string bingPathToAppDir(string localPath)
        {
            string currentDir = Environment.CurrentDirectory;
            var directory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + localPath)));
            return directory.ToString();
        }

        public void Init()
        {
            using (var stream = new StreamReader(NameXml))
            {
                string line = stream.ReadToEnd();
                var doc = new XmlDocument();
                doc.LoadXml(line);

                if (doc.DocumentElement != null)
                {
                    XmlNodeList elemNodes = doc.DocumentElement.SelectNodes(XmlPath);
                    if (elemNodes != null)
                        foreach (XmlNode elemNode in elemNodes)
                        {
                            ParseNode(elemNode);
                        }
                }
            }
            
        }

        public abstract void ParseNode(XmlNode reader);
        private const string XmlPath = "/Elements/elem";
    }
}
