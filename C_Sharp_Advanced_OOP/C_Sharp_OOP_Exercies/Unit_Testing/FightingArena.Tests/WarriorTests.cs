//using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
   public class WarriorTests
   {
      [SetUp]
      public void Setup()
      {
      }

      [Test]
      [TestCase("Stoyan", 50, 70)]
      [TestCase("Vasko", 67, 20)]
      [TestCase("Stoyan", 1, 30)]
      [TestCase("Stoyan", 1, 0)]
      public void ConstructorShouldSetEverythingIfDataIsValid(string name, int damage, int health)
      {
         //Arrange & Act
         Warrior warrior = new Warrior(name, damage, health);

         //Assert
         Assert.AreEqual(name, warrior.Name);
         Assert.AreEqual(damage, warrior.Damage);
         Assert.AreEqual(health, warrior.HP);
      }

      [Test]
      [TestCase(null)]
      [TestCase(" ")]
      public void ConstructorShouldThrowArgumentExceptionForInvalidName(string name)
      {
         Assert.Throws<ArgumentException>(() => new Warrior(name, 40, 50));
      }

      [Test]
      [TestCase(0)]
      [TestCase(-11)]
      [TestCase(-54)]
      public void ConstructorShouldThrowArgumentExceptionForInvalidDamage(int damage)
      {
         Assert.Throws<ArgumentException>(() => new Warrior("Vasko", damage, 50));
      }

      [Test]
      [TestCase(-11)]
      [TestCase(-54)]
      public void ConstructorShouldThrowArgumentExceptionForInvalidHealth(int health)
      {
         Assert.Throws<ArgumentException>(() => new Warrior("Vasko", 31, health));
      }


      [Test]
      public void AttackMethodShouldThrowExceptionWhenMyWarriorHPIsBelowOrEqual30()
      {
         Warrior myWarrior = new Warrior("Viktor", 30, 30);
         Warrior enemyWarrior = new Warrior("Niki", 20, 100);

         Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(enemyWarrior), "Your HP is too low in order to attack other warriors!");

      }


      [Test]
      public void AttackMethodShouldThrowExceptionWhenEnemyWarriorHPIsBelowOrEqual30()
      {
         Warrior myWarrior = new Warrior("Viktor", 30, 100);
         Warrior enemyWarrior = new Warrior("Niki", 20, 30);

         Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(enemyWarrior), $"Enemy HP must be greater than {30} in order to attack him!");

      }

      [Test]
      public void AttackMethodShouldThrowExceptionWhenOurHPisBelowEnemyDamage()
      {
         Warrior myWarrior = new Warrior("Viktor", 30, 50);
         Warrior enemyWarrior = new Warrior("Niki", 60, 100);

         Assert.Throws<InvalidOperationException>(() => myWarrior.Attack(enemyWarrior), $"You are trying to attack too strong enemy");

      }

      [Test]

      public void AttackMethodShouldDecreaseWarriorAndEnemyWarriorHPByCorrectAmountDamage()
      {


         Warrior myWarrior = new Warrior("Kolio", 30, 100);
         Warrior enemyWarrior = new Warrior("Zebra", 20, 100);

         var expectedMyWarriorHp = 80;
         var expectedEnemyHp = 70;

         //Act
         myWarrior.Attack(enemyWarrior);

         //Assert
         Assert.AreEqual(expectedMyWarriorHp, myWarrior.HP);
         Assert.AreEqual(expectedEnemyHp, enemyWarrior.HP);
      }

      [Test]
      public void AttackMethodShouldDecreaseEnemyWarriorHPToZero()
      {
         Warrior myWarrior = new Warrior("Viktor", 60, 100);
         Warrior enemyWarrior = new Warrior("Niki", 90, 50);

         //Act
         myWarrior.Attack(enemyWarrior);

         //Assert
         Assert.AreEqual(100 - enemyWarrior.Damage, myWarrior.HP);
         Assert.AreEqual(0,enemyWarrior.HP);


      }

   }
}