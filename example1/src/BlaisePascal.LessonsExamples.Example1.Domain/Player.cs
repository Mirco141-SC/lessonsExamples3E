namespace BlaisePascal.PlayerHomework.Example1.Domain
{
    public class Player
    {
        private string _name;
        private int _level;
        private int _experience;
        private int _health;
        private int _maxHealth;
        private int _gold;

        public string Name
        {
            get { return _name; }
            private set
            {
                //Thought that it might have been better to put it here so, even in the future, no inconsistent value of _name can be put in here
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException($"Value not allowed in parameter {nameof(value)}: {value}");

                _name = value;
            }
        }

        public int Level
        {
            get { return _level; }
            private set
            {
                if (value < 1)
                    throw new ArgumentException($"Value {nameof(Level)} must be at least 1. Received: {value}");

                _level = value;
            }
        }

        public int Experience
        {
            get { return _experience; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException($"Value {nameof(Experience)} must be at least 0. Received: {value}");

                _experience = value;
            }
        }

        public int Health
        {
            get { return _health; }
            private set
            {
                if (value <= 0)
                {
                    _health = 0;
                }
                else if (value > MaxHealth)
                    _health = MaxHealth;
                //throw new InvalidOperationException($"Cannot set {nameof(Health)} to {value} because it is higher than {MaxHealth}."); //Alternatively
                else
                    _health = value;
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException($"Value {nameof(MaxHealth)} must be higher than 0. Received: {value}");

                _maxHealth = value;
            }
        }

        //In order to avoid concursive checks (Health setter checks for IsAlive consistency and vice-versa),
        //I've decided to make IsAlive a read-only propert. It fully depends on IsAlive and the code is simplified since there's no need to handle
        //The consistency between IsAlive and Health
        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public int Gold
        {
            get { return _gold; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException($"Value {nameof(Gold)} must be at least 0. Received: {value}");

                _gold = value;
            }
        }


        public Player(string name)
        {
            //Should I do this redudant check??? (Probably no.)
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException($"Value not allowed in parameter {nameof(name)}: {name}");

            Name = name;
            Level = 1;
            Experience = 0;
            MaxHealth = 100;
            Health = MaxHealth;
            Gold = 0;
        }


        public void AddExperience(int amount)
        {
            if (amount <= 0) throw new ArgumentException($"Paramater {nameof(amount)} must be higher than 0. Received: {amount}");
            Experience += amount;

            int levels = Experience / 100;
            if (levels > 0)
            {
                Level += levels;
                Experience -= 100 * levels;
            }
        }

        public void ResetExperience()
        {
            Experience = 0;
        }

        public void TakeDamage(int amount)
        {
            if (amount <= 0) throw new ArgumentException($"Paramater {nameof(amount)} must be higher than 0. Received: {amount}");
            Health -= amount;
        }

        public void Heal(int amount)
        {
            if (amount <= 0) throw new ArgumentException($"Paramater {nameof(amount)} must be higher than 0. Received: {amount}");
            Health += amount;
        }

        public void AddGold(int amount)
        {
            if (amount <= 0) throw new ArgumentException($"Paramater {nameof(amount)} must be higher than 0. Received: {amount}");
            Gold += amount;
        }

        public void ResetHealth()
        {
            Health = MaxHealth;
        }
    }
}