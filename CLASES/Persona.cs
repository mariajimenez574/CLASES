using System;
using System.Collections.Generic;
using System.Text;

namespace CLASES
{
    class Persona

    {
        
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Programa { get; set; }
        public string Ficha { get; set; }

        #endregion

        #region Contructores
        public Persona (string nombre, string apellido, string documento )
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            
        }
        public Persona(string ficha, string programa)
        {
            Programa = programa;
            Ficha = ficha;

        }
        public Persona ()
        {

        }
        #endregion
        #region Metodos
        public void IngresarPersona()
        {
            Console.WriteLine("Ingrese el nombre del aprendiz: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del aprendiz: ");
            Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el documento del aprendiz: ");
            Documento = Console.ReadLine();
            Console.WriteLine("Ingrese el programa al cual esta matriculado el aprendiz: ");
            Programa = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de ficha del programa al cual esta matriculado el aprendiz: ");
           Ficha = Console.ReadLine();

        }
        public void ImprimirPersona()
        {
            Console.WriteLine($"El nombre de la persona es :{Nombre} {Apellido}");
            Console.WriteLine($"El numero de documento de {Nombre} {Apellido} es:{Documento}");
            Console.WriteLine($"El programa al cual el aprendiz {Nombre} {Apellido} esta matriculado es : {Programa}");
            Console.WriteLine($"El numero de ficha de {Programa} es: {Ficha} ");
        }
        public void ModificarPersona(string n, string a)
        {
            Nombre = n;
            Apellido = a;
        }
        #endregion
    }
}
