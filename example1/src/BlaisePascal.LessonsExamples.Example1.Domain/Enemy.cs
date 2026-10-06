/*--
* Author: Mirco Rossi
* Date: 29-09-2026
* Goal: Defining enemy player
*/

namespace BlaisePascal.LessonsExamples.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        //private: access modifier that makes the field accessible only within the class
        //int: data type for integer values
        //_health: field name that represents the health of the enemy
        private int _health;

        //Property
        public int Health { get; private set; } //Abbreviated form without checks

        //Standard way of providing a Set with checks
        //
        //Select + CTRL + K + C to comment all
        //public int Health
        //{
        //    get { return _health; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            _health = 0;
        //        } 
        //        else if (value > 100)
        //        {
        //            _health = 100;
        //        } 
        //        else _health = value;
        //    }
        //}

        //Constant private attribute
        private const int MaxHealth = 100; //constant field that represents the maximum health of the enemy

        //Public constructor to initiate the enemy with a specific health value
        public Enemy() { }

        //Alternative way of providing a public Set method.
        //This is safer, because the user does not know the structure behind our code (Propety not exposed).
        //This methods takes care of checking the entering value, and sets the Health method instead of the field.
        //The Health method therefore does not need checks anymore
        public void SetHealth(int newHealth)
        {
            //We avoid using { } if the instruction is only on 1 line.
            if (newHealth < 0)
                //At this point, we could directly skip the Property and directly set the field/attribute
                _health = 0; //Health = 0;
            else if (newHealth > 100)
                _health = 100; //Health = 100;
            else _health = newHealth; //Health = newHealth;
        }

        public bool IsAlive()
        {
            return _health > 0;
        }

        public void TakeDamage(int damage)
        {
            if(damage < 0)
                damage = 0;


            SetHealth(_health - damage);
        }
    }
}