using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp25
{
    public class PeoplesList
    {
        public List<Person> Peeps { get; set; } = new List<Person>()
        {
            new Person() { Firstname = "John", Lastname = "Carlson", Age = 18},
            new Person() { Firstname = "Renee", Lastname = "Duboire", Age = 25},
            new Person() { Firstname = "Albert", Lastname = "Blucher", Age = 22},
            new Person() { Firstname = "Paul", Lastname = "Garcia", Age = 54}
        };


        //public void SerializePerson()
        //{
        //    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\person.xml";

        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

        //    serializer.Serialize(File.Create(path), Peeps);
        //}

        public void DeserializePer()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\person.xml";

            XmlSerializer deserialize = new XmlSerializer(typeof(List<Person>));

            List<Person> person = (List<Person>)deserialize.Deserialize(File.OpenRead(path));

            foreach(var item in person)
            {
                Console.WriteLine(item);
            }
        }
    }
}
