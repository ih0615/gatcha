using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace gatcha
{
    class ItemManager
    {
        public static Item pickUpEquip = new Item();
        public static List<Item> pickUpStigma = new List<Item>();
        public static List<Item> equip = new List<Item>();
        public static List<Item> stigma = new List<Item>();

        public static void load()
        {
            pickUpEquip = null;
            pickUpStigma.Clear();
            equip.Clear();
            stigma.Clear();

            String url = "itemList.xml";
            try
            {
                XElement itemXElement = XElement.Load(url);
                var items = itemXElement.Elements("item");
                foreach (var item in items)
                {
                    if (item.Attribute("type").Value == "pickUpEquip")
                    {
                        Item temp = new Item();
                        temp.name = item.Element("name").Value;
                        temp.rare = int.Parse(item.Element("rare").Value);
                        pickUpEquip=temp;
                    }
                    if (item.Attribute("type").Value == "pickUpStigma")
                    {
                        Item temp = new Item();
                        temp.name = item.Element("name").Value;
                        temp.rare = int.Parse(item.Element("rare").Value);
                        pickUpStigma.Add(temp);
                    }
                    if (item.Attribute("type").Value == "equip")
                    {
                        Item temp = new Item();
                        temp.name = item.Element("name").Value;
                        temp.rare = int.Parse(item.Element("rare").Value);
                        equip.Add(temp);
                    }
                    if (item.Attribute("type").Value == "stigma")
                    {
                        Item temp = new Item();
                        temp.name = item.Element("name").Value;
                        temp.rare = int.Parse(item.Element("rare").Value);
                        stigma.Add(temp);
                    }
                }
            }
            catch
            {
                XDocument xdoc = new XDocument(new XDeclaration("1.0", "UTF-8", null));
                XElement xroot = new XElement("items");
                //픽업 장비 삽입
                XElement xPickUpEquip = new XElement("item",new XAttribute("type","pickUpEquip"),new XElement("name","지정되지 않음"),new XElement("rare","4"));
                xroot.Add(xPickUpEquip);
                //픽업 성흔 삽입
                for(int i=0; i<3; i++)
                {
                    String stigma_name = "지정되지 않음";
                    String stigma_part = "";
                    if (i % 3 == 0)
                    {
                        stigma_part = "상";
                    }
                    else if (i % 3 == 1)
                    {
                        stigma_part = "중";
                    }
                    else
                    {
                        stigma_part = "하";
                    }
                    XElement xPickUpStigma = new XElement("item", new XAttribute("type", "pickUpStigma"), new XElement("name", stigma_name+"-"+stigma_part), new XElement("rare", "4"));
                    xroot.Add(xPickUpStigma);
                }
                //일반 장비 삽입
                for(int i = 0; i < 6; i++)
                {
                    String equip_name="지정되지 않음";
                    XElement xEquip = new XElement("item", new XAttribute("type", "equip"), new XElement("name", equip_name), new XElement("rare", "4"));
                    xroot.Add(xEquip);
                }
                //일반 성흔 삽입
                for (int i = 0; i < 12; i++)
                {
                    String stigma_name = "지정되지 않음";
                    String stigma_part = "";
                    
                    if (i % 3 == 0)
                    {
                        stigma_part = "상";
                    }
                    else if (i % 3 == 1)
                    {
                        stigma_part = "중";
                    }
                    else
                    {
                        stigma_part = "하";
                    }
                    XElement xStigma = new XElement("item", new XAttribute("type", "stigma"), new XElement("name", stigma_name + "-" + stigma_part), new XElement("rare", "4"));
                    xroot.Add(xStigma);
                }

                xdoc.Add(xroot);
                xdoc.Save("itemList.xml");
                load();
            }
        }
    }
}

