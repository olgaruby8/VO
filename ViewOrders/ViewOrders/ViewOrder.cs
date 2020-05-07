using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ViewOrders
{
    class ViewOrder
    {
        public ViewOrder(string path)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            var viewOrderNodes = xmlDoc.GetElementsByTagName("vieworder");
            if (viewOrderNodes.Count != 1)
            {
                throw new Exception("Amount of ViewOrder nodes is not exactly 1.");
            }
            var viewOrderNode = viewOrderNodes[0];
            Id = viewOrderNode.Attributes["id"]?.Value;
            Items = new List<Item>();
            foreach (XmlNode item in ((XmlElement)viewOrderNode).GetElementsByTagName("item"))
            {
                Items.Add(new Item(item));
            }
            
            //Console.WriteLine(Items[1].Name);
            //var items = ((XmlElement)viewOrderNode).GetElementsByTagName("item");
            //for (int i =0; i< items.Count; ++i)
            //{
              //  Items.Add(new Item(items[i]));
            //}
        }

        public string Id { get; private set; }
        public List<Item> Items { get; private set; }


    }
}

