using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gatcha
{
    class AllEquip
    {
        public static List<Item> allEquip = new List<Item>();

        public static void load()
        {
            XElement xdoc = XElement.Load("allEquip.xml");
            var xEquip = xdoc.Elements("item").OrderBy(x=>x.Element("name").Value);
            foreach (var item in xEquip)
            {
                Item temp = new Item();
                temp.name = item.Element("name").Value;
                temp.rare = int.Parse(item.Element("rare").Value);
                allEquip.Add(temp);
            }
        }
    }
}
