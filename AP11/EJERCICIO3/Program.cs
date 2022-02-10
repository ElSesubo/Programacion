using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPRODUCTOS FRESCOS:\n");
            ProductosFrescos pfresco1 = new ProductosFrescos("12/12/2021", "20/03/2019", "España", 25);
            ProductosFrescos pfresco2 = new ProductosFrescos("21/06/2022", "21/10/2019", "Francia", 10);
            pfresco1.verInfo();
            pfresco2.verInfo();
            Console.ReadKey();

            Console.WriteLine("\nPRODUCTOS REFRIGERADOS:\n");
            ProductosRefrigerados prefri1 = new ProductosRefrigerados("12/12/2021", "20/03/2019", "España", 25, "COD2", 14);
            ProductosRefrigerados prefri2 = new ProductosRefrigerados("21/06/2022", "21/10/2019", "Francia", 10, "COD3", 15);
            prefri1.verInfo();
            prefri2.verInfo();
            Console.ReadKey();

            Console.WriteLine("\nPRODUCTOS CONGELADOS:\n");
            CongeladoPorAgua pCAgua1 = new CongeladoPorAgua("02/11/2022", "01/10/2020", "España", 56, -2.0, 20.5);
            CongeladoPorAgua pCAgua2 = new CongeladoPorAgua("12/01/2021", "23/04/2019", "España", 12, 0.0, 15.5);
            pCAgua1.verInfo();
            pCAgua2.verInfo();

            Console.ReadKey();

            CongeladoPorNitrogeno pCNitro1 = new CongeladoPorNitrogeno("02/11/2022", "01/10/2020", "España", 56 , 12.2 , "ns" , 20);
            CongeladoPorNitrogeno pCNitro2 = new CongeladoPorNitrogeno("02/11/2022", "01/10/2020", "España", 56, 12.2, "ns", 21);
            pCNitro1.verInfo();
            pCNitro2.verInfo();

            Console.ReadKey();

            CongeladosPorAire pCAire1 = new CongeladosPorAire("02/11/2022", "01/10/2020", "España", 56, 12.2, 14.5, 16.2, 12.1, 25.1);
            CongeladosPorAire pCAire2 = new CongeladosPorAire("02/11/2022", "01/10/2020", "España", 56, 12.2, 14.5, 16.2, 12.1, 26.1);
            pCAire1.verInfo();
            pCAire2.verInfo();

            Console.ReadKey();

            List<ProductosCongelados> productoscongelados = new List<ProductosCongelados>();
            productoscongelados.Add(pCAgua1);
            productoscongelados.Add(pCAgua2);
            productoscongelados.Add(pCAire1);
            productoscongelados.Add(pCAire2);
            productoscongelados.Add(pCNitro1);
            productoscongelados.Add(pCNitro2);

            Console.Clear();
            Console.WriteLine("Lista de productos congelados:");
            Console.WriteLine("==============================");
            foreach (ProductosCongelados prod in productoscongelados)
            {
                prod.verInfo();     
                                    
            }

            Console.ReadKey();
        }
    }
}
