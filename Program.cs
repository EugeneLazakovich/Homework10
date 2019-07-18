using System;

namespace _10._1
{
    interface IBasket
    {
        void addProduct(Product product);
        void deleteProduct(Product product);
        void getBasketInfo();
    }
    class Basket : IBasket
    {
        private Product[] products = new Product[5];
        public void addProduct(Product product)
        {
            for(int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    products[i] = product;
                    break;
                }
            }
        }
        public void deleteProduct(Product product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == product)
                {
                    products[i] = null;
                    break;
                }
            }
        }
        public void getBasketInfo()
        {
            int counter = 0;
            Console.WriteLine("Basket: ");
            for(int i=0; i < products.Length; i++)
            {
                if(products[i] != null)
                {
                    Console.WriteLine((counter + 1) + ". " + products[i].getName() + " : " + products[i].getPrice());
                    counter++;
                }                
            }
        }
    }
    abstract class Product
    {
        protected string name;
        protected int price;
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public virtual String getName()
        {
            return name;
        }
        public virtual int getPrice()
        {
            return price;
        }
        public virtual String getInfo()
        {
            return "Name: " + name + "; Price: " + price;
        }
    }
    class Beer : Product
    {
        public Beer(string name, int price) : base(name, price)
        {

        }
        public override String getName()
        {
            return name;
        }
        public override int getPrice()
        {
            return price;
        }
        public override String getInfo()
        {
            return "Name: " + name + "; Price: " + price;
        }
    }
    class Cheese : Product
    {
        public Cheese(string name, int price) : base(name, price)
        {

        }
        public override String getName()
        {
            return name;
        }
        public override int getPrice()
        {
            return price;
        }
        public override String getInfo()
        {
            return "Name: " + name + "; Price: " + price;
        }
    }
    class Milk : Product
    {
        public Milk(string name, int price) : base(name, price)
        {

        }
        public override String getName()
        {
            return name;
        }
        public override int getPrice()
        {
            return price;
        }
        public override String getInfo()
        {
            return "Name: " + name + "; Price: " + price;
        }
    }
    class Bread : Product
    {
        public Bread(string name, int price) : base(name, price)
        {

        }
        public override String getName()
        {
            return name;
        }
        public override int getPrice()
        {
            return price;
        }
        public override String getInfo()
        {
            return "Name: " + name + "; Price: " + price;
        }
    }
    class Chocolate : Product
    {
        public Chocolate(string name, int price) : base(name, price)
        {

        }
        public override String getName()
        {
            return name;
        }
        public override int getPrice()
        {
            return price;
        }
        public override String getInfo()
        {
            return "Name: " + name + "; Price: " + price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Basket basket = new Basket();
            Product beer = new Beer("Obolon", 20);
            Product cheese = new Cheese("Globino", 30);
            Product milk = new Milk("Yagotyn", 25);
            Product bread = new Bread("Kulinichy", 10);
            Product chocolate = new Chocolate("Roshen", 23);

            basket.getBasketInfo();
            basket.addProduct(beer);
            basket.addProduct(chocolate);
            basket.getBasketInfo();
            basket.deleteProduct(chocolate);
            basket.getBasketInfo();
        }
    }
}
