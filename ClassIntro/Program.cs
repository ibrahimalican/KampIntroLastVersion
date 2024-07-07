namespace ClassIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            string ad = "Engin";
            int yas = 36;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;



            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


            Console.WriteLine("Hello, World!");



            Product product1 = new Product();
            product1.Category = "Beyaz Eşya";
            product1.Name = "Buzdolabı";
            product1.Price = 6999.99;
            product1.StockQuantity = 25;


            Product product2 = new Product();
            product2.Category = "Akıllı Telefon";
            product2.Name = "IPhone 15 Pro Max";
            product2.Price = 89999.00;
            product2.StockQuantity = 50;


            Product product3 = new Product();
            product3.Category = "Dizüstü Bilgisayar";
            product3.Name = "Lenovo";
            product3.Price = 36500.00;
            product3.StockQuantity = 8;


            Product product4 = new Product();
            product4.Category = "Giyim";
            product4.Name = "Yazlık Erkek Gömlek";
            product4.Price = 650.00;
            product4.StockQuantity = 120;


            Product[] products = new Product[] {product1, product2, product3, product4 };

            Console.WriteLine("for başladı");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Category + " - " + products[i].Name + " - " + products[i].Price + " - " + products[i].StockQuantity);
            }
            Console.WriteLine("foreach başladı");
            foreach (var product in products)
            {
                Console.WriteLine(product.Category + " - " + product.Name + " - " + product.Price + " - " + product.StockQuantity);
            }
            Console.WriteLine("while başladı");
            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine(products[a].Category + " - " + products[a].Name + " - " + products[a].Price + " - " + products[a].StockQuantity);
                a++;
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }


    class Product
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
