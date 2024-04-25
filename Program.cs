internal class Program
{
    private static void Main(string[] args)
    {
        Wood wood = new Wood();
        wood.Efect();
        Iron iron = new Iron();
        iron.Efect();
        Grass grass= new Grass();   
        grass.Efect();
    }
}

public interface IDamager
{
    void Efect();
}

public interface Isource
{
    void Efect();
}
public class Wood : IDamager
{
    public void Efect()
    {
        Console.WriteLine("duc lo khi dan ban");

    }
}
public class Iron : IDamager
{
    public void Efect()
    {
        Console.WriteLine("toe lua khi dan ban");

    }
}
public class Grass : IDamager
{
    public void Efect()
    {
        Console.WriteLine("tao bun dat khi dan ban");

    }
}
 public class Water : IDamager, Isource
 {
    void Isource.Efect()
    {
        
    }
    void IDamager.Efect()
    {

    }
 }