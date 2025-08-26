namespace RetoPractico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> availableFruits = new List<string>();

            availableFruits.Add("Coco");
            availableFruits.Add("Guayaba");
            availableFruits.Add("Manzana");
            availableFruits.Add("Pera");


            Dictionary<string, double> fruitsPrices = new Dictionary<string, double>();

            bool process = true;

            while (process)
            {

                Console.WriteLine("-------- MENU DE FRUTAS DISPONIBLES------------");
                Console.WriteLine("1 - Agregar nueva fruta y su precio");
                Console.WriteLine("2 - Lista de frutas y sus precios");
                Console.WriteLine("3 - Salir");
                Console.WriteLine("Selecciona una opcion: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)

                {
                    case 1:
                        Console.WriteLine("Que fruta deseas agregar: ");
                        string fruit = Console.ReadLine();

                        if (availableFruits.Contains(fruit))
                        {
                            Console.WriteLine("La fruta ya está registrada.");

                        }
                        else
                        {
                            double price;
                            Console.WriteLine("Ingrese el precio de la fruta: ");
                            string inputPrice = Console.ReadLine();

                            if (double.TryParse(inputPrice, out price))
                            {
                                availableFruits.Add(fruit);
                                fruitsPrices.Add(fruit, price);
                                Console.WriteLine("La fruta se ha agregado con su respectivo precio. ");

                            }
                            else
                            {
                                Console.WriteLine("Parece que digitaste mal el precio, no es correcto. ");
                            }

                        }
                        break;

                    case 2:

                        if (availableFruits.Count == 0)
                        {
                            Console.WriteLine("No hay frutas :(");
                        }
                        else
                        {
                            foreach (var item in fruitsPrices)
                            {
                                Console.WriteLine($"La fruta {item.Key} vale {item.Value}");

                            }
                        }
                        break;

                    case 3:
                        process = false;
                        Console.WriteLine("Vuelva pronto");
                        break;

                    default:
                        Console.WriteLine("La opcion no es valida, revise el menú e intentelo de nuevo");
                        break;
                }

            }

        }
    }
}
