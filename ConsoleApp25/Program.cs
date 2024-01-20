using System.Xml.Serialization;
using ConsoleApp25;


//Person p = new Person() { Firstname = "Artyom", Lastname = "Goofson", Age = 22 };

//string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\person.xml";

//XmlSerializer serializer = new XmlSerializer(typeof(Person));

//serializer.Serialize(File.Create(path), p);


//string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\person.xml";

//XmlSerializer deserialize = new XmlSerializer(typeof(Person));

//Person person = (Person)deserialize.Deserialize(File.OpenRead(path));


//Console.WriteLine(person);


PeoplesList pl = new PeoplesList();

//pl.SerializePerson();

pl.DeserializePer();
