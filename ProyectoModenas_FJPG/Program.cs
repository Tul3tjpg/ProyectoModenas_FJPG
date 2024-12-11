
namespace ProyectoModenas_FJPG
{
    internal class Program
    {
        //Metodo Principal
        static void Main(string[] args)
        {
            //Incluimos un ciclo para que el programa se ejecute infinitamente
            while (true)
            {
                //El metodo MostrarMenu nos aparecera en pantalla
                MostrarMenu();

                string respuestaUsuario = Console.ReadLine();

                switch (respuestaUsuario)
                {
                    case "1":
                        ConvertirPesosADolares();
                        break;
                    case "2":
                        ConvertirDolaresAPesos();
                        break;
                    case "3":
                        ConvertirPesosAEuros();
                        break;
                    case "4":
                        ConvertirEurosAPesos();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
                Console.ReadKey();

            }
        }
        //Este es un método que me imprime las opciones para el usuario
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu de Conversiones:");
            Console.WriteLine("1) Pesos a Dolares");
            Console.WriteLine("2) Dolares a Pesos");
            Console.WriteLine("3) Pesos a Euros");
            Console.WriteLine("4) Euros a Pesos");
            Console.WriteLine("");
        }

        //Metodo para convertir Pesos a Dolares, preguntando el tipo de cambio y la cantidad a convertir
        //Este metodo imprime el resultado de la conversion
        static void ConvertirPesosADolares()
        {
            Console.WriteLine("Pesos a Dolares");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);


            Console.WriteLine("Introduir la cantidad en pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal dolares = PesosADolares(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad en Dolares:{dolares.ToString("N2")}");
        }

        //Metodo para convertir Pesos a Euros, preguntando el tipo de cambio y la cantidad a convertir
        //Este metodo imprime el resultado de la conversion

        static void ConvertirPesosAEuros()
        {
            Console.WriteLine("Pesos a Euros");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);


            Console.WriteLine("Introduir la cantidad en pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal pesos);

            decimal euros = PesosAEuros(tipoDeCambio, pesos);
            Console.WriteLine($"Cantidad en Euros:{euros.ToString("N2")}");
        }

        //Metodo para convertir Dolares a Pesos, preguntando el tipo de cambio y la cantidad a convertir
        //Este metodo imprime el resultado de la conversion
        static void ConvertirDolaresAPesos()
        {
            Console.WriteLine("Dolares a pesos");
            Console.WriteLine("Introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoCambio);

            Console.WriteLine("Introducir la cantidad en dolares");
            respuestaUsuario = Console.ReadLine();

            decimal.TryParse(respuestaUsuario, out decimal dolares);

            decimal pesos = DolaresAPesos(tipoCambio, dolares);
            Console.WriteLine($"La cantidad en pesos es: {pesos.ToString("N2")}");
        }

        //Metodo para convertir Euros a Pesos, preguntando el tipo de cambio y la cantidad a convertir
        //Este metodo imprime el resultado de la conversion
        static void ConvertirEurosAPesos()
        {
            Console.WriteLine("Euros a Pesos");
            Console.WriteLine("Introducir tipo de cambio:");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoCambio);

            Console.WriteLine("Introducir la cantidad en euros:");
            respuestaUsuario = Console.ReadLine();

            decimal.TryParse(respuestaUsuario, out decimal euros);

            decimal pesos = EurosAPesos(tipoCambio, euros);
            Console.WriteLine($"La cantidad en pesos es: {pesos.ToString("N2")}");
        }

        //Esta función recibe el tipo de cambio en dolares y cantidad en Pesos
        //Regresa el resultado de la división, que es la catidad en Dolares
        static decimal PesosADolares(decimal tipoCambio, decimal pesos)
        {
            decimal dolares = 0.00m;
            dolares = pesos / tipoCambio;

            return dolares;
        }

        //Esta función recibe el tipo de cambio en Euros y cantidad en Pesos
        //Regresa el resultado de la división, que es la catidad en Euros
        static decimal PesosAEuros(decimal tipoCambio, decimal pesos)
        {
            decimal dolares = 0.00m;
            dolares = pesos / tipoCambio;

            return dolares;
        }

        //Esta función recibe el tipo de cambio en Pesos y cantidad en Dolares
        //Regresa el resultado de la división, que es la catidad en Pesos
        static decimal DolaresAPesos(decimal tipoCambio, decimal dolares)
        {
            decimal pesos = 0.00m;
            pesos = tipoCambio * dolares;
            return pesos;
        }

        //Esta función recibe el tipo de cambio en Pesos y cantidad en Euros
        //Regresa el resultado de la división, que es la catidad en Pesos
        static decimal EurosAPesos(decimal tipoCambio, decimal dolares)
        {
            decimal pesos = 0.00m;
            pesos = tipoCambio * dolares;
            return pesos;
        }
    }
}

