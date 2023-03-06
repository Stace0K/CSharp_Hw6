// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Number(string text)
{
    Console.Write(text);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double b1 = Number("Введите координату b1: ");
double k1 = Number("Введите координату k1: ");
double b2 = Number("Введите координату b2: ");
double k2 = Number("Введите координату k2: ");

double resX = (b2 - b1)/(k1 - k2);
double resY = k2 * resX + b2;
Console.WriteLine($"Пересечение двух прямых произойдет в точке с координатами x = {Math.Round(resX, 3)}; y = {Math.Round(resY, 3)}");