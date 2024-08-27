namespace AbstractClassesDemoCSharp_50;

public class Snake : Animal
{
    public override void Move()
    {
        Console.WriteLine("Snake slithers!");
    }

    public override void Breathe()
    {
        Console.WriteLine("Snake is breathing..");
    }
}