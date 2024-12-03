namespace OOPCar.Models;
class Car
{
    private string make = "";
    public string Make
    {
        get
        {
            return make;
        }
        set
        {
            make = value.ToUpper();
        }
    }
    public string Model{get ; init;} = "";
    public int MyProperty {get; set;}
    public int Year{get ;}
    public const int StandardWheelCount = 4;
    public const double StandardTankCapacityLiters = 50.0;
    public const double StandardMaxSpeedKmH = 180.0;
    public readonly string VehicleType = "Car";
    public static List<string> SupportedBrands{get;} = new() {"Toyota", "Ford", "BMW", "Audi", "Fiat"};

    public static int TotalCarsProduced{get; private set;}

    public int Speed { get; private set; }

    public Car()
    {
        make = "Unknown";
        Model = "Unknown";
        Year = 2020;
        VehicleType = "Car";
        TotalCarsProduced++;
    }

    public Car(string mk, string mdl, int yr = 2020, string vehicleType = "Car")
    {
        make = mk;
        Model = mdl;
        Year = yr;
        VehicleType = vehicleType;
        TotalCarsProduced++;
    }
    // public Car(string make, string model){
    //     Make = make;
    //     Model = model;
    //     Year = 2020;
    // }
    public Car(string make, string model) : this(make, model, 2020)
    {

    }
    public void Start()
    {
        Console.WriteLine($"Starting {make} {Model} {Year} {StandardWheelCount}");
    }
    public override string ToString()
    {
        return $"Starting {make} {Model} {Year} {VehicleType}";
    }

    public void Accelerate(int amount){
        Speed += amount; 
    }

    public static List<string> GetSupportedBrandList() {
        return SupportedBrands;
    }
    public static string GetSupportedBrandListString() {
        return string.Join(", ", SupportedBrands);
    }
}

