using Serviços_e_entidades.Entities;
using Serviços_e_entidades.Services;

namespace Serviços_e_entidades
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMPOSTO DE IMPORTAÇÃO");

            Console.Write("Nome do Produto: ");
            string produto = Console.ReadLine();

            Console.Write("Preço: ");
            double preço = double.Parse(Console.ReadLine());

            Console.Write("Mora em Portugal, ou no Brasil?: ");
            string pais = Console.ReadLine().Trim().ToLower();

            // instancia um produto e agrega um valor ao nome do produto só para que o serviço shipping dê ao mesmo o um valor a prop invoice
            Product product = new Product(produto);

            Shipping shipping = new Shipping();

            // o if passa o valor do produto e o pais do qual é aplicado a taxa de importação
            if (pais[0] == 'p')
            {
                //injeção de dependencia
                shipping = new Shipping(preço,new Portugal());
            }
            else if (pais[0] == 'b')
            {
                // injeção de dependencia
                shipping = new Shipping(preço, new Brasil());
            }

            //esse método simplemente agrega valor á notinha da varial product
            shipping.ProcessInvoice(product);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(product._Invoice);
            Console.WriteLine(shipping.DeliveryDate);

        }
    }
}