using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ViewOrders
{
    class Property
    {
        public Property(XmlNode property)
        {
            Id = property.Attributes["id"]?.Value;
            Name = property.Attributes["name"]?.Value;
            Val = property.Attributes["val"]?.Value;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Val { get; private set; }
    }
}
