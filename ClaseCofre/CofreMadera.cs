using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClaseCofre
{
    internal class CofreMadera
    {
        private int oro = 75;
        private bool abierto = false;

        public void Abrir()
        {
            if (abierto == false) 
                Console.WriteLine($"¡Abriste el cofre encontraste {oro}G!.");
            else
                Console.WriteLine("El cofre ya esta abierto.");
        }
    }
}
