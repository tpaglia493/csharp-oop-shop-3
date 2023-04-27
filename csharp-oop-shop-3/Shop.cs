using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3
{
    
    public class Shop
    {
        //ATRIBUTES
        private string name;
        private string city;
        private string street;
        private int streetNumber;
        public List<Product> products;

        //STATES

        //CONSTRUCTOR
        public Shop(string name, string city, string street, int streetNumber ) 
        {
            this.name = name;   
            this.city = city;   
            this.street = street;   
            this.streetNumber = streetNumber;
            this.products = new();
    }

        //GETTERS
        public string GetName()
        {
            return name;
        }
        public string GetCity()
        {
            return city;
        }
        public string GetStreet()
        {
            return street;
        }
        public int GetStreetNumber()
        {
            return streetNumber;
        }
        //SETTERS
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetCity(string city)
        {
            this.city = city;
        }
        public void SetStreet(string street)
        {
            this.street = street;        
        }
        public void SetStreetNumber(int streetNumber)
        {
            this.streetNumber = streetNumber;
        }

        //METHODS

        public override string ToString()
        {
            string address = $"Name of the shop: {this.name} \n{this.streetNumber}, {this.street},  {this.city}";
            return address;
        }

        public void AddSingleProductToProducts(Product productName)
        {
            this.products.Add(productName);
            
        }
        public void ConcatListToProducts(List<Product> anyListOfProducts)
        {

            
           foreach( Product product in anyListOfProducts) 
            {
                this.products.Add(product);
            }
          
        }
       


    }
}
