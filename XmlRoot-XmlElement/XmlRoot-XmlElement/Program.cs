using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XmlRoot_XmlElement
{
   
    [XmlRoot("addressBook")]
    public class AddressBook
    {
        
        [XmlElement("owner")]
        public Contact Owner;

        
        [XmlElement("contact")]
        public Contact[] Contacts;
    }

    public class Contact
    {
        
        [XmlAttribute("firstName")]
        public string FirstName;

        [XmlAttribute("lastName")]
        public string LastName;

        [XmlElement("tel1")]
        public string PhoneNumber;

        [XmlElement("email")]
        public string EmailAddress;

        public Contact()
        {
        }
        public Contact(string fN, string lN, string tel, string ema)
        {
            FirstName = fN;
            LastName = lN;
            PhoneNumber = tel;
            EmailAddress = ema;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook a = new AddressBook();
            a.Owner = new Contact("YO","","","");
            Contact c1 = new Contact("Bea","García","956123123","ja@ja.com");
            Contact c2 = new Contact("Isa", "Gómez", "956145145", "is@ja.com");
            a.Contacts = new Contact[3];
            a.Contacts[0] = c1;
            a.Contacts[1] = c2;
            Console.WriteLine("Libreta de direcciones creada");
            FileStream f = new FileStream("telefonos.xml", FileMode.Create);
            XmlSerializer x = new XmlSerializer(typeof(AddressBook));
            x.Serialize(f, a);
            f.Close();
            AddressBook a2 = new AddressBook();
            f = new FileStream("telefonos.xml", FileMode.Open);
            a2 = (AddressBook)x.Deserialize(f);
            Console.WriteLine(a2.Contacts[0].FirstName);
            Console.ReadKey();
        }
    }
}
