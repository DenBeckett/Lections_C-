int n = Convert.ToInt32(Console.ReadLine());

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i <= n + 1; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}