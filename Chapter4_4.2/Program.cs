using Chapter4_4._2;

class Program
{

    public static void Main(string[] args)
    {
        List<Automobile> automobiles = new List<Automobile>();
        
        Automobile civicTypeR = new Automobile(300, 3000000, 
            "Н183РТ", "Honda", 30000, true);
        automobiles.Add(civicTypeR);
        
        Automobile stelvioQuadrifoglio = new Automobile(510, 4690000,
            "H531ТС", "Alfa Romeo", 31000, true);
        automobiles.Add(stelvioQuadrifoglio);
        
        Automobile focus = new Automobile(125, 400000,
            "М690ОА", "Ford", 318000, false);
        automobiles.Add(focus);


        List<Plane> planes = new List<Plane>();
        
        Plane c172 = new Plane(180, 23651019, 
            "N937DR", "Cessna", 4300);
        planes.Add(c172);
        
        Plane ght = new Plane(270, 34689100,
            "T683UG", "Bombardier", 5890);
        planes.Add(ght);
        
        Plane abc = new Plane(690, 89056784,
            "M987OV", "Embraer", 7800);
        planes.Add(abc);
        
        
        double sumOfTaxes = 0;
        foreach (var auto in automobiles)
        {
            sumOfTaxes += auto.Tax();
        }
        
        Console.WriteLine($"Налог с регистрации всех машин: {sumOfTaxes} руб.");
        Console.WriteLine();
        
        
        var sortedAutos = automobiles.OrderBy(auto => auto.Cost).ToList();
        var mostExpensiveCar = sortedAutos[0];
        Console.WriteLine(mostExpensiveCar.IsInspected);


        Automobile bcd = new Automobile(650, 4, "Н678РН", "Brand", 50000, true);
        bcd.Brand = "oPel";
        Console.WriteLine(abc.Brand);
        bcd.Number = "Н 789 РО";
        Console.WriteLine(abc.Number);
        bcd.Cost = 5;
        Console.WriteLine(bcd.Cost);
        
        automobiles[0].ShowInfo();

        var sortedPlanes = planes.OrderBy(plane => plane.Cost).ToList();
        var mostExpensivePlane = sortedPlanes[0];
        Console.WriteLine(mostExpensivePlane.Power);
        Console.WriteLine(mostExpensivePlane.Cost);
        Console.WriteLine(mostExpensivePlane.Brand);

        foreach (var automobile in automobiles)
        {
            automobile.ShowInfo();
        }

        foreach (var plane in planes)
        {
            plane.ShowInfo();
        }
    }
}