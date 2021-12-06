//using FightingArena;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
   public class ArenaTests
   {
      [SetUp]
      public void Setup()
      {
      }

      [Test]
      public void ArenaConstructorShouldInitializeAllValues()
      {

         //Arrange

         Arena arena = new Arena();

         //Assert
         Assert.IsNotNull(arena.Warriors);

      }
      [Test]
      public void ArenaWarriorListShouldReturnZeroCount()
      {

         //Arrange

         Arena arena = new Arena();

         //Assert
         Assert.True(arena.Warriors.Count == 0);


      }

      [Test]
      public void EnreollMethodShouldAddWarriorIfDoesntExist()
      {
         //Arrange
         Arena arena = new Arena();

         Warrior warrior = new Warrior("Viktor", 50, 80);
         Warrior warrior1 = new Warrior("Viktor1", 50, 80);
         Warrior warrior2 = new Warrior("Viktor2", 50, 80);

         //Act
         arena.Enroll(warrior);
         arena.Enroll(warrior1);
         arena.Enroll(warrior2);

         //Assert
         Assert.AreEqual(3, arena.Count);

         bool warriorExist = arena.Warriors.Any(x => x.Name == warrior.Name);
         bool warriorExist1 = arena.Warriors.Any(x => x.Name == warrior1.Name);
         bool warriorExist2 = arena.Warriors.Any(x => x.Name == warrior2.Name);

         Assert.True(warriorExist);
         Assert.True(warriorExist1);
         Assert.True(warriorExist2);
      }

      [Test]
      public void EnreollMethodShouldThrowExceptionForDuplicatedWarrior()
      {
         //Arrange
         Arena arena = new Arena();

         Warrior warrior = new Warrior("Viktor", 50, 80);

         arena.Enroll(warrior);

         //Assert
         Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
      }

      [Test]
      public void FightMethodShouldThrowInvalidOperationExceptionWhenAttackerAndDefenderIsNotEnrolled()
      {

         Arena arena = new Arena();
         Warrior defender = new Warrior("Viktor", 50, 50);
         Warrior attacker = new Warrior("Stoyan", 60, 60);

         Assert.Throws<InvalidOperationException>(() => arena.Fight(defender.Name, attacker.Name), $"There is no fighter with name {defender.Name} enrolled for the fights!");

      }

      [Test]
      public void FightMethodShouldThrowInvalidOperationExceptionWhenAttackerIsNotEnrolled()
      {

         Arena arena = new Arena();
         Warrior defender = new Warrior("Viktor", 50, 50);
         arena.Enroll(defender);
         Warrior attacker = new Warrior("Stoyan", 60, 60);

         Assert.Throws<InvalidOperationException>(() => arena.Fight(defender.Name, attacker.Name), $"There is no fighter with name {attacker.Name} enrolled for the fights!");

      }

      [Test]
      public void FightMethodShouldThrowInvalidOperationExceptionWhenDefenderIsNotEnrolled()
      {

         Arena arena = new Arena();
         Warrior defender = new Warrior("Viktor", 50, 50);
         Warrior attacker = new Warrior("Stoyan", 60, 60);
         arena.Enroll(attacker);

         Assert.Throws<InvalidOperationException>(() => arena.Fight(defender.Name, attacker.Name), $"There is no fighter with name {defender.Name} enrolled for the fights!");

      }

      [Test]
      public void FightMethodShouldChangeHPOfWarriors()
      {
         //Arrange
         Arena arena = new Arena();
         Warrior defender = new Warrior("Viktor", 100, 50);
         arena.Enroll(defender);
         Warrior attacker = new Warrior("Stoyan", 50, 100);
         arena.Enroll(attacker);

         //Act
         arena.Fight(attacker.Name, defender.Name);


         var warriorAttacker = arena.Warriors.FirstOrDefault(s => s.Name == attacker.Name);

         var warriorDefender = arena.Warriors.FirstOrDefault(s => s.Name == defender.Name);

         //Assert


         Assert.AreEqual(0, warriorAttacker.HP);
         Assert.AreEqual(0, warriorDefender.HP);

         Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker.Name, defender.Name));

      }

      [Test]
      public void FightMethodShouldChangeHPOfDefenderToZero()
      {
         //Arrange
         Arena arena = new Arena();
         Warrior defender = new Warrior("Viktor", 50, 50);
         arena.Enroll(defender);
         Warrior attacker = new Warrior("Stoyan", 51, 60);
         arena.Enroll(attacker);

         //Act
         arena.Fight(attacker.Name, defender.Name);


         var warriorAttacker = arena.Warriors.FirstOrDefault(s => s.Name == attacker.Name);

         var warriorDefender = arena.Warriors.FirstOrDefault(s => s.Name == defender.Name);

         //Assert


         Assert.AreEqual(10, warriorAttacker.HP);
         Assert.AreEqual(0, warriorDefender.HP);

      }


      [Test]
      public void FightMethodShouldThrowExceptionWhenHPIsBellowAttackerDamage()

      {
         //Arrange
         Arena arena = new Arena();
         Warrior defender = new Warrior("Kiro", 60, 80);
         arena.Enroll(defender);
         Warrior attacker = new Warrior("Atanas", 30, 40);
         arena.Enroll(attacker);

         //Act && Assert
         Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker.Name, defender.Name));

      }



   }
}
