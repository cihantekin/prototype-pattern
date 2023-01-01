// See https://aka.ms/new-console-template for more information
using prototype_pattern;

Console.WriteLine("Hello, World!");


Person person1 = new()
{
    Name = "Cihan",
    Age = 32,
    BirthDate = new DateTime(1990, 10, 7),
    AddressDetails = new AddressDetails("Amsterdam", 199)
};

Person person2 = (Person)person1.Clone();

Person person3 = person1.DeepCopy();

DisplayValues(person1);
DisplayValues(person2);
DisplayValues(person3);

person1.Name = "Kaan";
person1.Age = 28;
person1.BirthDate = new DateTime(1994, 9, 6);
person1.AddressDetails.Address = "Istanbul";
person1.AddressDetails.DoorNumber = 9;


DisplayValues(person1);

//Person2 address details will be effected by the changes on Person1 as it is a ShallowCopy
// Also string Name value wont be effected as it is immutable
DisplayValues(person2);

//Person3 wont be effected by the changes on Person1 as it is a deep copy.
DisplayValues(person3);

static void DisplayValues(Person p)
{
    Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
        p.Name, p.Age, p.BirthDate);
    Console.WriteLine("      Address: {0:s} DoorNumber {1:d}" , p.AddressDetails.Address, p.AddressDetails.DoorNumber);
}