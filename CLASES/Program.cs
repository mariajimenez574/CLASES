using System;

namespace CLASES
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
           
            Persona per2 = new Persona("Maria", "Jimenez", "1049659366");
            Persona per3 = new Persona("Cocina", "1478952");
            per.Nombre = "Andres";
            per.Apellido = "Sierra";
            per.Documento = "1002579358";
            per.Programa = "ADSI";
            per.Ficha = "1804643";
            Console.WriteLine("PRIMERA PERSONA ");
            Console.WriteLine($"Nombre ={per.Nombre} ");
            Console.WriteLine($"Apellido ={per.Apellido} ");
            Console.WriteLine($"Documento ={per.Documento} ");
            Console.WriteLine($"Programa ={per.Programa} ");
            Console.WriteLine($"Ficha ={per.Ficha} ");
            Console.WriteLine("SEGUNDA  PERSONA ");
            Console.WriteLine($"Nombre ={per2.Nombre} ");
            Console.WriteLine($"Apellido ={per2.Apellido} ");
            Console.WriteLine($"Documento ={per2.Documento} ");
            Console.WriteLine("PERSONA INGRESADA");
            per.IngresarPersona();
            per.ImprimirPersona();
            Console.WriteLine("PERSONA MODIFICADA");
            per.ModificarPersona("Juan", "Rojas");
            per.ImprimirPersona();
            Console.ReadLine();
            

        }
    }
}
