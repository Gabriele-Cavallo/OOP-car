class Vehicle : IVehicle
{
    public required string Model { get; set; }
    public required string Brand { get; set; }
    public string? Version { get; set; }
    public int Speed {get; set;}
    public void Accelerate(int amount)
    {
        Speed += amount;
    }

    public void Brake()
    {
        Console.WriteLine("I'm braking");
    }

    public void Start()
    {
        Console.WriteLine("I'm starting");
    }
    public string VehicleToString(){
        return $"From vehicle {Brand},{Model},{Version ?? ""}";
    }
}