namespace CanimIsmayil;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public static event Action OnCreating;

    static void PersonCreate()
    {
        Person person1 = new PersonFactory().Create("Faig", "Rasulzada", 22);

        OnCreating?.Invoke();

    }

    public Person AddName(string name)
    {
        //100lerle shert
        Name = name;
        return this;
    }

    public Person AddSurnmae(string surname)
    {
        //100lerle shert
        Surname = surname;
        return this;
    }
    public Person AddAge(int age)
    {
        //100lerle shert
        Age = age;
        return this;
    }

    public Person Build()
    {
        return this;
    }
}
