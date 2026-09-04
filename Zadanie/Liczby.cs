using System.Collections.Generic;
using System.Linq;

class Liczby
{
    private List<double> liczby = new List<double>();

    public void Dodaj(double liczba)
    {
        liczby.Add(liczba);
    }

    public double Maksimum()
    { 
        return liczby.Max(); 
    }

    public double Minimum()
    {
        return liczby.Min();
    }

    public double Suma()
    {
        return liczby.Sum();
    }

    public double Srednia ()
    {
        return liczby.Average();
    }

    public int Ilosc()
    {
        return liczby.Count;
    }
}