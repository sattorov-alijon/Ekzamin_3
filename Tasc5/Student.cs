namespace Tasc5;

public class Student:Person
{
    string _program;
    int _year;
    double _fee;
    public Student(string name,string address,string program,int year,double fee):base(name,address)
    {
        _program=program;
        _year=year;
        _fee=fee;
    }
         public string GetProgram()
    {
        return _program;
    }
    public void SetProgram(string program)
    {
        _program=program;
    }
         public int GetYear()
    {
        return _year;
    }
    public void Setyear(int year)
    {
        _year=year;
    }
         public double GetFee()
    {
        return _fee;
    }
    public void SetFee(double fee)
    {
        _fee=fee;
    }
    
    public override string ToString()
    {
        return $"{base.ToString()} ,program={_program}, year={_year}, fee={_fee}";
    }

   
}
