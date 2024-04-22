using Core.Controllers;

namespace TaskRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductController productController = new ProductController();

            bool check = true;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Mehsul elave et");
                Console.WriteLine("2. Mehsul deyish");
                Console.WriteLine("3. Mehsulu sil");
                Console.WriteLine("4. Mehsula bax");
                Console.WriteLine("5. Mehsullara bax");
                Console.WriteLine("0. Sistemden cix");
                Console.WriteLine("");

                string choiceStr;
                byte choice;

                do
                {
                    Console.WriteLine("");
                    Console.Write("Sechim edin: ");
                    choiceStr = Console.ReadLine();
                } while (!byte.TryParse(choiceStr, out choice));

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Mehsul elave et");
                        Console.WriteLine("");

                        productController.AddProduct();
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Mehsul deyish");
                        Console.WriteLine("");

                        productController.UpdateProduct();
                        break;

                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Mehsulu sil");
                        Console.WriteLine("");

                        productController.DeleteProduct();
                        break;

                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Mehsula bax");
                        Console.WriteLine("");

                        productController.GetProduct();
                        break;

                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Mehsullara bax");
                        Console.WriteLine("");

                        productController.GetAllProduct();
                        break;

                    case 0:
                        check = false;
                        Console.WriteLine("");
                        Console.WriteLine("Sistemden cix");
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Duzgun sechim et");
                        break;
                }

            } while (check);
        }
    }
}
