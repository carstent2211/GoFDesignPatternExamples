using System;
using GoFDesignPatterns.Creational_Patterns.FactoryPattern;

namespace GoFDesignPatterns.Creational_Patterns.FactoryPatternAbstractClass {
    public abstract class Vehicle {
        public virtual void OutputStatus(FactoryPatternEnums.VehicleStatus status) {
            Console.WriteLine($"The vehicle is currently {status}");
        }
    }

    public class Car : Vehicle { }
    public class Van : Vehicle {
        public override void OutputStatus(FactoryPatternEnums.VehicleStatus status) {
            Console.WriteLine($"The van is currently {status}");
        }
    }
    public class Bus : Vehicle {
        public override void OutputStatus(FactoryPatternEnums.VehicleStatus status) {
            Console.WriteLine($"The bus is currently {status}");
        }
    }

    public class VehicleFactory {
        public Vehicle CreateVehicle(FactoryPatternEnums.VehicleType vehicleType) {
            switch (vehicleType.ToString()) {
                case "Van":
                    return new Van();
                case "Bus":
                    return new Bus();
                case "Car":
                default:
                    return new Car();
            }
        }
    }
}