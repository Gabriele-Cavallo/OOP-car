namespace OOP_car.Models;
class AutonomousCar : Vehicle, ISelfDrivable
{
    public override string? Version { get; set; } = "IGloo";
    public int MaxDistance { get; set; } = 300;

    public void AutoStart()
    {
        Console.WriteLine("Auto Starting");
    }

    public override void Drive()
    {
        Console.WriteLine("Minimun speed, " + base.GetMinSpeed());
        Console.WriteLine("Self Driving");
    }
}