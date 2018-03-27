using System;

public class Vegetable
{
    public Vegetable(string name) => Name = name;

   public string Name { get; }

    public override string ToString() => Name;
}

public class Example
{
    public enum Unit { item, pound, ounce, dozen };

    public static void Main()
    {
        var item = new Vegetable("eggplant");
        var date = DateTime.Now;
        var price = 1.99m;
        var unit = Unit.item;
        Console.WriteLine($"On {date}, the price of {item} was {price} per {unit}.");
    }
}
