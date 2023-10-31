// armin liryaee
// fibonacci number
// tamrin 4
char y = ' ';
long n = 0;

long b = 1;
do
{
Console.WriteLine("enter N number:");

long N = Convert.ToInt64(Console.ReadLine());

        for (long c = 0 ; c < N ; c++)
        {
            long q = c + b;

        Console.WriteLine(y);

        Console.WriteLine(q);

            n = b;

            b = q;
        }
  
    Console.WriteLine("do you want to continue?");

} while (Console.ReadLine() == "y");
