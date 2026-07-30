using System;

namespace TP4_Estructuras_y_manejo_de_cadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("        TRABAJO PRÁCTICO N° 4          ");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Salario y horas extras de operario");
                Console.WriteLine("2. Cálculo de compra de lápices");
                Console.WriteLine("3. Determinar el mayor de 3 números");
                Console.WriteLine("0. Salir");
                Console.WriteLine("=======================================");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        EjecutarEjercicio1();
                        break;
                    case "2":
                        EjecutarEjercicio2();
                        break;
                    case "3":
                        EjecutarEjercicio3();
                        break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para reintentar.");
                        Console.ReadKey();
                        break; 
                }
            }
        }*/
            EjecutarEjercicio4();

            // --- MÉTODOS DE LOS EJERCICIOS (Se definen dentro de la clase Program) ---

            static void EjecutarEjercicio1()
            {
                Console.Clear();

                // 1. Quitamos los guiones decorativos y usamos WriteLine para el salto de línea
                Console.WriteLine("Ingresar la cantidad de horas trabajadas");
                double horas = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresar el valor por hora trabajada");
                double valor = Convert.ToDouble(Console.ReadLine());

                double jornadaNormal = 48;
                double salario = horas * valor;
                double extras = horas > jornadaNormal ? horas - jornadaNormal : 0;

                // 2. Formato exacto del mensaje de salida con el nombre e hilera del PDF
                Console.WriteLine($"El salario del trabajador;\nvictor es {salario}\n");
                Console.WriteLine($"La jornada es de : {jornadaNormal} horas");

                if (extras > 0)
                {
                    Console.WriteLine($"Tiene {extras} horas extras");
                }

                Console.ReadKey();
            }


            static void EjecutarEjercicio2()
            {
                Console.Clear();

                // 1. Mensaje de entrada igual al PDF (con salto de línea para el número)
                Console.WriteLine("Ingrese la cantidad de lapices comprados");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                double costoPorLapiz = 2.50;
                double costoBase = cantidad * costoPorLapiz;
                double descuento = 0;

                // 2. Mostrar de forma fija el precio estipulado
                Console.WriteLine($"Precio por lapiz : {costoPorLapiz:F2}\n");

                Console.WriteLine($"El costo es; {costoBase}\n");

                if (cantidad >= 1000)
                {
                    descuento = costoBase * 0.07;
                    Console.WriteLine("Descuento = 7%\n");
                    // Se usa el formato de coma decimal o punto según tu configuración regional
                    Console.WriteLine($"es ===> {descuento}");
                }
                else
                {
                    Console.WriteLine("Descuento = 0%\n");
                }

                double totalPagar = costoBase - descuento;
                Console.WriteLine($"\nEl total a pagar es : {totalPagar}");

                Console.ReadKey();
            }


            static void EjecutarEjercicio3()
            {
                Console.Clear();
                Console.WriteLine("--- EJERCICIO 3: Mayor de Tres Números ---");
                Console.Write("Ingrese el primer número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                double n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el tercer número: ");
                double n3 = Convert.ToDouble(Console.ReadLine());

                double mayor = n1;
                if (n2 > mayor) mayor = n2;
                if (n3 > mayor) mayor = n3;

                Console.WriteLine($"\nEl número {mayor} es mayor");

                Console.WriteLine("\nPresione cualquier tecla para volver al menú.");
                Console.ReadKey();
            }

            // 4. Ingrese su nombre y su mes de nacimiento (y día) y mostrar su signo zodiacal.
            static void EjecutarEjercicio4()
            {
                Console.Clear();
                Console.WriteLine("--- EJERCICIO 4: Signo Zodiacal ---");

                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese su mes de nacimiento (1 al 12): ");
                int mes = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese su día de nacimiento: ");
                int dia = Convert.ToInt32(Console.ReadLine());

                string signo = "";

                // Lógica para determinar el signo según día y mes
                if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19)) signo = "Aries";
                else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20)) signo = "Tauro";
                else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20)) signo = "Géminis";
                else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22)) signo = "Cáncer";
                else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22)) signo = "Leo";
                else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22)) signo = "Virgo";
                else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22)) signo = "Libra";
                else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21)) signo = "Escorpio";
                else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21)) signo = "Sagitario";
                else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19)) signo = "Capricornio";
                else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18)) signo = "Acuario";
                else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20)) signo = "Piscis";
                else signo = "Fecha no válida";

                Console.WriteLine($"\nHola {nombre}, tu signo zodiacal es: {signo}");

                Console.WriteLine("\nPresione cualquier tecla para volver al menú.");
                Console.ReadKey();
            }


        }
    }
}