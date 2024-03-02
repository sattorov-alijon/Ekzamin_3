using Tasc5;

var person=new Person("Alijon","");
person.SetAddress("Hamadoni");
System.Console.WriteLine(person.GetName());
System.Console.WriteLine(person.GetAddress());
System.Console.WriteLine(person.ToString());
System.Console.WriteLine();
System.Console.WriteLine("________________________________");
System.Console.WriteLine();

var student=new Student("Alijon","Hamadoni","",22,3900);
student.SetProgram("c#");
student.SetFee(4300);
System.Console.WriteLine(student.ToString());
System.Console.WriteLine();
System.Console.WriteLine("________________________________");
System.Console.WriteLine();

var staff=new Staff("Alijon","Hamadoni","",5900);
staff.SetSchool("DMT");
staff.SetPay(7300);
System.Console.WriteLine(staff.ToString());