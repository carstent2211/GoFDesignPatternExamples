using GoFDesignPatterns.Creational_Patterns.FactoryPattern;

using System;

namespace GoFDesignPatterns {
    public class Program {
        static void Main(string[] args) {
            #region FactoryPatternInterface

            Console.WriteLine("######## FactoryPattern using interface ########");
            Console.WriteLine();

            var vehicleFactoryInterface = new Creational_Patterns.FactoryPatternInterface.VehicleFactory();
            Creational_Patterns.FactoryPatternInterface.Vehicle vehicleInterface;

            vehicleInterface = vehicleFactoryInterface.CreateVehicle(FactoryPatternEnums.VehicleType.Car);
            vehicleInterface.OutputStatus(FactoryPatternEnums.VehicleStatus.Stopped);
            vehicleInterface = vehicleFactoryInterface.CreateVehicle(FactoryPatternEnums.VehicleType.Van);
            vehicleInterface.OutputStatus(FactoryPatternEnums.VehicleStatus.Accelerating);
            vehicleInterface = vehicleFactoryInterface.CreateVehicle(FactoryPatternEnums.VehicleType.Bus);
            vehicleInterface.OutputStatus(FactoryPatternEnums.VehicleStatus.Moving);

            Console.WriteLine();
            Console.WriteLine("Press a key to go to next pattern");
            Console.ReadKey();

            #endregion

            #region FactoryPatternAbtractClass

            Console.WriteLine("######## FactoryPattern using abstract class ########");
            Console.WriteLine();

            var vehicleFactoryAbstractClass = new Creational_Patterns.FactoryPatternAbstractClass.VehicleFactory();
            Creational_Patterns.FactoryPatternAbstractClass.Vehicle vehicleAbstractClass;

            vehicleAbstractClass = vehicleFactoryAbstractClass.CreateVehicle(FactoryPatternEnums.VehicleType.Car);
            vehicleAbstractClass.OutputStatus(FactoryPatternEnums.VehicleStatus.Accelerating);
            vehicleAbstractClass = vehicleFactoryAbstractClass.CreateVehicle(FactoryPatternEnums.VehicleType.Van);
            vehicleAbstractClass.OutputStatus(FactoryPatternEnums.VehicleStatus.Moving);
            vehicleAbstractClass = vehicleFactoryAbstractClass.CreateVehicle(FactoryPatternEnums.VehicleType.Bus);
            vehicleAbstractClass.OutputStatus(FactoryPatternEnums.VehicleStatus.Stopped);

            Console.WriteLine();
            Console.WriteLine("Press a key to go to next pattern");
            Console.ReadKey();

            #endregion

        }
    }
}