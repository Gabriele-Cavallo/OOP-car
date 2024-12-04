abstract class Vehicle : IVehicle
{
    public required string Model { get; set; }
    public required string Brand { get; set; }
    public abstract string? Version { get; set; }
    public int Speed {get; set;}
    protected int minimunSpeed = 5;
    public void Accelerate(int amount)
    {
        Speed += amount;
    }

    public void Brake()
    {
        Console.WriteLine("I'm braking");
    }

    public virtual void Start()
    {
        Console.WriteLine("I'm starting");
    }
    public string VehicleToString(){
        return $"From vehicle {Brand},{Model},{Version ?? ""}";
    }

    public abstract void Drive();

    public int GetMinSpeed(){
        return minimunSpeed;
    }
    
}