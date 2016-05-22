using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace StackOverflow_Solve.geolocation
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Customer
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }

        //[XmlElement(IsNullable = true)]
        [DefaultValue(null)]
        public Address1 Address
        {
            get;
            set;
        }
        public static bool IsAnyNullOrEmpty(Address1 myObject)
        {
            Boolean isAllNull = true;
            foreach (PropertyInfo propertyInfo in myObject.GetType().GetProperties())
            {
               Object obj=  propertyInfo.GetValue(propertyInfo,null);
               if (obj != null)
               {
                   isAllNull = false;
                   break;
               }
            }

            return isAllNull;
        }
    }

    public class Address1
    {
        public String Type { get; set; }
    }

    public partial class geolocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var myobject = @"<Customer>
<FirstName>SomeValue</FirstName>
<LastName>Somevalue</LastName>
<Address/>
</Customer>";
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            using (StringReader reader = new StringReader(myobject))
            {
                Customer customer = (Customer)(serializer.Deserialize(reader));
                if (customer != null)
                {
                    if (Customer.IsAnyNullOrEmpty(customer.Address))
                    {
                        customer.Address = null;
                        
                    }

                }

            }
        }
    }
}