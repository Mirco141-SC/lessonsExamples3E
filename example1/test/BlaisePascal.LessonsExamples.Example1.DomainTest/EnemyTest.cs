using BlaisePascal.LessonsExamples.Example1.Domain;

namespace BlaisePascal.LessonsExamples.Example1.DomainTest
{
    public class EnemyTest
    {
        //Change this if you change the corresponding const inside the Enemy class
        private const int MaxHealth = 100;

        /*** Constructor ***/
        [Fact]
        public void Enemy_ShouldInitializeHealthAtMaxHealth()
        {
            Enemy enemy = new Enemy();

            Assert.Equal(MaxHealth, enemy.Health);
        }

        /*** Getters ***/
        //The only getter, GetHealth, was already tested in the Constructor test

        /*** Functions ***/
        /* SetHealth */
        [Fact]
        public void SetHealth_ParameterLowerThan0_HealthIsSetTo0()
        {
            Enemy enemy = new Enemy();

            enemy.SetHealth(-10);

            Assert.Equal(0, enemy.Health);
        }

        [Fact]
        public void SetHealth_ParameterHigherThanMaxHealth_HealthSetToMaxHealth()
        {
            Enemy enemy = new Enemy();

            enemy.SetHealth(190);

            Assert.Equal(MaxHealth, enemy.Health);
        }

        [Fact]
        public void SetHealth_ParameterInsideAllowedRange_HealthSetToParameter()
        {
            Enemy enemy = new Enemy();

            enemy.SetHealth(50);

            Assert.Equal(50, enemy.Health);
        }

        /* IsAlive */
        [Fact]
        public void IsAlive_HealthHigherThan0_ReturnTrue()
        {
            Enemy enemy = new Enemy();

            //Health is initialized as MaxHealth (> 0)

            Assert.True(enemy.IsAlive());
        }

        [Fact]
        public void IsAlive_HealthEquals0_ReturnFalse()
        {
            Enemy enemy = new Enemy();

            enemy.SetHealth(0);

            Assert.False(enemy.IsAlive());
        }

        [Fact]
        public void TakeDamage_ParameterLowerThan0_HealthUnchanged()
        {
            Enemy enemy = new Enemy();

            int currentHealth = enemy.Health;
            enemy.TakeDamage(-10);

            Assert.Equal(currentHealth, enemy.Health);
        }

        [Fact]
        public void TakeDamage_ParameterEquals0_HealthUnchanged()
        {
            Enemy enemy = new Enemy();

            int currentHealth = enemy.Health;
            enemy.TakeDamage(0);

            Assert.Equal(currentHealth, enemy.Health);
        }

        [Fact]
        public void TakeDamage_ParameterLeadsHealthLowerThan0_HealthSetTo0()
        {
            Enemy enemy = new Enemy();

            enemy.TakeDamage(190);

            Assert.Equal(0, enemy.Health);
        }

        [Fact]
        public void TakeDamage_ParameterHigherThan0_HealthChanged()
        {
            Enemy enemy = new Enemy();

            //Health is initialized as MaxHealth
            enemy.TakeDamage(20);

            Assert.Equal(MaxHealth - 20, enemy.Health);
        }
    }
}
