namespace OOPCar;
using Models;

class Program
{
    static void Main()
    {
        // Car fiat500c = new Car("FIAT", "500c", 2021);
        // fiat500c.Start();
        // Car fiat500L = new Car("FIAT", "500L");
        // fiat500L.Start();

        // Car car = new Car();
        // car.Start();

        // Car newCar = new Car("fiat", "300", 2034);
        // Console.WriteLine(newCar.Make);
        // newCar.Make = "fiat";
        // Console.WriteLine(newCar.Make);
        // Console.WriteLine(Car.StandardMaxSpeedKmH);

        // Car newCar2 = new (mk: "JEEP", mdl: "Chaser", yr: 2024, vehicleType: "4X4");
        // newCar2.Start();
        // Console.WriteLine(newCar2);
        // Console.WriteLine("+++++++++++++++++++++++++++++");
        // Console.WriteLine($"Total card produced {Car.TotalCarsProduced}");
        // // Console.WriteLine($"Available marks {string.Join(", ", Car.SupportedBrands)}");
        // Console.WriteLine($"Available marks {Car.GetSupportedBrandListString()}");
        // newCar2.Accelerate(10);
        // Console.WriteLine($"Current speed {newCar2.Speed}");


        // Car newCar2 = new Car(make: "FORD", model: "Fusion", year: 2021);
        // newCar.Start();
        // newCar2.Start();

        // Car car = new Car();
        // car.Make = "FIAT";
        // car.Model = "500c";
        // car.Year = 2019;
        // car.Start();

        // Car fiat500L = new ();
        // fiat500L.Make = "FIAT";
        // fiat500L.Model = "500L";
        // fiat500L.Year = 2021;
        // fiat500L.Start();

        // Console.WriteLine($"We have created a car {car.Make} {car.Model} {car.Year}");
        // Console.WriteLine($"We have created a car {fiat500L.Make} {fiat500L.Model} {fiat500L.Year}");
        Vehicle myVehicle = new() {
            Model = "500c", Brand = "FIAT", Version = "500C HYBRID"
        };

        Console.WriteLine(myVehicle.GetHashCode());
        myVehicle.Start();
        myVehicle.Accelerate(10);
        Console.WriteLine($"Speed is {myVehicle.Speed}");

        IVehicle myVehicle2 = new Vehicle() {
            Model = "500c", Brand = "FIAT", Version = "500C HYBRID"
        };

        Console.WriteLine($"Mesaage fromt myVehicle {myVehicle.VehicleToString()}");
        Console.WriteLine($"Mesaage fromt myVehicle2 {myVehicle2.VehicleToString()}");
    }
}




