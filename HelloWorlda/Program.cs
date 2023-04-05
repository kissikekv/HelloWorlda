using System.Net.Http.Headers;

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
        int _i = 0;
        while (_i < 10) 
        {
            _i++;
        }
    }
    public static int task4(int amountOfElem) 
    {
        Random randNumb = new Random();
        int[] intArr = new int[amountOfElem];
        int _result =0;
        for (int _i = 0; _i < amountOfElem; _i++)
        {
            intArr[_i] = randNumb.Next(1, 25);
            Console.WriteLine(intArr[_i]);
        }
        if (intArr.Contains(22)) 
        {
            int _i = 0;
            while (intArr[_i] != 22) 
            {
                _result += intArr[_i];
               _i++;
            }
            return _result;
        }
        else return _result;
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
        Console.WriteLine(Tasks.task4(6));
    }
}
