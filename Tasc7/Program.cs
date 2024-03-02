using System.ComponentModel.DataAnnotations;

List<int> list=new List<int>(){1,0,5,-4,5,10,-80,24,0,-4,100,24,45,6,-1};

int max=list[0];
for (int i = 1; i < list.Count; i++)
{
    if (list[i]>max)
    {
        max=list[i];
        
    }
}
System.Console.WriteLine(max);
System.Console.WriteLine("___________________________");
System.Console.WriteLine();

for (int i = 0; i < list.Count; i++)
{

    for (int j = 0; j < list.Count; j++)
    {
    if (list[i]==list[j] && i!=j)
        {
        list.RemoveAt(j);

        }
    }
    
}

for (int i = 0; i < list.Count; i++)
{
    System.Console.Write(list[i]+" ");
}

System.Console.WriteLine();
System.Console.WriteLine("-----------------------------");

list.Sort();
for (int i = 0; i < list.Count; i++)
{
    System.Console.Write(list[i]+" ");
}
System.Console.WriteLine();
System.Console.WriteLine("-----------------------------");

for (int i = 0; i < list.Count; i++)
{
    if (list[i]<0)
    {
        list[i]=0;
    }
}
for (int i = 0; i < list.Count; i++)
{
    System.Console.Write(list[i]+" ");
}