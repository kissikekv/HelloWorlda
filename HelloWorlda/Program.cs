namespace HelloWorld;
class Tasks
{
    public static int multiplicityBy17(int c)
    {
        while(c % 17 != 0)
        {
            c++;
        }
        Console.WriteLine(c);
        return c;
    }
    
    public static void multiplicityByC(int a, int b, int c)
    {
        for(int _i = a; _i <= b; _i++)
        {
            if(_i % c == 0)Console.WriteLine(_i);
        }
    }
    
    public static void sumMultiplicityBy4(int a, int b)
    {
        int _sum = 0;
        for(int _i = a; _i <= b; _i++)
        {
            if(_i % 4 == 0) _sum+= _i;
        }
        Console.WriteLine(_sum);
    }
    
    public static void interval()
    {
        int key = Convert.ToInt32(Console.ReadLine());
        if ((key > -5) & (key < 3)) Console.WriteLine(true);
        else Console.WriteLine(false);
    }
    
    public static void dayOfWeek()
    {
        int key = Convert.ToInt32(Console.ReadLine());
        switch (key)
        {
            case 1:
            Console.WriteLine("Monday");
            break;
            case 2:
            Console.WriteLine("Tuesday");
            break;
            case 3:
            Console.WriteLine("Wednesday");
            break;
            case 4:
            Console.WriteLine("Thursday");
            break;
            case 5:
            Console.WriteLine("Friday");
            break;
            case 6:
            Console.WriteLine("Saturday");
            break;
            case 7:
            Console.WriteLine("Sunday");
            break;
            default: 
            Console.WriteLine("Chislo doljno bit ot 1 do 7");
            break;
        }
    }
    
    public static void amountOfUnits(int a)
    {
        Console.WriteLine(a % 10);
    }
    
    public static void amountOfTens(int a)
    {
        Console.WriteLine((a / 10) % 10);
    }
    
    public static void sumOfDigits(int a)
    {
        int _sum = (a / 100) + ((a / 10) % 10) + (a % 10);  
        Console.WriteLine(_sum);
    }
    
    public static void productOfDigits(int a)
    {
        int _product = (a / 100) * ((a / 10) % 10) * (a % 10);  
        Console.WriteLine(_product);
    }
    
    public static void revRead(int a)
    {
        int _rev = (a / 100) + (((a / 10) % 10) * 10) + ((a % 10) * 100);  
        Console.WriteLine(_rev);
    }
    
    public static void firstNSecondSwap(int a)
    {
        int _swap = ((a / 100) * 10) + (((a / 10) % 10) * 100) + (a % 10) ;  
        Console.WriteLine(_swap);
    }
    
    public static void allNumbersTheSame(int a)
    {
        bool _theSame = ((a / 100) == ((a / 10) % 10)) & ((a / 100) == (a % 10)) ? (true) : (false);
        Console.WriteLine(_theSame);
    }
    
    public static void anyNumbersTheSame(int a)
    {
        if(((a / 100) == ((a / 10) % 10)) | (((a / 10) % 10) == (a % 10)) | ((a % 10) == (a / 100))) Console.WriteLine(true);
        else Console.WriteLine(false);
    }
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
    public static void task7()
    {
        int _a = 3;
        int _b = 6; 
        _a = _b + _a;
        _b = _a - _b;
        _a = _a - _b;
        Console.WriteLine($"a = {_a} b = {_b}");
    }
    public static string task8(double rad, double side)
    {
        string shape;
        if((Math.PI * Math.Pow(rad, 2)) > (Math.Pow(side, 2)))
        {
            shape = "circle";
        }
        else
        { 
            if (Math.PI * Math.Pow(rad, 2) < Math.Pow(side, 2))
            {
                shape = "circle";
            }
            else
            {
                shape = "the areas are the same";
            }
        }
        return shape;
    }
    public static int factorial()
    {
        string? input = Console.ReadLine(); 
        int _arg;
        bool check = int.TryParse(input, out _arg);
        if (check)
        {
            if (_arg == 0)
            {
                return 1;
            }
            else
            {
                int _i = 1; 
                int _result = 1;
                while(_i <= _arg)
                {
                    _result *= _i; 
                    _i++;
                }
                return _result;
            }
        }
        else
        {
            Console.WriteLine("alo, neverniy format chisla, ono doljno bit' int");
            return 0;
        }        
    }
    public static int[] bubbleSort(int[] arr)
    {
        for (int _i = 0; _i < arr.Length - 1; _i++)
        {
            for (int _j = 0; _j < arr.Length - 1; _j++)
            {
                if (arr[_j] >= arr[_j + 1])
                {
                    int q;
                    q = arr[_j];
                    arr[_j] = arr[_j + 1];
                    arr[_j + 1] = q;
                }
            }
        }
        for (int _i = 0; _i < arr.Length; _i++)
        {
            Console.WriteLine(arr[_i]);
        }
        return arr;
    }
    public static string substring(string str, int startIndex, int substrinLength)
    {
         string _substring = "";
         for (int _i = startIndex; _i < startIndex + substrinLength; _i++)
         {
            _substring += str[_i];
         }
         return _substring;
    }
    public static int BSA(int[] arr, int valueForSearch)
    {
        int right = arr.Length, left = 0, mid = (right + left) / 2;
               
        while(arr[mid]!= valueForSearch)
        {
            if (arr[mid] < valueForSearch)
            {
                left = mid;
                mid = (right + left) / 2;
            }
            else
            {
                right= mid;
                mid = (right + left) / 2;                
            }
        }
        return mid;
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
        Tasks.task7();
        Console.WriteLine(Tasks.task8(2, 5));
        Console.WriteLine(Tasks.factorial());
        int[] arr = new int[6] {1, 5, 6, 7, 1, 8};       
        arr = Tasks.bubbleSort(arr);
        string str = "cool sample";
        Console.WriteLine(Tasks.substring(str, 2, 4));
        int[] arr1 = new int[7] {1, 2, 3, 4, 5, 6, 7};  
        Console.WriteLine(Tasks.BSA(arr1, 4));
    }
}
