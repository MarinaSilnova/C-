// задача 1

Console.WriteLine ("input first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("input second number");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine("Ответ на задачу 1 - max = " + Convert.ToInt32(a));
}
else
{
    Console.WriteLine("Ответ на задачу 1 - max = " + Convert.ToInt32(b));
}