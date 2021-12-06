using NUnit.Framework;
using System;
using System.Linq;
//namespace Database.Tests

namespace Tests
{
   public class DatabaseTests
   {
      [SetUp]
      public void Setup()
      {
      }

      [Test]
      [TestCase(3)]
      [TestCase(5)]
      [TestCase(16)]
      [TestCase(0)]
      public void AddMethodShouldAddNewElementsWhileCountIsLessThan16(int count)
      {
         //Arrange
         Database database = new Database();

         //Act
         for (int i = 0; i < count; i++)
         {
            database.Add(i);
         }
         //Assert
         Assert.AreEqual(count, database.Count);
      }


      [Test]

      public void AddMethodShouldThrowExceptionWhenItemsAreAbove16()
      {
         //Arrange
         Database database = new Database();

         //Act
         for (int i = 0; i < 16; i++)
         {
            database.Add(i);
         }

         //Assert
         // Assert.That(() => { database.Add(10); }, Throws.InvalidOperationException);
         Assert.Throws<InvalidOperationException>(() => database.Add(10));
      }

      [Test]
      public void RemoveMethodShouldThrowExceptionWhenElementsAre0()
      {
         //Arrange
         Database database = new Database();

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
         int[] elements = Enumerable.Range(0, countAdded).ToArray();
         Database database = new Database(elements);

         //Act
         for (int i = 0; i < countRemoved; i++)
         {
            database.Remove();

         }

         //Assert
         Assert.AreEqual(countAdded - countRemoved, database.Count);
      }





      [Test]
      [TestCase(1, 4)]
      [TestCase(1, 15)]
      [TestCase(1, 16)]
      public void ConstructorShouldAddAllItemsWhileTheyAreBelow16(int start, int count)
      {
         //Arrange
         int[] elements = Enumerable.Range(start, count).ToArray();

         //Act
         Database database = new Database(elements);

         //Assert
         Assert.AreEqual(count, database.Count);

      }

      [Test]

      public void ConstructorShouldThrowExceptionItemsWhileTheyAreAbove16()
      {
         //Arrange
         int[] elements = Enumerable.Range(0, 100).ToArray();
         //Database database = new Database();
         //Act

         //Assert
         Assert.Throws<InvalidOperationException>(() => new Database(elements));

      }



      [Test]
      [TestCase(1, 4,2)]
      [TestCase(1, 15,5)]
      [TestCase(1, 16,15)]
      public void FetchMethodShouldFetchCorrectItems(int start, int countAdded, int countRemoved)
      {
         //Arrange
         int[] elements = Enumerable.Range(start, countAdded).ToArray();
         Database database = new Database(elements);

         //Act
         for (int i = 1; i <= countRemoved; i++)
         {
            database.Remove();
            elements[elements.Length - i] = 0;
         }

         int[] array = database.Fetch();

         //Assert
         Assert.That(array.Sum() == elements.Sum());

      }




   }
}