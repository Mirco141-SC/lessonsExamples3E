public class Program
{
    //Metodo di entrata per l'esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("Hi\n\n");

        int shippingCost = 5; //Dichiarazione variabile di tipo 'int'
        shippingCost = 10; //Assegnazione

        int numberOfPackages = 5;

        string shippingType = "Standard"; //Dichiarazione variabile di tipo 'string'

        int totalCost = shippingCost * numberOfPackages; //Dichiarazione con espressione

        //$ inserito prima di una stringa fa capire al compilatore che dentro a quella stringa,
        //qualora ci fossero nomi di variabili all'interno di parentesi graffe {} deve mostrare il valore di quelle variabili
        Console.WriteLine($"Selected shipping type: {shippingType}");
        Console.WriteLine($"Total cost: {totalCost}");
    }
}