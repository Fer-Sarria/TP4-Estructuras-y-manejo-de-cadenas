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
            //EjecutarEjercicio4();
            //EjecutarEjercicio5();
            EjecutarEjercicio6();

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

            // 4. Ingrese su nombre y su mes de nacimiento y mostrar su signo zodiacal.
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

            // 5. Realizar el siguiente ejercicio en el que se ingresa por teclado 4 notas de un alumno,
            // mostrar nombre del alumno, el promedio de las 4 notas e indicar si está APROBADO
            // caso contrario DESAPROBADO, teniendo en cuenta la escala de calificaciones de la
            // escuela.
            static void EjecutarEjercicio5()
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del alumno");
                string alumno = Console.ReadLine();

                double suma = 0;
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine($"Ingrese la nota {i}");
                    suma += Convert.ToDouble(Console.ReadLine());
                }

                double promedio = suma / 4;

                Console.WriteLine($"\nNombre del alumno: {alumno}");
                Console.WriteLine($"Promedio: {promedio:F2}");

                // Escala estándar de aprobación en Argentina (se aprueba con 4 o más)
                if (promedio >= 4)
                {
                    Console.WriteLine("Condición: APROBADO");
                }
                else
                {
                    Console.WriteLine("Condición: DESAPROBADO");
                }

                Console.ReadKey();
            }

            // 6. Ingresar dos valores numéricos y mostrar su suma, resta, multiplicación y división. Si la
            // multiplicación es mayor e igual que 20 restarle el resultado de la resta de los 2 valores,
            // caso contrario a la multiplicación añadirle su suma, mostrar el resultado.
            static void EjecutarEjercicio6()
            {
                Console.Clear();
                Console.WriteLine("Ingrese el primer valor numérico");
                double v1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo valor numérico");
                double v2 = Convert.ToDouble(Console.ReadLine());

                double suma = v1 + v2;
                double resta = v1 - v2;
                double multiplicacion = v1 * v2;

                // Evitamos división por cero de forma segura
                double division = v2 != 0 ? v1 / v2 : 0;

                Console.WriteLine($"\nSuma: {suma}");
                Console.WriteLine($"Resta: {resta}");
                Console.WriteLine($"Multiplicación: {multiplicacion}");
                Console.WriteLine($"División: {(v2 != 0 ? division.ToString("F2") : "No es posible dividir por cero")}");

                double resultadoFinal;
                if (multiplicacion >= 20)
                {
                    resultadoFinal = multiplicacion - resta;
                    Console.WriteLine($"\nComo la multiplicación es >= 20, se resta la resta. Resultado: {resultadoFinal}");
                }
                else
                {
                    resultadoFinal = multiplicacion + suma;
                    Console.WriteLine($"\nComo la multiplicación es < 20, se le añade la suma. Resultado: {resultadoFinal}");
                }

                Console.ReadKey();
            }

            // 7. Crear una aplicación que muestre el detalle de una compra de cubiertas. Si la cantidad
            // de cubiertas compradas es menor a 12, el cliente pagará $65000 por unidad con un
            // descuento de 8 %, y si la cantidad es mayor a 12, pagará $62000 con un descuento
            // adicional de 12 %.Mostrar por pantalla el nombre del cliente, la cantidad de llantas
            // compradas, el subtotal a pagar, el descuento y el importe total a pagar.

            static void EjecutarEjercicio7()
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del cliente");
                string cliente = Console.ReadLine();

                Console.WriteLine("Ingrese la cantidad de cubiertas compradas");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                double precioUnitario;
                double porcentajeDescuento;

                if (cantidad < 12)
                {
                    precioUnitario = 65000;
                    porcentajeDescuento = 0.08;
                }
                else
                {
                    precioUnitario = 62000;
                    porcentajeDescuento = 0.12;
                }

                double subtotal = cantidad * precioUnitario;
                double descuento = subtotal * porcentajeDescuento;
                double totalPagar = subtotal - descuento;

                Console.WriteLine($"\nNombre del cliente: {cliente}");
                Console.WriteLine($"Cantidad de llantas compradas: {cantidad}");
                Console.WriteLine($"Subtotal a pagar: ${subtotal:F2}");
                Console.WriteLine($"Descuento aplicado ({porcentajeDescuento * 100}%): ${descuento:F2}");
                Console.WriteLine($"Importe total a pagar: ${totalPagar:F2}");

                Console.ReadKey();
            }

            // 8. Utilizando una estructura múltiple switch, crear un algoritmo que determine si el día de
            // la semana ingresado por un usuario es un día hábil y muestre por pantalla qué día es
            // (por ej. “El día ingresado es martes”) de lo contrario muestre por pantalla el mensaje “El
            // día ingresado no es un día hábil”. Importante: Tome los recaudos necesarios para
            // asegurar el funcionamiento del algoritmo ya que un usuario puede ingresar LUNES,
            // lunes, Lunes, luneS, LuNeS, LUnES, etc.


        }
    }
}