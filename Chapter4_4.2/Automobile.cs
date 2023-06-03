using System.Diagnostics;

namespace Chapter4_4._2;

public class Automobile : Transport
{
    protected int mileage;
    protected bool isInspected;
    
    public Automobile
        (int power, double cost, string number, string brand,
            int mileage, bool isInspected) : base(power, cost, number, brand)
    {
        this.mileage = mileage;
        this.isInspected = isInspected;
    }

    public int Mileage
    {
        get { return mileage; }
        set{
            if (value < 0)
            {
                Console.WriteLine("Пробег не может быть отрицательным");
            }
            else
            {
                mileage = value;
            }
        }
    }

    public string IsInspected
    {
        get
        {
            if (isInspected == true)
            {
                return "ТО пройден";
            }
            else
            {
                return "ТО не пройден";
            }
        }
    }


    public override double Tax(int percent = 5)
    {
        double tax = cost * percent / 100;
        return tax;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.Write($"Пробег: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(mileage);
        Console.ResetColor();
        Console.WriteLine(" км");
        Console.Write($"Пройден ли техосмотр: ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(isInspected);
        Console.WriteLine();
    }

    public void ShowMileage()
    {
        Console.Write($"Пробег: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(mileage);
        Console.ResetColor();
        Console.WriteLine(" км");
        Console.WriteLine();
    }

    public void ShowCost()
    {
        Console.Write($"Стоимость: ");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write(cost);
        Console.ResetColor();
        Console.WriteLine(" руб");
        Console.WriteLine();
    }
}