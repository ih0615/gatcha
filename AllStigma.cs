using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gatcha
{
    class AllStigma
    {
        public static List<Item> allStigma = new List<Item>();

        public static void load()
        {
            XElement xdoc = XElement.Load("allStigma.xml");
            var xStigma = xdoc.Elements("item").OrderBy(x => x.Element("name").Value);
            foreach (var item in xStigma)
            {
                Item temp = new Item();
                temp.name = item.Element("name").Value;
                temp.rare = int.Parse(item.Element("rare").Value);
                allStigma.Add(temp);
            }
        }
    }
}
