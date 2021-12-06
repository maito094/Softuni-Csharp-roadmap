//using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
   public class CarTests
   {
      [SetUp]
      public void Setup()
      {
      }

      [Test]
      [TestCase("Toyta", "Camry", 25.4, 45.5)]
      public void ConstructorShouldSetAllValuesCorrectly(string maker, string model, double consumption, double capacity)
      {
         Car car = new Car(maker, model, consumption, capacity);

         Assert.IsNotNull(car);
         Assert.AreEqual(0, car.FuelAmount);
         Assert.AreEqual(maker, car.Make);
         Assert.AreEqual(model, car.Model);
         Assert.AreEqual(consumption, car.FuelConsumption);
         Assert.AreEqual(capacity, car.FuelCapacity);
      }


      [Test]
      [TestCase(null, "Camry", 25.4, 45.5)]
      [TestCase("", "Camry", 25.4, 45.5)]

      public void ConstructorShouldThrowArgumentExceptionForInvalidMaker(string maker, string model, double consumption, double capacity)
      {
         Assert.Throws<ArgumentException>(() => new Car(maker, model, consumption, capacity));
      }

      [Test]
      [TestCase("Toyota", null, 25.4, 45.5)]
      [TestCase("Toyota", "", 25.4, 45.5)]

      public void ConstructorShouldThrowArgumentExceptionForInvalidModel(string maker, string model, double consumption, double capacity)
      {
         Assert.Throws<ArgumentException>(() => new Car(maker, model, consumption, capacity));
      }

      [Test]
      [TestCase("Toyta", "Camry", 0, 45.5)]
      [TestCase("Toyta", "Camry", -1.54, 45.5)]

      public void ConstructorShouldThrowArgumentExceptionForInvalidFuelConsumption(string maker, string model, double consumption, double capacity)
      {
         Assert.Throws<ArgumentException>(() => new Car(maker, model, consumption, capacity));
      }


      [Test]
      [TestCase("Toyta", "Camry", 20, -1)]
      [TestCase("Toyta", "Camry", 15.54, 0)]

      public void ConstructorShouldThrowArgumentExceptionForInvalidFuelCapacity(string maker, string model, double consumption, double capacity)
      {
         Assert.Throws<ArgumentException>(() => new Car(maker, model, consumption, capacity));
      }




      [Test]
      [TestCase("Toyta", "Camry", 20, 100)]
      [TestCase("Toyta", "Camry", 15.54, 60)]

      public void RefuelMethodShouldIncreaseFuelAmount(string maker, string model, double consumption, double capacity)
      {
         //Arrange
         Car car = new Car(maker, model, consumption, capacity);

         //Act
         car.Refuel(10.56);

         //Assert

         Assert.AreEqual(10.56, car.FuelAmount);
      }

      [Test]
      [TestCase("Toyta", "Camry", 20, 100, 101)]
      [TestCase("Toyta", "Camry", 15.54, 60, 100)]

      public void RefuelMethodShouldFueltoFuelCapacityWhenOverflow(string maker, string model, double consumption, double capacity, double fuelToRefuel)
      {
         //Arrange
         Car car = new Car(maker, model, consumption, capacity);

         //Act
         car.Refuel(fuelToRefuel);

         //Assert

         Assert.AreEqual(car.FuelCapacity, car.FuelCapacity);
      }

      [Test]
      [TestCase("Toyta", "Camry", 20, 100, 0)]
      [TestCase("Toyta", "Camry", 15.54, 60, -10)]

      public void RefuelMethodShouldThrowExceptionForIncorrectFueltoRefuel(string maker, string model, double consumption, double capacity, double fuelToRefuel)
      {
         //Arrange
         Car car = new Car(maker, model, consumption, capacity);

         //Act


         //Assert

         Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
      }



      //Drive Method Test

      [Test]
      [TestCase("Toyta", "Camry", 20, 100, 101, 5)]
      [TestCase("Toyta", "Camry", 15.54, 60, 100, 10)]

      public void DriveMethodShouldDecreaseFuelAmountCorrectly(string maker, string model, double consumption, double capacity, double fuelToRefuel, double distance)
      {
         //Arrange
         Car car = new Car(maker, model, consumption, capacity);

         //Act
         car.Refuel(fuelToRefuel);
         car.Drive(distance);


         //Assert

         Assert.AreEqual(capacity - (distance / 100) * consumption, car.FuelAmount);
      }

      [Test]
      [TestCase("Toyta", "Camry", 20, 100, 101, 5)]
      [TestCase("Toyta", "Camry", 15.54, 60, 100, 10)]

      public void DriveMethodShouldThrowInvalidOperationException(string maker, string model, double consumption, double capacity, double fuelToRefuel, double distance)
      {
         //Arrange
         Car car = new Car(maker, model, consumption, capacity);

         //Act      
        


         //Assert

         Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
      }

   }
}