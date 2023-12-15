using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un Nombre:");
        string nombre = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Feliz Navidad " + nombre + "!!!\n");

        ImprimirArbol(nombre);
    }

    static void ImprimirArbol(string nombre)
    {
        nombre = nombre.ToUpper();

        // Imprimir parte superior del árbol
        int z = 0;
        for (int i = 0; i < nombre.Length; i++)
        {
            
            Console.Write(new string(' ', nombre.Length - i));
            
            Console.Write(nombre.Substring(0, i * 1 + 1) + new string('*',i));
            
            Console.WriteLine();
            z ++;
        }

        // Imprimir tronco del árbol
        Console.Write(new string(' ', nombre.Length * 2 /2 -1));
        Console.WriteLine("|||");
        string saludo = "FELIZ NAVIDAD " + nombre + "!!! :)";
        Console.Write(new string('-', nombre.Length*2 + 1));
        Console.WriteLine("\n ");
        


        // Imprimir mensaje de felicitación
        Console.WriteLine();
        Console.WriteLine(saludo);

        Console.WriteLine("\n \n \n");

    }
}

