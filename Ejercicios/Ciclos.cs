using System;
using System.Collections.Generic;
using System.Text;

namespace Operadores
{
    public class Ciclos
    {
        public void LLenadoListas()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }

            //foreach (var item in listInt)
            //{
            //    Console.WriteLine(item);
            //}

            int opt = 1;
            int count = 0;
            while (opt == 1)
            {
                //count++;
                count = count + 1;


                Console.WriteLine($"Grupo Sofia {count}");

                if (count == 20)
                {
                    opt = 2;
                }
            }

            Console.WriteLine("Salió del bucle");

        }


        public void EjemploWhile()
        {
            Ejercicios_1 objEjercicios = new Ejercicios_1();

            int opt = 1;

            while (opt == 1)
            {
                Console.Clear(); //limpiar pantalla
                Console.WriteLine("***********************");
                Console.WriteLine("***Ejercicios Sofia ***");
                Console.WriteLine("***********************");
                Console.WriteLine("");
                Console.WriteLine("1. Saludo por el nombre");
                Console.WriteLine("2. Conversión de longitud");
                Console.WriteLine("3. Circulo");
                Console.WriteLine("4. Determinar Par o Impar");
                Console.WriteLine("5. Palabra más larga");
                Console.WriteLine("6. Letra o número");
                Console.WriteLine("7. Indice De Masa Corporal");
                Console.WriteLine("8. Calculadora");
                Console.WriteLine("9. Md");
                Console.WriteLine("10. ** SALIR **");
                Console.WriteLine("");
                int ejercio = Convert.ToInt32(Console.ReadLine());

                if (ejercio == 1)
                {
                    objEjercicios.SaludoNombre();
                }
                else if (ejercio == 2)
                {
                    objEjercicios.ConversionLogintud();
                }
                else if (ejercio == 3)
                {
                    objEjercicios.Circulos();
                }
                else if (ejercio == 4)
                {
                    objEjercicios.NumerosPares();
                }
                else if (ejercio == 5)
                {
                    objEjercicios.PalabraLarga();
                }
                else if (ejercio == 6)
                {
                    objEjercicios.LetraoNumero();
                }
                else if (ejercio == 7)
                {
                    objEjercicios.IndiceDeMasaCorporal();
                }
                else if (ejercio == 8)
                {
                    objEjercicios.Calculadora();
                }
                else if (ejercio == 9)
                {
                    objEjercicios.Md();
                }
                else if (ejercio == 10)
                {
                    opt = 2;
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Presiona Enter para salir o comenzar");
                Console.ReadKey(); //espera a que de enter
            }
        }

        public void EjemploCicloFor()
        {
            //Digitar la cantidad de veces que se va a repetir un nombre
            int opt = 1;
            while (opt == 1)
            {
                Console.Clear();
                Console.WriteLine("***********************");
                Console.WriteLine("***Ejercicios Ciclo For ***");
                Console.WriteLine("***********************");
                Console.WriteLine("");
                Console.WriteLine("1. Repetir For");
                Console.WriteLine("2. ** SALIR **");
                int ejercio = Convert.ToInt32(Console.ReadLine());

                if (ejercio == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Digita un nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("¿cuantas veces quiere que se repita ese nombre?");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= cantidad; i++)
                    {
                        Console.WriteLine($"{nombre} {i}");
                    }

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Hasta la próxima");
                    opt = 2;
                }


            }
        }

        public void Multiplos()
        {
            Console.WriteLine("Saludos.");
            Console.WriteLine("Señor usuario escriba el número del cual quiere conocer sus multiplos hasta el 10");
            int NumeroUsuario = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10 ; i++)
            {
                int ResultadoMultiplo = i * NumeroUsuario;
                Console.WriteLine($"{NumeroUsuario} x {i} = {ResultadoMultiplo}");
            }
        }

        public void SumaEntreNumeros()
        {
            //Escriba un prpograma que pida al usuario dos números enteros, y luego estregue la suma de todos los números que están entre ellos.
            //Por ejemplo, si los números son 1 y 7, debe entregar como resultado 2 + 3 + 4 + 5 + 6 = 20.

            Console.WriteLine("Saludos.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Suma Entre Números");
            Console.WriteLine("");
            Console.WriteLine("Por favor digíte el Primer número: ");
            int Numero_1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Muy bien, ahora digite el segundo número: ");
            int Numero_2 = Convert.ToInt32(Console.ReadLine());
            int Suma = 0;
            int ResultadoSuma=Numero_2-Numero_1;
            if(Numero_1<Numero_2)
            {
                
                for (int i = (1+Numero_1); i < Numero_2; i++)
                {
                    Suma = (Suma + i);
                }
                Console.WriteLine($"Resultado: {Suma}");
            }
            else if (Numero_2<Numero_1)
            {
                for (int i = (1 + Numero_2 ); i < Numero_1; i++)
                {
                    Suma = (Suma + i);
                }
                Console.WriteLine($"Resultado: {Suma}");
            }
            else
            {
                Console.WriteLine("Los números son iguales");
            }
        }

        public void TiempoDeViaje()
        {
            //Un viajero desea saber, cuanto tiempo tomó un viaje que realizó.
            //El tiene la duración en minutos de cada uno de los tramos del viaje.
            //Desarrolle un programa que permita ingresar los tiempos de viaje de los tramos
            //y entregue como resultado el tiempo total de viaje en formato Horas:Minutos
            //El programa deja de pedir tiempos de viaje cuando ingresa un 0.
            Console.WriteLine("");
            Console.WriteLine("Saludos...");
            Console.WriteLine("");
            Console.WriteLine("Tiempo de viaje");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Diligencie la duración de sus tramos de viaje en minutos");
            Console.WriteLine("Para finalizar digite 0");
            Console.WriteLine("");
            Console.WriteLine("");
            int Suma = 0;
            while (true)
            {
                Console.Write("Duración tramo: ");
                int Duracion = Convert.ToInt32(Console.ReadLine());
                Suma = (Suma + Duracion);
                if(Duracion==0)
                {
                    if(Suma > 60)
                        {
                        int ResultadoHoraInt = Convert.ToInt32(Suma) / 60;
                        Decimal ResultadoHoraDec = Suma / 60;
                        Decimal ResultadoMinutos = Suma-(ResultadoHoraDec*60);
                        Console.WriteLine($"Tiempo total de viaje: {ResultadoHoraInt}:{ResultadoMinutos} horas");
                        }
                    else
                        { 
                            Console.WriteLine($"El tiempo de viaje es de {Suma} Minutos");
                            
                        }
                    break;
                }
                
            }
            

        }

        public void Evaluacion_1()
        {
            //Crea una aplicación que pida un número y calcule su factorial
            //(El factorial de un número es el producto de todos los entero 1 y se representa por el número seguido de un signo de exclamación.
            //Por ejmplo 5! = 1x2x3x45=120),

            Console.WriteLine("Saludos...");
            Console.WriteLine("");
            Console.WriteLine("Calcule el factorial de cualquier número entero aquí");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Escriba un número entero y presione Enter ");
            int Factorial=(Convert.ToInt32(Console.ReadLine()));
            int Multiplo=1;
            Console.Write(Factorial+"! = ");
            for (int i = 1; i <= Factorial; i++)
            {
                
                if(i<=Factorial)
                {
                    Multiplo = Multiplo * i;
                    Console.Write(i+"x");
                    
                }
               
                else
                { break; }
            }
            Console.Write("="+Multiplo);
        }

        public void Evaluacion_2()
        {
            //Crea una aplicacción que permita adivinar un número. La aplicación genera un número aleatorio del 1 al 100.
            //A continuación va pidiendo números y va respondiendo si el número a adivinar es mayor o menor que el introducido,
            //además de los intentos que te quedan (tienes 10 intentos para acertarlo). El programa termina cuando se acierta el número
            //(ademas te dice en cuantos intentos lo has acertado), si se llega al límite de intentos te muestra el número que había generado.

            Random random = new Random();
            Double Aleatorio = random.Next(1, 100);

            Console.WriteLine("");
            Console.WriteLine("Saludos...");
            Console.WriteLine("");
            Console.WriteLine("Será que puedes vencerme?... Adivina un número entre el 1 y el 100"); 
            Console.WriteLine("Adivina que número tengo en mente. Tendrás 10 oportunidades");
            Console.WriteLine("Sólo te daré una pista");
            Console.WriteLine("Comencemos");
            Console.WriteLine("Escribe un Número: ");
            Double Numero = Convert.ToDouble(Console.ReadLine());
            Double Diferencial = 0;
            if (Numero == Aleatorio)
            {
                Console.WriteLine("Felicidades Adivinaste!!!!... En el primer intento");
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (Numero > Aleatorio)
                    {
                        Console.WriteLine("Pista: El número que quieres adivinar es Menor que el que acabas de Digitar");
                    }
                    else if (Aleatorio > Numero)
                    {
                        Console.WriteLine("Pista: El número que quieres adivinar es Mayor que el que acabas de Digitar");
                    }
                    else
                    {
                        Console.WriteLine($"Felicidades Adivinaste!!!!... En el {Diferencial+1} intento");
                        break;
                    }
                    Diferencial = i;
                    Console.WriteLine($"Intento número {Diferencial} te quedan {10 - Diferencial} intentos");
                    if (Diferencial < 10)
                    {
                        Console.WriteLine("Vamos! Intentalo nuevamente. Escribe un Número: ");
                        Numero = Convert.ToDouble(Console.ReadLine());
                    }
                    else if (Diferencial==10)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Se te acabaron las oportunidades");
                        Console.WriteLine($"El número que no lográste adivinar era {Aleatorio} más suerte para la próxima.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                    
                }
                


            }
        }

        public void Evaluacion_3()
        {
            //Algoritmo que pida números hasta que se introdusca un 0. Debe imprimir la suma y la media de todos los números introducidos

            Console.WriteLine("");
            Console.WriteLine("Saludos...");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Dilegencia Números y conocerá inmediatamente la suma y el promedio de los números introducidos");
            Console.WriteLine("Para finalizar escriba el número 0");
            Console.WriteLine("");
            Console.Write("Escriba el primer número: ");
            Double Zero = 0;
            Double Contador = 0;
            while (true)
                {
                Double NuevoNumero = Convert.ToDouble(Console.ReadLine());
                Contador = Contador + 1;
                Zero = Zero + NuevoNumero;
                if (NuevoNumero <= 0)
                    {
                    Console.WriteLine("");
                    Console.WriteLine("Esto es todo amigos...");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;
                    }
                Console.WriteLine("la suma es: " + Zero);
                Console.WriteLine("El Promedio es: " + (Math.Round((Zero / Contador), 2)));
                Console.Write("Escriba otro Número: ");
            }
            
        }


            
            
            


        


    }
}
