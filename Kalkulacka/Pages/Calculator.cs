public class Calculator
{
    public double AktualniVysledek = 0;

    public void Secti(double b)
    {
        AktualniVysledek += b;
    }

    public void Odecti(double b)
    {
        AktualniVysledek -= b;
    }

    public void Nasob(double b)
    {
        AktualniVysledek *= b;
    }

    public void Vydel(double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        AktualniVysledek /= b;
    }

    public void Umocni(double b)
    {
        AktualniVysledek = Math.Pow(AktualniVysledek, b);
    }

    public double VratAktualniVysledek()
    {
        return AktualniVysledek;
    }

    public void NastavAktualniVysledek(double novyVysledek)
    {
        AktualniVysledek = novyVysledek;
    }
}