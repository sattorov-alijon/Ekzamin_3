namespace Tasc6;

public class BigDog : Dog
{
    public BigDog(string name) : base(name)
    {
    }
    public void Greets()
    {
        System.Console.WriteLine("Wooow");
    }
    public override void Greets(Dog another)
    {
            System.Console.WriteLine("Wooooooow");
    }
    public  void Greets(BigDog another)
    {
            System.Console.WriteLine("Woooooooooow");
    }
}
