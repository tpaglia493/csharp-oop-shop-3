using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3
{
    public class Product
    {

        //ATTRIBUTES & PROPERTIES
        private int code;
        private string commercialName;
        public string Name { get { return this.commercialName; } set { this.commercialName = value; } }

        private string description;
        public string Description { get { return this.description; } set { this.description = value; } }

        private float price;
        public float Price { get { return this.price; } set { this.price = value; } }

        private float iva;

        public float Iva { get { return this.iva; } set { this.iva = value; } }



        private Category category;

        
        //STATES


        //CONSTRUCTOR

        public Product(string commercialName, string description, float price, float iva, Category categoryName)
        {
            this.commercialName= commercialName;
            CodeGenerator();
            this.description = description;
            this.price = price;
            this.iva = iva;
            this.category = categoryName;
        }
        public Product( string commercialName, string description,Category categoryName)
        {
            this.commercialName = commercialName;
            CodeGenerator();
            this.description = description;
            this.category = categoryName;
        }



        //GETTERS
        public int getCode()
        {
            return this.code;
        }

        public Category GetCategory()
        {
            return this.category;
        }

    

        //METHODS

        private void CodeGenerator() 
        {
            Random number = new Random();
            this.code = number.Next(1, 99999999);
        }

        public override string  ToString()
        {
            float ivaPrice = GetIvaPrice();
            string ivaPriceString = ivaPrice.ToString("N2");
            string codeFormattedToString = GetCodeFormattedToString(this.code);
            string  info =$"Product Name: {commercialName}\nIDcode: {codeFormattedToString} \nDescription: {description} \nBy the price of: {ivaPriceString} Euro\n";
                 return info;
        }

        public float GetIvaPrice()
        {
            float ivaPrice = price + (price * iva) / 100;
            return ivaPrice;
        }
       
        public string GetCodeFormattedToString(int code)
        {
            string codeFormattedToString = code.ToString("D8");
            return codeFormattedToString;
        }
    }
}