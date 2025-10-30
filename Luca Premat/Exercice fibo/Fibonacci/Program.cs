using System.Reflection;
using System.Security.Cryptography.X509Certificates;

static int Fibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;

    n = Fibonacci(n - 1) + Fibonacci(n - 2);
    return n;
}
//Console.WriteLine(Fibonacci(13));

static void main(int x)
{
    while (x > 0)
    {  
        x = x - 1;
        Console.WriteLine(Fibonacci(x));
    }
}
main(13);


// ordre croissant
static void main2(int x)
{
    int y = -1;
    while (y < x - 1)
    {
        y = y + 1;
        Console.WriteLine(Fibonacci(y));
    }
}
//main2(13);