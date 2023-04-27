using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3
{
    public class BagOfFruits : Product
    {//ATTRIBUTES
        private string fruitName;
        private int numberOfPieces;
        private float pricePerPiece;

        //CONSTRUCTOR
        public BagOfFruits(string commercialName, string description, Category categoryName, string fruitName, int numberOfPieces, float pricePerPiece)
            : base(commercialName, description, categoryName)
        {
            this.fruitName = fruitName;
            this.numberOfPieces = numberOfPieces;
            this.pricePerPiece = pricePerPiece;
            SetTotalPrice(pricePerPiece,numberOfPieces);
        }
        //METHODS
        public void SetTotalPrice(float pricePerPiece, int numberOfPieces)
        {
            float price = pricePerPiece * numberOfPieces;
            base.Price = price;
        }
        public override string ToString()
        {
            string info = base.ToString();
            info += $"A bag of {fruitName}  \n";
            info += $"There are {numberOfPieces} pieces  \n";
            return info;
        }




    }
}
