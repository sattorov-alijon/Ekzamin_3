using System.Globalization;

namespace Tasc6;

public abstract class Animal
{
    string _name;
    public Animal(string name)
    {
        _name=name;        
    }
    public abstract void Greets();
}
