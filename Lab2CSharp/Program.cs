using System.Data;
using System.Globalization;
using static System.Console;

static void Task1()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int[] a = new int[n];

    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        a[i] = rand.Next(-9, 9);
    }

    int sum = 0;

    for (int i = 0; i < n; i++)
    {
        sum += a[i];
        Write($"[{a[i]}]");
    }
    WriteLine($"Sum: {sum}");

    string twoDigit = sum.ToString().TrimStart('-');

    if(twoDigit.Length == 2)
    {
        WriteLine("Sum is two-digit number.");
    }
    else if(twoDigit.Length < 2)
    {
        WriteLine("Sum is not two-digit number.");
    }
    else
    {
        WriteLine("Sum is multi-digit number.");
    }
}

static void Task2()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int[] a = new int[n];

    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        a[i] = rand.Next(-9, 9);
    }

    int count = 0;

    for (int i = 0; i < a.Length-1; i++)
    {
        if(a[i] > a[i + 1])
        {
            count++;
        }
    } 
    for (int i = 0; i < a.Length; i++) 
        Write($"[{a[i]}]");

    WriteLine($"\nCount a[i] > a[i + 1]: {count}");
    
}

static void Task3()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int [,] matrix = new int [n,n];

    Random rand = new Random();

    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = rand.Next(-9, 9);
        }
    }

    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Write($"[{matrix[i,j]}]");
        }
        WriteLine();
    }

    double sum = 0;
    int count = 0;

    for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j < n - 1 && matrix[i, j] != 0)
                {
                    sum += matrix[i, j];
                    count++;
                }
            }
        }
    if (count > 0)
    {
        double average = sum / count;
        WriteLine($"Arithmetic mean of nonzero elements above the side diagonal: {average}");
    }
    else
    {
        WriteLine("There are no non-zero elements above the side diagonal.");
    }
}

static void Task4()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int[][] c = new int[n][];

    Random rand = new Random();

    for(int i = 0; i < n; i++)
    {
        c[i] = new int[rand.Next(1, 9)];
    }

    for (int i = 0; i < c.Length; i++)
    {
        for (int j = 0; j < c[i].Length; j++)
        {
            c[i][j] = rand.Next(-9, 9);
        }
    }

    for (int i = 0; i < c.Length; i++)
    {
        for (int j = 0; j < c[i].Length; j++)
        {
            Write($"[{c[i][j]}]");
        }
        WriteLine();
    }

    int count = 0;

    for (int i = 0; i < c.Length; i++)
    {
        for (int j = 0; j < c[i].Length; j++)
        {
            if (c[i][j] < 0)
            {
                count++;
                break;
            }
        }
    }
    
    int[] negative = new int[count];
    int s = 0;
    
    for (int j = 0; j < n; j++) 
    {
        for (int i = 0; i < n; i++) 
        {
            if (j < c[i].Length && c[i][j] < 0)
            {
                negative[s] += c[i][j];
            }
        }
        s++;
    }


    WriteLine("Sum negative:");
    for (int j = 0; j < count; j++)
    {
        Write($"[{negative[j]}]");
    }
}

Task4();


