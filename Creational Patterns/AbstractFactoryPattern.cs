using System;

namespace GoFDesignPatterns.Creational_Patterns.AbstractFactoryPattern {
    public interface ILights {
        void Toggle();
    }

    public interface IVehicle : ILights { }

    public interface ICar : IVehicle { }
    public interface IVan : IVehicle { }
    public interface IBus : IVehicle { }

    public interface IVehicleFactory {
        ICar CreateCar();
        IVan CreateVan();
        IBus CreateBus();
    }

    public class Car : ICar {
        private bool _lightsOn;
        public void Toggle() {
            _lightsOn = !_lightsOn;
            var lights = GetType().Name + " lights are ";
            lights += _lightsOn ? "on" : "off";

            Console.WriteLine(lights);
        }
    }

    public class Van : IVan {
        private bool _lightsOn;
        public void Toggle() {
            _lightsOn = !_lightsOn;
            var lights = GetType().Name + " lights are ";
            lights += _lightsOn ? "on" : "off";

            Console.WriteLine(lights);
        }
    }

    public class Bus : IBus {
        private bool _lightsOn;
        public void Toggle() {
            _lightsOn = !_lightsOn;
            var lights = GetType().Name + " lights are ";
            lights += _lightsOn ? "on" : "off";

            Console.WriteLine(lights);
        }
    }

    public class VehicleFactory : IVehicleFactory {
        public ICar CreateCar() {
            return new Car();
        }

        public IVan CreateVan() {
            return new Van();
        }

        public IBus CreateBus() {
            return new Bus();
        }

    }

    public class Vehicles {
        private ICar _car;
        private IVan _van;
        private IBus _bus;

        public Vehicles(IVehicleFactory factory) {
            _car = factory.CreateCar();
            _van = factory.CreateVan();
            _bus = factory.CreateBus();
        }

        public void LightToggle() {
            _car.Toggle();
            _van.Toggle();
            _bus.Toggle();
            _bus.Toggle();
            _van.Toggle();
            _car.Toggle();
        }
    }
}