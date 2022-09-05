// задача 2
Console.WriteLine ("input first number");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("input second number");
int secondnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("input third number");
int thirdnumber = Convert.ToInt32(Console.ReadLine());
int max = firstnumber;
if(max < secondnumber)
{
    max = secondnumber;
}
if(max < thirdnumber)
{
    max = thirdnumber;  
}
Console.WriteLine("Ответ на задачу 2 max = " + Convert.ToInt32(max));