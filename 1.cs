using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        

    class persona
    {
            private int cedula;
            private String nombre;
            private String apellido;
            private int edad;

            public persona()
            {
                cedula = 402156848;
                nombre = "Ariel";
                apellido = "Martinez";
                edad = 18;
            }

         
            public String responsabilidad(){

               return "\n Los datos de la persona son:\n "+cedula+" "+nombre+" "+apellido+" "+edad+"\n";
            
            }

        }

       class profesor : persona{

            public profesor()
            {
                sueldo = 60000;
                
            }


            private int sueldo;           
           
            public String getsueldo()
            {
              return "El sueldo del profesor es: "+ sueldo;
            }

            static void Main(string[] args)
        {
            persona a = new persona();
            Console.WriteLine(a.responsabilidad());

            profesor b = new profesor();
            Console.WriteLine(b.getsueldo());
            Console.ReadLine();
                }


        }
    }

}