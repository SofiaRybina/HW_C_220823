// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double CalculateX(double k1, double b1, double k2, double b2)
{
    double X = (b2 - b1) / (k1 - k2);
    return X;
}

double CalculateY(double k1, double b1, double x)
{
    double Y = k1 * x + b1;
    return Y;
}

Console.WriteLine("Введите k1:");
Console.Write("-> ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b1:");
Console.Write("-> ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2:");
Console.Write("-> ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2:");
Console.Write("-> ");
int b2 = Convert.ToInt32(Console.ReadLine());

double rezX = CalculateX(k1, b1, k2, b2);
double rezY = CalculateY(k1, b1, rezX);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({rezX}; {rezY})");