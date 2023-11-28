using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Kindle
{
    class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 3;
        private const int MAXIMIZE = 3;
        private const int MINIMIXE = 3;
        private const int RESTORE = 3;
        public static void Main()
        {
            string opcion;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            LinkedList<string> paginas = new LinkedList<string>();
            string F = "0";

            while (F == "0")
            {
                opcion = Presentacion();
                if (opcion == "0")
                {
                    Console.Clear();
                    Elecciones(paginas);
                }
                Console.Clear();
                Fin();
                F = Console.ReadLine();
            }

        }



        public static string Presentacion ()
        {
            string Bienvenida = @"D:\UNIVERSIDAD\TERCER SEMESTRE\Estructura de Datos\Kindle\Inicio.txt";
            IEnumerable<string> line = File.ReadLines(Bienvenida);
            string Ini = string.Join(Environment.NewLine, line);
            Console.WriteLine(Ini);
            string Eleccion = Console.ReadLine();
            return Eleccion;
        }
      public static void Menu()
        {
            string Bienvenida = @"D:\UNIVERSIDAD\TERCER SEMESTRE\Estructura de Datos\Kindle\Menu.txt";
            IEnumerable<string> line = File.ReadLines(Bienvenida);
            string Ini = string.Join(Environment.NewLine, line);
            Console.WriteLine(Ini);
           
        }
    public static void Fin()
        {
            string Libro = @"D:\UNIVERSIDAD\TERCER SEMESTRE\Estructura de Datos\Kindle\Fin.txt";
            IEnumerable<string> line = File.ReadLines(Libro);
            string Ini = string.Join(Environment.NewLine, line);
            Console.WriteLine(Ini);
        }
      public static void Elecciones (LinkedList<string> paginas) {
           
            string Eleccion = "a";
            while (Eleccion != "E")
                {
                Console.Clear();
                Menu();

                Eleccion = Console.ReadLine().ToUpper();
                    switch (Eleccion)
                    {
                    case "0":
                        Eleccion = "E";
                        break;
                    case "1":
                            Console.Clear();
                            LaLlorona(paginas);
                            break;
                        case "2":
                            Console.Clear();
                            ElDuende(paginas);
                            break;
                        case "3":
                            Console.Clear();
                            JineteSinCabeza(paginas);
                            break;
                        case "4":
                            Console.Clear();
                            LaPataSola(paginas);
                            break;
                        case "5":
                            Console.Clear();
                            LaMancarita(paginas);
                            break;
                        case "6":
                            Console.Clear();
                            JuanMachete(paginas);
                            break;
                        case "7":
                            Console.Clear();
                            ElSilbon(paginas);
                            break;
                        case "8":
                            Console.Clear();
                            MadreMonte(paginas);
                            break;
                        case "9":
                            Console.Clear();
                            AmantesTelembi(paginas);
                            break;

                    
                }

            }
        }
      


      public static void LaLlorona(LinkedList<string> paginas)
        {
            string Libro = @"D:\UNIVERSIDAD\TERCER SEMESTRE\Estructura de Datos\Kindle\books\La Llorona.txt";
            IEnumerable<string> line = File.ReadLines(Libro);
            string Ini = string.Join(Environment.NewLine, line);
            paginas = new LinkedList<string>();
            foreach (string i in Ini.Split('#'))
            {
                paginas.AddLast(i);
               
            }

            CambiarPag(paginas);

        }
      public static void ElDuende(LinkedList<string> paginas)
        {
            string Libro = @"C:\Users\ACER\Desktop\UNIVERSIDAD\Estructura de Datos\Kindle\books\El Duende.txt";
            IEnumerable<string> line = File.ReadLines(Libro);
            string Ini = string.Join(Environment.NewLine, line);
            paginas = new LinkedList<string>();
            foreach (string i in Ini.Split('#'))
            {
                paginas.AddLast(i);
              

            }

            CambiarPag(paginas);
        }
      public static void JineteSinCabeza (LinkedList<string> paginas)
        {
            string Libro = @"C:\Users\ACER\Desktop\UNIVERSIDAD\Estructura de Datos\Kindle\books\El Jinete Sin Cabeza.txt";
            IEnumerable<string> line = File.ReadLines(Libro);
            string Ini = string.Join(Environment.NewLine, line);
            paginas = new LinkedList<string>();
            foreach (string i in Ini.Split('#'))
            {
                paginas.AddLast(i);
               

            }

            CambiarPag(paginas);
        }
      public static void LaPataSola(LinkedList<string> paginas)
        {
            string Libro = @"C:\Users\ACER\Desktop\UNIVERSIDAD\Estructura de Datos\Kindle\books\La Pata Sola.txt";
            IEnumerable<string> line = File.ReadLines(Libro);
            string Ini = string.Join(Environment.NewLine, line);
            paginas = new LinkedList<string>();
            foreach (string i in Ini.Split('#'))
            {
                paginas.AddLast(i);
              
            }

            CambiarPag(paginas);

        }
      public static void LaMancarita(LinkedList<string> paginas)
        {
            string Libro = @"C:\Users\ACER\Desktop\UNIVERSIDAD\Estructura de Datos\Kindle\books\La Mancarita.txt";
            IEnumerable<string> line = File.ReadLines(Libro);
            string Ini = string.Join(Environment.NewLine, line);
            paginas = new LinkedList<string>();
            foreach (string i in Ini.Split('#'))
            {
                paginas.AddLast(i);


            }

            CambiarPag(paginas);

        }
      public static void JuanMachete(LinkedList<string> paginas)
        {
            string Libro = @"C:\Users\ACER\Desktop\UNIVERSIDAD\Estructura de Datos\Kindle\books\Juan Machete.txt";
            IEnumerable<string> line = File.ReadLines(Libro);
            string Ini = string.Join(Environment.NewLine, line);
            paginas = new LinkedList<string>();
            foreach (string i in Ini.Split('#'))
            {
                paginas.AddLast(i);


            }

            CambiarPag(paginas);

        }
      public static void ElSilbon(LinkedList<string> paginas)
        {
            string Libro = @"C:\Users\ACER\Desktop\UNIVERSIDAD\Estructura de Datos\Kindle\books\El Silbon.txt";
            IEnumerable<string> line = File.ReadLines(Libro);
            string Ini = string.Join(Environment.NewLine, line);
            paginas = new LinkedList<string>();
            foreach (string i in Ini.Split('#'))
            {
                paginas.AddLast(i);


            }

            CambiarPag(paginas);

        }
      public static void MadreMonte(LinkedList<string> paginas)
        {
            string Libro = @"C:\Users\ACER\Desktop\UNIVERSIDAD\Estructura de Datos\Kindle\books\Madremonte.txt";
            IEnumerable<string> line = File.ReadLines(Libro);
            string Ini = string.Join(Environment.NewLine, line);
            paginas = new LinkedList<string>();
            foreach (string i in Ini.Split('#'))
            {
                paginas.AddLast(i);

               
            }

            CambiarPag(paginas);

        }
      public static void AmantesTelembi(LinkedList<string> paginas)
        {
            string Libro = @"C:\Users\ACER\Desktop\UNIVERSIDAD\Estructura de Datos\Kindle\books\Amantes del Telembi.txt";
            IEnumerable<string> line = File.ReadLines(Libro);
            string Ini = string.Join(Environment.NewLine, line);
            paginas = new LinkedList<string>();
            foreach (string i in Ini.Split('#'))
            {
                paginas.AddLast(i);

               
            }

            CambiarPag(paginas); 
        }


      public static void CambiarPag(LinkedList<string> paginas)
        {
            string cambio = " ";
            LinkedListNode<string> pagActual = paginas.First;

            while (cambio != "1")
            {
                Console.WriteLine(pagActual.Value);
                cambio = Console.ReadLine().ToLower();
                if (cambio == "n")
                {
                    pagActual = pagActual.Next;
                }


                if (cambio == "m")
                {
                    pagActual = pagActual.Previous;
                }

                Console.Clear();


            }

        }

    }
}
          