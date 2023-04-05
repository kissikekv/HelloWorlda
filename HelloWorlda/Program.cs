namespace HelloWorld;
class Tasks
{
    public static void task1(string str) 
    {
        for(int _i = 0; _i < str.Length; _i++)
        {
            Console.WriteLine(str[_i]);
        }
    } 
}

class Program
{
    public static void Main(string[] args)
    {
        var str = Console.ReadLine();
        Tasks.task1(str);
    }
}
