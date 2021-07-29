using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ComboBox
{
    class UpdateLanguage
    {
        public void UpdateConfig(string key, string value)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach(XmlElement xmlElem in xmlDoc.DocumentElement)
            {
                if (xmlElem.Name.Equals("appSettings"))
                {
                    foreach(XmlNode node in xmlElem.ChildNodes)
                    {
                        if (node.Attributes[0].Value.Equals(key))
                        {
                            node.Attributes[1].Value = value;
                        }
                    }
                }
            }

            ConfigurationManager.RefreshSection("appSettings");
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}
