namespace Chapter4_4._2;

public class Plane : Transport
{
    protected int maxAltitude;

    public Plane
        (int power, double cost, string number, string brand, 
            int maxAltitude) : base(power, cost, number, brand)
    {
        this.maxAltitude = maxAltitude;
    }

    public int MaxAltitude
    {
        get { return maxAltitude; }
        set
        {
            if (value <= 1000)
            {
                Console.WriteLine("Максимальная высота полета не может быть такой низкой");
            }
            else
            {
                maxAltitude = value;
            }
        }
    }

    public override double Tax(int percent = 3)
    {
        double tax = cost * percent / 100;
        return tax;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.Write($"Максимальная высота полета: ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(maxAltitude);
        Console.ResetColor();
        Console.WriteLine(" м");
    }
}