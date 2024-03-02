using Tasc6;

var cat=new Cat("test");
cat.Greets();
System.Console.WriteLine("- - - - -- - -- - - -- - -");

var dog=new Dog("test");
dog.Greets();
dog.Greets(dog);
System.Console.WriteLine("- - - - -- - -- - - -- - -");

var bigDog=new BigDog("test");
bigDog.Greets();
bigDog.Greets(dog);
bigDog.Greets(bigDog);