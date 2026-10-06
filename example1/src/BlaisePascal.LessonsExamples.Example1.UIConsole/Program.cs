using BlaisePascal.LessonsExamples.Domain;

public class Program
{
    //Metodo di entrata per l'esecuzione del codice
    public static void Main()
    {
        //[Type] [variabile] = new [Type](); è la sintassi per creare un nuovo oggetto di una classe
        Enemy newEnemy = new Enemy(); //Enemy class istance

        newEnemy.setHealth(10);
        Console.WriteLine($"Enemy health: {newEnemy.Health}");
        Console.WriteLine(newEnemy.isAlive() ? "Enemy is alive" : "Enemy is dead");
    }
}