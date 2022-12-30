using System.Runtime;

namespace prototype_pattern
{
    public class Person : ICloneable
    {
        public string Name { get; set; } = new("");
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public AddressDetails AddressDetails { get; set; }

        public object Clone()
        {
            return (Person) MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.AddressDetails = new AddressDetails(AddressDetails.Address, AddressDetails.DoorNumber);
            clone.Name = new string(Name.ToArray());
            return clone;
        }
     }

    public class AddressDetails
    {
        public string Address { get; set; }
        public int DoorNumber { get; set; }

        public AddressDetails(string address, int doorNumber)
        {
            Address = address;
            DoorNumber = doorNumber;
        }
    }
}
