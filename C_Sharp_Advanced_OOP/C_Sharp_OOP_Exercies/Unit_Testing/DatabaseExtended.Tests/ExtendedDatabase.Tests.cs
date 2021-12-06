//using ExtendedDatabase;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
   public class ExtendedDatabaseTests
   {
      [SetUp]
      public void Setup()
      {
      }

      [Test]
      [TestCase(123412341234, "Dreinar")]
      public void PersonConstructorShouldIntializeWithCorrectValues(long id, string name)
      {
         //Arrange
         Person person = new Person(id, name);

         //Assert
         Assert.That(person.Id == id && person.UserName == name);
      }

      //Rework Database Tests

      [Test]
      [TestCase(3)]
      [TestCase(16)]
      [TestCase(0)]
      public void AddRangeMethodShouldAddNewElementsWhileCountIsLessThan16(int count)
      {
         List<Person> people = new List<Person>(); ;

         for (int i = 0; i < count; i++)
         {
            people.Add(new Person(i, "Person" + i));
         }


         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(people.ToArray());

         //Assert
         Assert.That(database.Count == count);
      }

      [Test]
      [TestCase(25)]
      public void AddRangeMethodShouldThrowArgumentExceptionWhenPeopleCountIsOver16(int count)
      {
         List<Person> people = new List<Person>(); ;

         for (int i = 0; i < count; i++)
         {
            people.Add(new Person(i, "Person" + i));
         }

         //Arrange

         //Assert
         Assert.Throws<ArgumentException>(() => new ExtendedDatabase(people.ToArray()));

      }


      [Test]
      [TestCase(16)]
      [TestCase(1)]
      [TestCase(0)]
      public void AddMethodShouldIncreasePeopleCount(int count)
      {
         //Arrange
         List<Person> people = new List<Person>(); ;

         for (int i = 0; i < count; i++)
         {
            people.Add(new Person(i, "Person" + i));
         }


         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(people.ToArray());

         //Assert
         Assert.AreEqual(count, database.Count);
      }

      [Test]
      [TestCase(16)]
      public void AddMethodShouldThrowInvalidOperationExceptionWhenCountBecomesOver16(int count)
      {
         //Arrange
         List<Person> people = new List<Person>(); ;

         for (int i = 0; i < count; i++)
         {
            people.Add(new Person(i, "Person" + i));
         }


         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(people.ToArray());

         //Assert
         Assert.Throws<InvalidOperationException>(() => database.Add(new Person(1234, "Kiko")));
      }

      [Test]
      [TestCase(1234, "Kiko")]
      [TestCase(5678, "Dante")]
      public void AddMethodShouldThrowInvalidOperationExceptionWhenUserNameIsAlreadyUsed(long id, string username)
      {
         Person person1 = new Person(id, username);
         Person person2 = new Person(100101, username);

         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(person1);

         //Assert
         Assert.Throws<InvalidOperationException>(() => database.Add(person2));
      }

      [Test]
      [TestCase(1234, "Kiko")]
      [TestCase(5678, "Dante")]
      public void AddMethodShouldThrowInvalidOperationExceptionWhenIDIsAlreadyUsed(long id, string username)
      {
         Person person1 = new Person(id, username);
         Person person2 = new Person(id, "Sasho");

         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(person1);

         //Assert
         Assert.Throws<InvalidOperationException>(() => database.Add(person2));
      }



      [Test]
      public void RemoveMethodShouldThrowExceptionWhenElementsAre0()
      {
         //Arrange
         ExtendedDatabase database = new ExtendedDatabase();

         //Act
         //database.Remove();

         //Assert
         // Assert.That(() => { database.Add(10); }, Throws.InvalidOperationException);
         Assert.Throws<InvalidOperationException>(() => database.Remove());
      }

      [Test]
      [TestCase(10, 15)]
      [TestCase(9, 10)]
      [TestCase(1, 16)]
      [TestCase(1, 1)]
      public void RemoveMethodShouldRemoveElementsWhileBelow16OrAbove0(int countRemoved, int countAdded)
      {
         //Arrange

         //Arrange
         List<Person> people = new List<Person>(); ;

         for (int i = 0; i < countAdded; i++)
         {
            people.Add(new Person(i, "Person" + i));
         }

         ExtendedDatabase database = new ExtendedDatabase(people.ToArray());

         //Act
         for (int i = 0; i < countRemoved; i++)
         {
            database.Remove();
         }

         //Assert
         Assert.AreEqual(countAdded - countRemoved, database.Count);
         //Assert.IsNull()
      }




      [Test]
      [TestCase(null)]
      [TestCase("")]
      public void FindByUsernameShouldThrowExceptionWhenUserNameIsNullOrEmpty(string username)
      {
         Person person1 = new Person(1234, "Dante");

         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(person1);

         //Assert
         Assert.Throws<ArgumentNullException>(() => database.FindByUsername(username));
      }


      [Test]
      [TestCase(1234, "Kiko")]
      [TestCase(5678, "Dante")]
      public void FindByUsernameShouldThrowExceptionWhenPersonIsNotFound(long id, string username)
      {
         Person person1 = new Person(id, username);

         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(person1);

         //Assert
         Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Sasho"));
      }


      [Test]
      [TestCase(1234, "Kiko")]
      [TestCase(5678, "Dante")]
      public void FindByUsernameShouldReturnCorrectPerson(long id, string username)
      {
         Person person1 = new Person(id, username);

         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(person1);

         //Assert
         Assert.AreSame(person1, database.FindByUsername(username));
      }




      [Test]
      [TestCase(-1)]
      [TestCase(-100)]
      public void FindByIdShouldThrowExceptionWhenIDIsNegativeNumber(long id)
      {
         Person person1 = new Person(1234, "Dante");

         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(person1);

         //Assert
         Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(id));
      }


      [Test]
      [TestCase(1234, "Kiko")]
      [TestCase(5678, "Dante")]
      public void FindByIdShouldThrowExceptionWhenPersonIsNotFound(long id, string username)
      {
         Person person1 = new Person(id, username);

         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(person1);

         //Assert
         Assert.Throws<InvalidOperationException>(() => database.FindById(12345));
      }


      [Test]
      [TestCase(1234, "Kiko")]
      [TestCase(5678, "Dante")]
      public void FindByIdShouldReturnCorrectPerson(long id, string username)
      {
         Person person1 = new Person(id, username);

         //Arrange
         ExtendedDatabase database = new ExtendedDatabase(person1);

         //Assert
         Assert.AreSame(person1, database.FindById(id));
      }


   }
}