namespace CanimIsmayil
{
    public class PersonFactory
    {
        public Person Create(string name , string surname, int age)
        {
            return new Person()
            {
                Age = age,
                Name = name,
                Surname = surname,
            };
        }
    }
}
