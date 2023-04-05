using System.Net.Http.Headers;

namespace HelloWorld;
class Tasks
{
    public static void task1() 
    {
        var str = Console.ReadLine();
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
    public static void task4() 
    {
        for(int _i = 0; _i < 5; _i++)
        {
            for(int _j = 5 - _i; _j <= 5; _j++)
            {
                Console.Write("5 ");
            }
            Console.WriteLine();
        }

        for(int _i = 0; _i < 5; _i++)
        {
            for(int _j = 1; _j <= 5 - _i; _j++)
            {
                Console.Write("1 ");
            }
            Console.WriteLine();
        }

        int _temp = 0;
        for(int _i = 0; _i < 5; _i++)
        {
             _temp++; 
            for(int _j = 5 - _i; _j <= 5; _j++)
            {
                Console.Write($"{_temp * 10} ");
            }
            Console.WriteLine();
        }
        
        _temp = 0;
        for(int _i = 0; _i < 5; _i++)
        {
            _temp++;
            for(int _j = 1; _j <= 5 - _i; _j++)
            {
                Console.Write($"{_temp * 5} ");
            }
            Console.WriteLine();
        }
    }
    public static double task6(int a)
    {
        double _answer = (12 * Math.Pow(a, 2)) + 7 * a + 12;
        return _answer;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        
        Tasks.task1();
        Tasks.task2();
        Tasks.task3();
        Console.WriteLine(Tasks.task4(6));
        Tasks.task4();
        Console.WriteLine(Tasks.task6(6));
    }
}
