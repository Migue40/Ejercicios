using System;
using System.Collections.Generic;
using System.Text;

namespace Operadores
{
    public class Ejercicios_1
    {
        public void ConversionLogintud()
        {
            //Conversión de unidades de longitud

            //Escriba un programa que convierta de centímetro a pulgadas. Una pulgada es igual a 2.54
            //Centimetros.

            //Ingrese longitud: 45
            // 45 cm - 17.7165 in

            //Ingrese longitud: 13
            // 13 cm - 5.1181 in

            Console.WriteLine(" *** Convertidor *** ");
            Console.WriteLine("");
            Console.WriteLine("esciba un valor en cm.");
            Double ValorCentimetros = Convert.ToDouble(Console.ReadLine());
            Double ValorPulgada = 2.54;
            Decimal Conversion = Math.Round(Convert.ToDecimal(ValorCentimetros / ValorPulgada),4);
            Console.WriteLine("Su Valor en pulgadas es de " + Conversion + "pulgadas");


        }

        public void NumerosPares()
        {

            //Determinar par

            //escribe un programa que determine si el número entero ingresado por el usuario es par o no.

            //Ingrese un Número: 4
            //Su número es par.

            //Ingrese un número: 3
            //Su número es inpar.


            Console.WriteLine("Digita tu número");

            int numero = Convert.ToInt32(Console.ReadLine());

            int División = numero / 2;
            int Multiplicación = División * 2;

            if (Multiplicación == numero)
            {
                Console.WriteLine("Su número es par.");
            }
            else
            {
                Console.WriteLine("Su número es impar.");
            }

        }

        public void SaludoNombre()
        {

            //////Saludo

            //////Escriba un programa que pida al usuario que escriba su nombre y lo salude llamándole por su nombre.
            //////Ingrese su nombre:    Perico
            //////Hola, Perico.

            Console.WriteLine("Saludos, señor usuario por favor escriba su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, como está, señor " + nombre);

        }

        public void Circulos()
        {
            ////CIRCULOS

            ////Escriba un programa que reciba como entrada el radio de un círculo y entregue como salida:
            ////su perímetro y su área:

            ////Ingrese el radio: 5
            ////Perímetro:    31.4
            ////Área: 78.5


            double pi = 3.141592;

            Console.WriteLine("     Cículos     ");
            Console.WriteLine("");
            Console.WriteLine("Digite el radio de su círculo en cm.");
            Decimal Radio = Convert.ToDecimal(Console.ReadLine());

            double Perímetro = Math.Round((Convert.ToDouble(Radio) * (2 * pi)),1);
            double Area = Math.Round(((Convert.ToDouble(Radio) * Convert.ToDouble(Radio)) * pi),1);
            Console.WriteLine("El resultado del perímetro de su Círculo es " + Perímetro + "cm.");
            Console.WriteLine("El área de su cículo es " + Area + "cm2.");
        }

        public void PalabraLarga()
        {
            Console.WriteLine("Escriba la Palabra Uno");
            string Palabra_1=Console.ReadLine();

             Console.WriteLine("Escriba la Palabra Dos");
            string Palabra_2=Console.ReadLine();

            int Carateres_1 = Palabra_1.Length;
            int Carateres_2 = Palabra_2.Length;
            int Resultado_1=Carateres_1-Carateres_2;
            int Resultado_2=Carateres_2-Carateres_1;


            if (Palabra_1.Length > Palabra_2.Length)
            {
                Console.WriteLine($"La palabra uno tiene {Resultado_1} carácteres más que la palabra dos");
            }
            else if (Palabra_1.Length < Palabra_2.Length)
            {
                Console.WriteLine($"La palabra dos tiene {Resultado_2} carácteres más que la palabra uno");
            }
            else
            {
                Console.WriteLine("Las palabras tienen las mismas cantidades de carácteres");
            }
        }

        public void LetraoNumero()
        {
            Console.WriteLine("Escriba un carácter");
            String Caracter = Console.ReadLine();

            try
            {
                int numero = Convert.ToInt32(Caracter);
                Console.WriteLine("El carácter es un número");

            }
            catch (Exception)
            {
                Console.WriteLine("El carácter es una letra");
            }
        }

        public void IndiceDeMasaCorporal()
        {
            //Escriba un programa que reciba como entrada la estatura,
            //el peso y la edad de una persona, y le entregue su condición de riesgo.

            Console.WriteLine("");
            Console.WriteLine("Índice de masa corporal");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Señor usuario Digite su Edad, por favor.");
            int Edad= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Señor usuario Digite su peso en kilogramos, por favor.");
            Decimal Peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Señor usuario Digite su estatura en metros, por favor.");
            Decimal estatura = Convert.ToDecimal(Console.ReadLine());

            Decimal IMC = Math.Round(Peso / (estatura * estatura),1);

            if(IMC < 22)
            {
                if(Edad < 45)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Su condición de riesgo de sufrir enfermedades coronarias es bajo");
                }
                else if (Edad >= 45)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Su condición de riesgo de sufrir enfermedades coronarias es Medio");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("No pudimos procesar su edad");
                }
            }
            else if (IMC >= 22)
            {
                if (Edad < 45)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Su condición de riesgo de sufrir enfermedades coronarias es Medio");
                }
                else if (Edad >= 45)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Su condición de riesgo de sufrir enfermedades coronarias es Alto");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("No pudimos procesar su edad");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("No pudimos procesar su IMC");
            }
                        
        }

        public void Calculadora()
        {
            Console.WriteLine("Escriba un número");
            Double Numero_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qué desea hacer, escriba + para sumar, escriba - para restar, escriba * para multiplicar o escriba / para dividir");
             string Operador = Console.ReadLine();

            Console.WriteLine("escriba el segundo valor para la operación");
            Double Numero_2 = Convert.ToDouble(Console.ReadLine());
            if(Operador == "+")
            {
                Double ResultadoSuma= Numero_1+Numero_2;
                Console.WriteLine("");
                Console.WriteLine("El resultado de la suma es " + ResultadoSuma);
            }
            else if (Operador == "-")
            {
                Double ResultadoResta = Numero_1 - Numero_2;
                Console.WriteLine("");
                Console.WriteLine("El resultado de la Resta es " + ResultadoResta);
            }
            else if(Operador == "*")
            {
                Double ResultadoMultiplicacion = Numero_1 * Numero_2;
                Console.WriteLine("");
                Console.WriteLine("El resultado de la multiplicación es " + ResultadoMultiplicacion);
            }
            else if(Operador == "/")
            {
                Double ResultadoDivision = Math.Round((Numero_1 / Numero_2),2);
                Console.WriteLine("");
                Console.WriteLine("El resultado de la División es " + ResultadoDivision);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Lo lamento, aún no podemos operar con ese signo.");
            }
        }

        public void Md()
        {
            Console.WriteLine("Estado de peso actual");
            Console.WriteLine("");
            Console.WriteLine("Señor usuario Digite su peso actual en kilogramos, por favor.");
            Decimal Peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Señor usuario Digite su estatura en metros, por favor.");
            Decimal estatura = Convert.ToDecimal(Console.ReadLine());

            Decimal IMC = Math.Round(Peso / (estatura * estatura), 1);

            if (IMC < 18)
            {
                Console.WriteLine("");
                Console.WriteLine("Su peso actualmente se encuentra bajo, por favor visite su nutricionista");                
            }
            else if (IMC < 25)
            {
                Console.WriteLine("");
                Console.WriteLine("Su peso actualmente se encuentra Normal, mantega su dieta y alimentación balanceada");                
            }
            else if (IMC < 30)
            {
                Console.WriteLine("");
                Console.WriteLine("Actualmente ustd se encuentra en sobrepeso, por favor visite su nutricionista");                
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Su IMC, supera los estanderes establecidos en el programa, por favor visite su médico");
             }
        }
    }
}
