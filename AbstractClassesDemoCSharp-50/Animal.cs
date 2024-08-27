namespace AbstractClassesDemoCSharp_50;

public abstract class Animal
{
    public int Age { get; set; }
    public string Diet { get; set; }
    
    //Abstract methods (stubbed out methods)
    public abstract void Move();
    
    //Virtual methods (non stubbed out method)
    public virtual void Breathe()
    {
        Console.WriteLine("Animal is breathing..");
    }
}