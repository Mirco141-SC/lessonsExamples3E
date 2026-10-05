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

        //Attributo costante privato
        private const int MaxHealth = 100; //constant field that represents the maximum health of the enemy

        //Public constructor to initiate the enemy with a specific health value
        public Enemy() { }
    }
}