namespace GestAcaLib.Entities
{
    public partial class Person
    {
        public Person(string personId, string name, string address, int zipCode)
        {
            this.ZipCode = zipCode;
            this.Address = address;
            this.Id = personId;
            this.Name = name;
        }

        public Person()
        {

        }
    }
}
