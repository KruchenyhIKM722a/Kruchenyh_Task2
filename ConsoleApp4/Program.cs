using System;

class Restaurant
{
    private string name;
    private string address;
    private int capacity;
    private bool isOpen;

    public Restaurant(string name, string address, int capacity)
    {
        this.name = name;
        this.address = address;
        this.capacity = capacity;
        this.isOpen = false;
    }

    public void Open()
    {
        isOpen = true;
        Console.WriteLine("Ресторан {0} вiдкрито.", name);
    }

    public void Close()
    {
        isOpen = false;
        Console.WriteLine("Ресторан {0} закрито.", name);
    }

    public bool IsOpen()
    {
        return isOpen;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Назва: {0}", name);
        Console.WriteLine("Адреса: {0}", address);
        Console.WriteLine("Мiсткiсть: {0} осiб", capacity);
        Console.WriteLine("Стан: {0}", isOpen ? "Вiдкритий" : "Закритий");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Restaurant myRestaurant = new Restaurant("У Петра", "вул. Степана Бандери, 91", 50);
        myRestaurant.DisplayInfo();
        myRestaurant.Open();
        myRestaurant.DisplayInfo();
        myRestaurant.Close();
        myRestaurant.DisplayInfo();
    }
}