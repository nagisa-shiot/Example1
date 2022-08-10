Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
        Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
}
if (num_B> num_A)
{
        Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
}
if  (num_A==num_B)
{
     Console.WriteLine( "Число"+ num_B + "равно" + num_A );
}