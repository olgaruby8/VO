using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ViewOrders
{
    class Item
    {
        public Item(XmlNode item)
        {
            Id = item.Attributes["id"]?.Value;
            Name = item.Attributes["name"]?.Value;
            Properties = new List<Property>();
            var properties = item.FirstChild;
            if (properties == null)
            {
                return;
            }
            foreach (XmlNode property in properties.ChildNodes)
            {
                Properties.Add(new Property(property));
            }
        }
        public string Id { get; private set; }
        public string Name { get; private set; }
        public List<Property> Properties { get; private set; }


    }
}
