namespace Chapter4_4._2;

public abstract class Transport
{
    protected int power;
    protected double cost;
    protected string number;
    protected string brand;


    protected Transport
        (int power, double cost, string number, string brand)
    {
        this.power = power;
        this.cost = cost;
        this.number = number;
        this.brand = brand;
    }

    public int Power
    {
        get => power;
        set {
            if (value <= 0)
            {
                Console.WriteLine("Мощность должна быть положительной");
            }
            else
            {
                power = value;
            }
        }
    }

    public double Cost
    {
        get
        {
            return cost;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Стоимость должна быть больше 0");
            }
            else
            {
                cost = value;
            }
        }
    }

    
    public string Number
    {
        get { return number; }
        set
        {
            
            string temp = value.Trim();
            temp.ToUpper();
            string[] subs = temp.Split(' ');
            string end = "";
            foreach (var sub in subs)
            {
                end += sub;
            }
            number = end;
        }
    }

    public string Brand
        {
           get { return brand; }
           set
           {
               string firstLetter;
               string lastSub;
               lastSub = value.ToLower().Substring(1);
               firstLetter = value[0].ToString().ToUpper();
               string temp = firstLetter + lastSub;
               brand = temp.Trim();
           }
        }


    public virtual double Tax(int percent)
    {
        double tax = cost * percent / 100;
        return tax;
    }

    public virtual void ShowInfo()
    {
        Console.Write($"Мощность: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(power);
        Console.ResetColor();
        Console.WriteLine(" л.с.");
        Console.Write($"Стоимость: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(cost);
        Console.ResetColor();
        Console.WriteLine(" руб.");
        Console.Write($"Мощность: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(number);
        Console.ResetColor();
        Console.Write($"Марка: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(brand);
        Console.ResetColor();
    }
}