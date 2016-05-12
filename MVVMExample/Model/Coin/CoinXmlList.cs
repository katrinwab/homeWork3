using System.Collections.Generic;
using System.Xml;

namespace MVVMExample.Model.Coin
{
    class CoinXmlList: SubjectXmlList, ICoinList
    {
        public CoinXmlList(string nameXml) : base(nameXml)
        {
            List = new List<CoinObject>();
            Init();
        }

        public override void ParseNode(XmlNode node)
        {
            var isBloked = bool.Parse(node.Attributes["isBlocked"].Value);
            var rating = int.Parse(node.InnerText);
            List.Add(new CoinObject(rating, isBloked));
        }

        public List<CoinObject> List { get; set; }
    }
}
