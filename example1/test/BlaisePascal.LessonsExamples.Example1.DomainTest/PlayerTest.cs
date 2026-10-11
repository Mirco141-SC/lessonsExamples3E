using BlaisePascal.PlayerHomework.Example1.Domain;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BlaisePascal.LessonsExamples.Example1.DomainTest
{
    public class PlayerTest
    {
        /*** Constructor ***/
        [Fact]
        public void Player_NameParameterEmpty_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Player(""));
        }

        [Fact]
        public void Player_NameParameterWhiteSpace_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Player("            "));
        }

        [Fact]
        public void Player_NameParameterValid_ShouldSetNameToParameter()
        {
            Player player = new Player("Mr. Test");

            Assert.Equal("Mr. Test", player.Name);
        }

        [Fact]
        public void Player_ShouldStartAtLevel1()
        {
            //Arrange - Act
            Player player = new Player("Mr. Test");

            //Assert
            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void Player_ShouldStartAtExperience0()
        {
            Player player = new Player("Mr. Test");

            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void Player_ShouldHaveMaxHealth100()
        {
            Player player = new Player("Mr. Test");

            Assert.Equal(100, player.MaxHealth);
        }

        [Fact]
        public void Player_ShouldStartAtHealth100()
        {
            Player player = new Player("Mr. Test");

            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void Player_ShouldStartAtHealthEqualToMaxHealth()
        {
            Player player = new Player("Mr. Test");

            Assert.Equal(player.MaxHealth, player.Health);
        }

        [Fact]
        public void Player_ShouldStartAtGold0()
        {
            Player player = new Player("Mr. Test");

            Assert.Equal(0, player.Gold);
        }

        /*** Getters/Setters ***/
        //Most of the getters are already tested in constructor's tests

        [Fact]
        public void GetIsAlive_HealthHigherThan0_ReturnTrue()
        {
            Player player = new Player("Mr. Test");

            Assert.True(player.IsAlive);
        }

        [Fact]
        public void GetIsAlive_Health0_ReturnFalse()
        {
            Player player = new Player("Mr. Test");

            player.TakeDamage(100);

            Assert.False(player.IsAlive);
        }

        /*** Functions ***/
        /* AddExperience */
        [Fact]
        public void AddExperience_AmountParameterLowerThan0_ShouldThrowArgumentException()
        {
            Player player = new Player("Mr. Test");

            Assert.Throws<ArgumentException> (() => player.AddExperience(-100));
        }

        [Fact]
        public void AddExperience_AmountParameterEqualTo0_ShouldThrowArgumentException()
        {
            Player player = new Player("Mr. Test");

            Assert.Throws<ArgumentException>(() => player.AddExperience(0));
        }

        [Fact]
        public void AddExperience_ThrowsException_ExperienceNotChanged()
        {
            Player player = new Player("Mr. Test");

            int currentExperience = player.Experience;
            try
            {
                player.AddExperience(-5);
            } catch(Exception) { }

            Assert.Equal(currentExperience, player.Experience);
        }

        [Fact]
        public void AddExperience_AmountParameterValid_ExperienceGetsAdded()
        {
            Player player = new Player("Mr. Test");

            player.AddExperience(50);

            Assert.Equal(50, player.Experience);
        }

        [Fact]
        public void AddExperience_AmountParameterLeadsExperienceTo100_LevelGetsAdded()
        {
            Player player = new Player("Mr. Test");

            int currentLevel = player.Level;
            player.AddExperience(100);

            Assert.Equal(currentLevel + 1, player.Level);
        }

        [Fact]
        public void AddExperience_AmountParameterLeadsExperienceTo100_ExperienceIs0()
        {
            Player player = new Player("Mr. Test");

            player.AddExperience(100);

            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void AddExperience_AmountParameterLeadsExperienceToMoreThan200_MoreLevelsGetsAdded()
        {
            Player player = new Player("Mr. Test");

            int currentLevel = player.Level;
            player.AddExperience(250);

            Assert.Equal(currentLevel + 2, player.Level);
        }

        [Fact]
        public void AddExperience_AmountParameterLeadsExperienceToMoreThan200_ExperienceIsLeftover()
        {
            Player player = new Player("Mr. Test");

            player.AddExperience(250);

            Assert.Equal(50, player.Experience);
        }

        /* ResetExperience */
        [Fact]
        public void ResetExperience_ExperienceIs0()
        {
            Player player = new Player("Mr. Test");

            player.AddExperience(150);
            player.ResetExperience();

            Assert.Equal(0, player.Experience);
        }

        /* TakeDamage */
        [Fact]
        public void TakeDamage_AmountParameterLowerThan0_ShouldThrowArgumentException()
        {
            Player player = new Player("Mr. Test");

            Assert.Throws<ArgumentException> (() => player.TakeDamage(-15));
        }

        [Fact]
        public void TakeDamage_AmountParameter0_ShouldThrowArgumentException()
        {
            Player player = new Player("Mr. Test");

            Assert.Throws<ArgumentException>(() => player.TakeDamage(0));
        }

        [Fact]
        public void TakeDamage_ThrowsException_HealthNotChanged()
        {
            Player player = new Player("Mr. Test");

            int currentHealth = player.Health;
            try
            {
                player.TakeDamage(-5);
            } catch(Exception) { }

            Assert.Equal(currentHealth, player.Health);
        }

        [Fact]
        public void TakeDamage_AmountParameterValid_HealthReduced()
        {
            Player player = new Player("Mr. Test");

            int currentHealth = player.Health;
            player.TakeDamage(20);

            Assert.Equal(currentHealth - 20, player.Health);
        }

        /* Heal */
        [Fact]
        public void Heal_AmountParameterLowerThan0_ShouldThrowArgumentException()
        {
            Player player = new Player("Mr. Test");

            Assert.Throws<ArgumentException>(() => player.Heal(-15));
        }

        [Fact]
        public void Heal_AmountParameter0_ShouldThrowArgumentException()
        {
            Player player = new Player("Mr. Test");

            Assert.Throws<ArgumentException>(() => player.Heal(0));
        }

        [Fact]
        public void Heal_ThrowsException_HealthNotChanged()
        {
            Player player = new Player("Mr. Test");

            int currentHealth = player.Health;
            try
            {
                player.Heal(-5);
            } catch(Exception) { }

            Assert.Equal(currentHealth, player.Health);
        }

        [Fact]
        public void Heal_AmountParameterTakesHealthToMoreThanMaxHealth_ShouldSetHealthToMaxHealth()
        {
            Player player = new Player("Mr. Test");
            
            //player.Health is initialized as MaxHealth
            player.Heal(20);

            Assert.Equal(player.MaxHealth, player.Health);
        }

        /* //To enable if you choose error throwing instead of auto-correction (see test above and Player class for enabling)
        [Fact]
        public void Heal_AmountParameterTakesHealthToMoreThanMaxHealth_ShouldThrowInvalidOperationException()
        {
            Player player = new Player("Mr. Test");

            //player.Health is intiliazed as MaxHealth

            Assert.Throws<InvalidOperationException>(() => player.Heal(20));
        }

        [Fact]
        public void Heal_AmountParameterTakesHealthToMoreThanMaxHealth_HealthNotChanged()
        {
            Player player = new Player("Mr. Test");

            //player.Health is initialized as MaxHealth
            player.Heal(20);

            Assert.Equal(player.MaxHealth, player.Health);
        }
        */

        [Fact]
        public void Heal_AmountParameterValid_HealthRestored()
        {
            Player player = new Player("Mr. Test");

            player.TakeDamage(20);
            int currentHealth = player.Health;
            player.Heal(20);

            Assert.Equal(currentHealth + 20, player.Health);
        }

        /* AddGold */
        [Fact]
        public void AddGold_AmountParameterLowerThan0_ShouldThrowArugmentException()
        {
            Player player = new Player("Mr. Test");

            Assert.Throws<ArgumentException> (() => player.AddGold(-5));
        }

        [Fact]
        public void AddGold_AmountParameter_LowerEqualTo0_ShouldThrowArgumentException()
        {
            Player player = new Player("Mr. Test");

            Assert.Throws<ArgumentException>(() => player.AddGold(0));
        }

        [Fact]
        public void AddGold_ThrowsException_GoldNotChanged()
        {
            Player player = new Player("Mr. Test");

            int currentGold = player.Gold;
            try
            {
                player.AddGold(-5);
            } catch(Exception) { }

            Assert.Equal(currentGold, player.Gold);
        }

        [Fact]
        public void AddGold_ParameterValid_GoldAmountChanged()
        {
            Player player = new Player("Mr. Test");

            int currentGold = player.Gold;
            player.AddGold(5);

            Assert.Equal(currentGold + 5, player.Gold);
        }

        /* ResetHealth */
        [Fact]
        public void ResetHealth_HealthEqualsMaxHealth()
        {
            Player player = new Player("Mr. Test");

            player.TakeDamage(20);
            player.ResetHealth();

            Assert.Equal(player.MaxHealth, player.Health);
        }
    }
}
