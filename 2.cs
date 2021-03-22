using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Contacto
    {
        private string nombre;
        private string apellidos;
        private string telefono;
        private string direccion;

        public void SetContacto()
        {

            Console.WriteLine("¿Cual es su nombre? ");
            nombre=Console.ReadLine();

            Console.WriteLine("¿Cual es su apellido? ");
            apellidos=Console.ReadLine();

            Console.WriteLine("¿Cual es su Telefono? ");
            telefono=Console.ReadLine();

            Console.WriteLine("¿Cual es su direccion? ");
            direccion=Console.ReadLine();
    
        }
        public void Saludar()
        {

            Console.WriteLine("Hola soy: "+nombre+" mi apellido es: "+apellidos+ " mi telefono es: "+telefono+" Y mi direccion es : "+direccion+"\n");
        }
        class ProbarContacto:Contacto
        {
            static void Main (string[] args)
            {
                Contacto contac1=new Contacto();
                Contacto contac2=new Contacto();
                Console.WriteLine("Dados de contacto 1: ");
                contac1.SetContacto();
                contac1.Saludar();
                Console.WriteLine("Dados de contacto 2: ");
                contac2.SetContacto();
                contac2.Saludar();
                
            }
        }


    }
}