using BlaisePascal.LessonsExamples.Domain;

public class Program
{
    //Metodo di entrata per l'esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("Insert client's name:");
        string clientName = Console.ReadLine(); //Lettura input da console e assegnazione di esso ad una variabile

        Console.WriteLine($"\n\nWelcome to your shipping portal {clientName}!\n\n");

        int shippingCost = 5; //Dichiarazione variabile di tipo 'int'
        shippingCost = 10; //Assegnazione

        Console.WriteLine("Insert the shipping type:");
        string shippingType = Console.ReadLine();

        Console.WriteLine("Insert the number of purchased packages:");
        int numberOfPackages = int.Parse(Console.ReadLine());

        int totalCost = shippingCost * numberOfPackages; //Dichiarazione con espressione

        //$ inserito prima di una stringa fa capire al compilatore che dentro a quella stringa,
        //qualora ci fossero nomi di variabili all'interno di parentesi graffe {} deve mostrare il valore di quelle variabili
        Console.WriteLine($"\n\nSelected shipping type: {shippingType}");
        Console.WriteLine($"Total cost: {totalCost}");

        //[Type] [variabile] = new [Type](); è la sintassi per creare un nuovo oggetto di una classe
        
    }
}