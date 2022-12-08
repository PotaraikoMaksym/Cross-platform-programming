using System;
using System.Reflection.Metadata;


/* Варіант 8 */

/* Периметр прямокутного трикутника за двома катетами */

/*
double perimeterRightTriangle() {

    Console.Write("cat 1 = ");
    float cat1 = float.Parse(Console.ReadLine());

    Console.Write("cat 2 = ");
    float cat2 = float.Parse(Console.ReadLine());

    double perimeter = Math.Sqrt(cat1 * cat1 + cat2 * cat2) + cat1 + cat2;

    Console.WriteLine("perimeter = " + perimeter);

    return perimeter;

}

perimeterRightTriangle();
*/



/* Чи однакові цифри даного двозначного числа */

/*
bool twoDigitNumber()
{
    Console.Write("number = ");
    string number = Console.ReadLine();

    if (number[0] == number[1]) 
        Console.WriteLine("true");
        return true;
    else 
        Console.WriteLine("false");
        return false;
}

twoDigitNumber();
*/



/* Чи лежить точка всередині заштрихованої області */

/*
void poitInfigure()
{
    Console.Write("x=");
    float x = float.Parse(Console.ReadLine());
    Console.Write("y=");
    float y = float.Parse(Console.ReadLine());

    if (x * x + y * y < 25 * 25 && y > -Math.Abs(x))
        Console.WriteLine("Yes");
    else if (x * x + y * y > 25 * 25 || y < -Math.Abs(x))
        Console.WriteLine("No");
    else Console.WriteLine("On the edge");

}
poitInfigure();
*/



/* З деякою дати по теперішній день пройшло m місяців, визначити назву місяця невідомої дати */

/*
int dateMinusMonth()
{
    Console.Write("m = ");
    int m = int.Parse(Console.ReadLine());
    DateTime dateTime = DateTime.Now;
    int dateMonth = dateTime.Month;

    dateMonth -= m;

    if (dateMonth < 0)
    {
        dateMonth += 12;
    }

    DateTime newDateTime = new DateTime(dateMonth);

    string result = dateMonth.ToString("MMMM");
    Console.WriteLine(result);
    return dateMonth;
}

dateMinusMonth();
*/



/* Реалізувати функцію обчислення частки двох дійсних чисел */

/*
int division()
{
    Console.Write("x = ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("y = ");
    int y = int.Parse(Console.ReadLine());

    Console.WriteLine(x / y);
    return x / y;
}

division();
*/



/* За введеними з клавіатури значеннями обчислити та вивести на екран значення виразу */

/*
float equation()
{
    Console.Write("a = ");
    float a = float.Parse(Console.ReadLine());
    Console.Write("b = ");
    float b = float.Parse(Console.ReadLine());

    Console.WriteLine((a / (a * a + 1)) + (b / (b * b + 1)));
    return (a / (a*a + 1)) + (b / (b*b + 1));
}

equation();
*/