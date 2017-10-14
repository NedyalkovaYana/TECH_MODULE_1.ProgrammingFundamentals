using System;
using System.Collections.Generic;
using System.Linq;


class MainClass
{
    public static void Main()
    {
        var arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        string commandLine = Console.ReadLine();

        while (!commandLine.ToLower().Equals("end"))
        {
            var args = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];
            string commandExt = "";

            switch (command)
            {
                case "exchange":
                    Exchange(arr, args);
                    break;
                case "max":
                    commandExt = args[1];
                    switch (commandExt)
                    {
                        case "odd": MaxOdd(arr); break;
                        case "even": MaxEven(arr); break;
                        default:
                            break;
                    }
                    break;
                case "min":
                    commandExt = args[1];
                    switch (commandExt)
                    {
                        case "odd": MinOdd(arr); break;
                        case "even": MinEven(arr); break;
                        default:
                            break;
                    }
                    break;
                case "first":
                    commandExt = args[2];
                    switch (commandExt)
                    {
                        case "odd": FirstOdd(arr, args); break;
                        case "even": FirstEven(arr, args); break;
                        default:
                            break;
                    }
                    break;
                case "last":
                    commandExt = args[2];
                    switch (commandExt)
                    {
                        case "odd": LastOdd(arr, args); break;
                        case "even": LastEven(arr, args); break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            commandLine = Console.ReadLine();
        }

        Console.WriteLine("[" + string.Join(", ", arr) + "]");
    }

    static void LastEven(List<int> arr, string[] args)
    {
        if (!arr.Any(x => x % 2 == 0))
        {
            Console.WriteLine("[]");
            return;
        }

        int count = int.Parse(args[1]);
        if (count < 0 || count > arr.Count)
        {
            Console.WriteLine("Invalid count");
            return;
        }
        var lastEvenElements = arr.Where(x => x % 2 == 0).Reverse().Take(count).Reverse().ToList();
        Console.WriteLine("[" + string.Join(", ", lastEvenElements) + "]");
    }

    static void LastOdd(List<int> arr, string[] args)
    {
        if (!arr.Any(x => x % 2 == 1))
        {
            Console.WriteLine("[]");
            return;
        }

        int count = int.Parse(args[1]);
        if (count < 0 || count > arr.Count)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        var lastOddElements = arr.Where(x => x % 2 == 1).Reverse().Take(count).Reverse().ToList();
        Console.WriteLine("[" + string.Join(", ", lastOddElements) + "]");
    }

    static void FirstEven(List<int> arr, string[] args)
    {
        if (!arr.Any(x => x % 2 == 0))
        {
            Console.WriteLine("[]");
            return;
        }

        int count = int.Parse(args[1]);
        if (count < 0 || count > arr.Count)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        var firstEvenElements = arr.Where(x => x % 2 == 0).Take(count).ToList();
        Console.WriteLine("[" + string.Join(", ", firstEvenElements) + "]");
    }

    static void FirstOdd(List<int> arr, string[] args)
    {
        int count = int.Parse(args[1]);
        if (count < 0 || count > arr.Count)
        {
            Console.WriteLine("Invalid count");
            return;
        }
        if (!arr.Any(x => x % 2 == 1))
        {
            Console.WriteLine("[]");
            return;
        }

        
       

        var firstOddElements = arr.Where(x => x % 2 == 1).Take(count).ToList();
        Console.WriteLine("[" + string.Join(", ", firstOddElements) + "]");
    }

    static void MinEven(List<int> arr)
    {
        if (!arr.Any(x => x % 2 == 0))
        {
            Console.WriteLine("No matches");
            return;
        }

        int minEvenIndex = arr.LastIndexOf(arr.Where(x => x % 2 == 0).Min());

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] % 2 == 0 && arr[i] <= arr[minEvenIndex])
                minEvenIndex = i;
        }

        Console.WriteLine(minEvenIndex);
    }

    static void MaxEven(List<int> arr)
    {
        if (!arr.Any(x => x % 2 == 0))
        {
            Console.WriteLine("No matches");
            return;
        }

        int maxEvenIndex = arr.LastIndexOf(arr.Where(x => x % 2 == 0).Max());

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] % 2 == 0 && arr[i] >= arr[maxEvenIndex])
                maxEvenIndex = i;
        }

        Console.WriteLine(maxEvenIndex);
    }

    static void MaxOdd(List<int> arr)
    {
        if (!arr.Any(x => x % 2 == 1))
        {
            Console.WriteLine("No matches");
            return;
        }

        int maxOddIndex = arr.LastIndexOf(arr.Where(x => x % 2 == 1).Max());
        Console.WriteLine(maxOddIndex);
    }

    static void MinOdd(List<int> arr)
    {
        if (!arr.Any(x => x % 2 == 1))
        {
            Console.WriteLine("No matches");
            return;
        }

        int minOddIndex = arr.LastIndexOf(arr.Where(x => x % 2 == 1).Min());
        Console.WriteLine(minOddIndex);
    }

    static void Exchange(List<int> arr, string[] args)
    {
        int splitIndex = int.Parse(args[1]);
        if (splitIndex < 0 || splitIndex >= arr.Count)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        var newList = new List<int>();
        newList.AddRange(arr.Take(splitIndex + 1));
        arr.RemoveRange(0, splitIndex + 1);
        arr.AddRange(newList);
    }
}
