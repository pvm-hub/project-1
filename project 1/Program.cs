try
{
    Console.WriteLine("старт");
    Console.WriteLine("введите x");
    double x = double.Parse(Console.ReadLine());
    double res = (x - (x * x * x) / 3 + (x * x * x * x *x) / 5);
    Console.WriteLine(res);
    Console.WriteLine("конец");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
