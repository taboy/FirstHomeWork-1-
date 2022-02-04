//Задача 4: Найти максимальное из трёх чисел.
Console.WriteLine ("Write first number");
int first_num = Convert.ToInt16(Console.ReadLine());
Console.WriteLine ("Write second number");
int second_num = Convert.ToInt16(Console.ReadLine());
Console.WriteLine ("Write third number");
int third_num = Convert.ToInt16(Console.ReadLine());
if(first_num > second_num && first_num > third_num)
{
    Console.WriteLine(first_num + " is a highest number");
}
else if ( second_num > first_num && second_num > third_num)
{
    Console.WriteLine(second_num + " is a highest number");

}
else if ( third_num > first_num && third_num > second_num)
{
    Console.WriteLine(third_num + " is a highest number");

}
