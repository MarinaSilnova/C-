// решение задачи 4

Console.Write ("Input number ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    if(i % 2 == 0)
    {
        Console.Write(i+ " ");
    }
    i++;
}
