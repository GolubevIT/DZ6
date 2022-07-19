/* Напишите программу, которая найдёт точку пересечения двух прямых, 
   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
   значения b1, k1, b2 и k2 задаются пользователем.*/

void GetIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if ((k1 -k2)==0)
    {
        if (b1==b2){
            Console.WriteLine("Прямые совпадают.");
        }
        else{
            Console.WriteLine("Решения не существует.");
        }
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения: ({x};{y})");
    }
}

Console.Clear();
Console.Write("Введите значение b1...");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1...");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2...");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2...");
double k2 = Convert.ToDouble(Console.ReadLine());
GetIntersectionPoint(b1, k1, b2, k2);
