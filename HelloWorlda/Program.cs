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
    public static void task2() 
    {
        for(int _i = 1; _i < 10; _i++)
        {
            Console.WriteLine($"{_i} x 7 = {7 * _i}");
        }
    }
    public static void task3() 
    {
        for(int _i = 1; _i < 10; _i++)
        {
            int j = 0;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var str = Console.ReadLine();
        Tasks.task1(str);
        Tasks.task2();
        Tasks.task3();
    }
}
