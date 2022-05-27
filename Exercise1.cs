using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Schema;

///Exercise 1.1
static void Multiplication()
{
    Console.Write("Exercise 1.1\n");

    for (int i = 1; i <= 10; i++)
    {
        Console.Write(i + "\t");
        for (int j = 2; j <= 10; j++)
        {
            Console.Write(i * j + "\t");
            
        }
        Console.Write("\n");
    }
}
/// Exercise 1.2
static void MultiplicationOdd()
{
    Console.Write("Exercise 1.2\n");

    for (int i = 1; i <= 10; i++)
    {
        Console.Write(i + "\t");
        for (int j = 2; j <= 10; j++)
        {
            int result = i * j;
            if (result %2 != 0)
            {
                Console.Write(result + "\t");
            }
            else
            {
                Console.Write(0 + "\t");
            }
            
            
        }
        Console.Write("\n");
    }
}


static int AskUserForParameter()
{
    Console.WriteLine("Please write a number and press enter :");
    int.TryParse(Console.ReadLine(), out var result);
    return result;
}
///Exercise1.3
static void MultiplicationWithParameter()
{
    Console.Write("Exercise 1.3\n");
    int number = AskUserForParameter();
    for (int i = 0; i <= number; i++)
    {
        {
            Console.Write(i * number);
        }
        Console.Write("\n");
    }
}

///Exercise2.1
static void Prime()
{
    bool isPrime(int number)
    {
        if (number==1||number==0)
        {
            return false;
        }
        for (int i=2;i<number;i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    for (int i=1;i<=1000;i++)
    {
        if (isPrime(i))
        {
            Console.Write(i+" ");
        }
    }
}

///Exercise2.2

int fib(int n)
{
    if (n <= 1)
        return n;
    return fib(n-1) + fib(n-2);
}

///Exercise2.3

int factorial(long n)
{
    if (n == 0) return 1;
    return (int)(n * factorial(n - 1));
}
///If we try to calculate factorial of 420.000 the execution contains too many function call
/// so we have a stackoverflow error
/// A recursive function is a function that calls itself until the stop condition (here it's n==0).

///Exercise3

static int PowerFunction(int x)
{
    if ( -3 <= x && x <= 3  ) 
    {
        if (((Math.Pow(x, 2) - 4)) == 0)
        {
            throw new DivideByZeroException();
        }
        return (int) (10/((Math.Pow(x, 2) - 4)));
    }
    else
    {
        return (int)(Math.Pow(x, 2) - 4);
    }
}

for (int i = -4; i <= 6; i++)
{
    try
    {
        Console.WriteLine(PowerFunction(i));
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine(e.Message);
    }
}
///Exercice4
static void Square()
{
    int x = 0;
    int y = 0;
    do
    {
        Console.Write("Enter the dimension please as 'x y' : ");
        string[] tokens = Console.ReadLine().Split();
        x = int.Parse(tokens[0]);
        y = int.Parse(tokens[1]);
    } while ((x < 1 || x > 1000) || (y < 1 || y > 1000));
    int starscounter = 1;
    x = x - 1;
    y = y - 1;
    
    for (int i = 0; i <= x; i++)
    {
        for (int j = 0; j <= y; j++)
        {
            if (i == 0)
            {
                if (j == 0)
                {
                    Console.Write("0");
                }else if (j == y)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("-");
                }
            }
            if (i == x)
            {
                if (j == 0)
                {
                    Console.Write("0");
                }
                else if (j == y)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("-");
                }
            }

            if ((j == 0) && (i!=x))
            {
                if (( i != 0) && (i != x))
                {
                    Console.Write("|");
                }
            }
            if ((j == y) && (i != x))
            {
                
                if ( i != 0)
                {
                    Console.Write("|");
                }
            }
            
            if (( i != 0 )&&(i!=x))
                if ((j != 0) && (j != y))
                {
                    Console.Write(" ");

                }

        }
        Console.WriteLine();
    }
    
}
Square();


///Exercise5

static void ChristmasTree()
{
    Console.Write("Do you want a decorated tree or not ? \n 1 - Yes \n 2 - No");
    int choice = int.Parse(Console.ReadLine());
    if (choice == 2)
    {
        int n = 0;
        do
        {
            Console.Write("Enter the size of the tree : ");
            n = int.Parse(Console.ReadLine());
        } while (n < 3 || n > 20);

        int spaces = n;
        int stars = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < stars; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
            stars++;
            spaces--;
        }

        for (int i = 0; i <= (n); i++)
        {
            if (i == (n - 1))
            {
                Console.Write("| |");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }else if (choice == 1)
    {
        int n = 0;
        do
        {
            Console.Write("Enter the size of the tree : ");
            n = int.Parse(Console.ReadLine());
        } while (n < 3 || n > 20);

        string barre = "i ";
        int barrecounter = 0;
        string rond = "o ";
        int rondcounter = 1; 
        int spaces = n;
        int stars = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");   
            }
            for (int j = 0; j < stars; j++)
            {
                barrecounter += 1;
                rondcounter += 1;
                if ((barrecounter % 3 == 0)&&(i!= 0))
                {
                    Console.Write(barre);
                }
                else if ((rondcounter % 5 == 0) && (i != 0))
                {
                    Console.Write(rond);
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
            stars++;
            spaces--;
        }

        for (int i = 0; i <= (n); i++)
        {
            if (i == (n-1))
            {
                Console.Write("| |");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
}  
