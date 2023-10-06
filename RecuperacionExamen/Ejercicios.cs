using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionExamen
{
    internal class Ejercicios
    {

        public void Problema2()
        {
            int numero1,numero2;
            Console.WriteLine("Ingrese dos numeros plz");
            numero1=Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());


            if (numero1 == numero2)
            {
                Console.WriteLine("Los numeros ingresados son iguales");
            }
            else if (numero2>numero1) { 
            for (int c=numero1; c<=numero2; c++) 
            {
                Console.WriteLine($"La secuenda de los numeros es {c}");
            }
            }
            else { 
            for (int c = numero1; c >= numero2; c--)
            {
                Console.WriteLine($"La secuenda de los numeros es {c}");
            }
            }
        }

        public int Problema3(int numero1, int caso)
        {
            



            if (caso > 10)
                return numero1;

            Console.WriteLine($" {numero1} x {caso} = " + numero1*caso);
            return Problema3(numero1, caso+1); 

        }

        
        public void Problema1()
        {
            string[] curpa;
            string curp;
            

            Console.WriteLine("Ingrese su curp");
             curp=Console.ReadLine();

            string sexo= curp.IndexOf()



           /* curpa = new string[curp.Length];
            if (curpa[9]=="H")
            {
                Console.WriteLine("Usted es de sexo masculino y su fecha de nacimiento es");
            }
            else
            {
                Console.WriteLine("Usted es de sexo Femenino y su fecha de nacimiento es");
            } */
        }
           
    }
}
