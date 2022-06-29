// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double prompt (string message)
{
    Console.Write(message);
    double number = double.Parse(Console.ReadLine());
    return number;    
}

double [] FindTheIntersection (double k1, double b1, double k2, double b2)
{
    if (k1==k2)
    {
        double [] except = new double [1];
        if (b1==b2)
        {
            except[0]=1;
            return except;
        }
        else
        {
            return except;
        }
    }
    double [] answer = new double [2];
    answer [0] = (b2-b1)/(k1-k2);
    answer [1] = k1*answer[0] + b1;
    return answer;
}
void ResultInterpretator (double [] result, double k1, double b1, double k2, double b2)
{
    if (result.Length==1)
    {
        if (result[0]==0) Console.WriteLine ("Линии не пересекаются");
        else {Console.WriteLine ("Линии одинаковы");}
    }
    else
    {
        Console.WriteLine($"Точка пересечения линий y={k1}x+{b1} and y={k2}x+{b2}");
    }
}

double k1 = prompt ("Определяем коэффициент k1 в y=k1*x+b1 для первой линии: ");
double b1 = prompt ("Определяем коэффициент b1 в y=k1*x+b1 для первой линии: ");
double k2 = prompt ("Определяем коэффициент k2 в y=k2*x+b2 для первой линии: ");
double k2 = prompt ("Определяем коэффициент b2 в y=k2*x+b2 для первой линии: ");
ResultInterpretator(FindTheIntersection(k1,b1,k2,b2),k1,b1,k2,b2);

