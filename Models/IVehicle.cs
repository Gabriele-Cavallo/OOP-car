interface IVehicle
{
    public const int StandardWheelCount = 4;
    public const double StandardTankCapacityLiters = 50.0;
    public const double StandardMaxSpeedKmH = 180.0;
    void Start();
    void Accelerate(int amount);
    void Brake();
    string VehicleToString(){
        return $"From interface {Brand},{Model},{Version ?? ""}";
    }
    public string Model{get; set;}
    public string Brand{get; set;}
    public string? Version{get; set;}
    static string ReleaseNumber(){
        return "1.2.3";
    }
}