//singleton,builder

using CanimIsmayil;
using CanimIsmayil.Strategy;
#region Singleton
//Singleton singleton = new Singleton();

//Console.WriteLine(Singleton.Instance);
//Console.WriteLine(Singleton.Instance);
//Console.WriteLine(Singleton.Instance);
//Console.WriteLine(Singleton.Instance);
#endregion

#region Builder
//Person person = new Person();

//person
//   .AddName("ismayil")
//   .AddSurnmae("Bekirli")
//   .AddAge(21)
//   .Build();

#endregion

#region factory

//Person person1 = new PersonFactory().Create("Faig", "Rasulzada", 22);

#endregion

#region Observer
//Person.OnCreating += SendMessage;
//Person.OnCreating += Confirmation;

//static void SendMessage()
//{
//    Console.WriteLine("Message sending");
//}
//static void Confirmation()
//{
//    Console.WriteLine("confirmation");
//}
#endregion

#region Strategy
//scoped,singleton, transient
ScopedStrategy scopedStrategy = new ScopedStrategy();
SingletonStrategy seingleStrategy = new SingletonStrategy();
TransientStrategy transientStrategy = new TransientStrategy();

BaseStrategy strategy = scopedStrategy;

strategy.Register();
#endregion

//polymorfizm
//static-overload
//
//dynamic-


