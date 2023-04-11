using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInArray
{
    class SearchInArray
    {
        public int n { get; set; }

        static void Main(string[] args)
        {
            SearchInArray searchInArray = new SearchInArray();
            searchInArray.Introduccion();
        }

        public void Introduccion()
        {
            Console.WriteLine("¡Bienvenido! La consola te pedirá ingresar varios datos que se almacenarán");
            Console.WriteLine("Posteriormente, podrás ingresar un dato y se verificará si coincide con alguno de los almacenados previamente");
            Console.WriteLine("¿Cuántos datos quieres ingresar?");

            int n;
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                this.n = n;
                IngresarDatos();
            }
            else
            {
                Console.WriteLine("El dato introducido no es correcto, ingresa un número entero positivo");
                Introduccion();
            }           
        }

        public void IngresarDatos()
        {
            n = this.n;
            float[] dato = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese el dato {(i + 1)}:");
                if (!float.TryParse(Console.ReadLine(), out dato[i]))
                {
                    Console.WriteLine("El dato introducido no es correcto, debe ser un número");
                    i--;
                }
            }

            string texto = "";

            while (texto != "end")
            {
                Console.WriteLine("Ingresa un dato para comprobar si coinciden con los almacenados previamente o 'end' para finalizar:");
                texto = Console.ReadLine();

                float datoIntroducido;
                bool datoAdmitido = float.TryParse(texto, out datoIntroducido);

                if (datoAdmitido)
                {
                    int posicion = -1;
                    for (int i = 0; i < dato.Length; i++)
                    {
                        if (dato[i] == datoIntroducido)
                        {
                            posicion = i + 1;
                        }                        
                    }
                    
                    if (posicion != -1)
                    {
                        Console.WriteLine($"El dato {datoIntroducido} coincide con el dato almacenado en la posición {posicion}");
                    }
                    else
                    {
                        Console.WriteLine($"El dato {datoIntroducido} no coincide con ningún dato almacenado");
                    }
                }
                else
                {
                    Console.WriteLine("El dato introducido no es correcto, debe ser un número");
                }
            }
        }   
    }
}
