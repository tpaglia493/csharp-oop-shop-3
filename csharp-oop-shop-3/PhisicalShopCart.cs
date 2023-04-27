using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3
{
	internal class PhisicalShopCart
	{
		private static int  numberOfCartsCounter= 0;
		private List<Product> productsInCart;
		private int maxProductsInCart;

		// COSTRUTTORE
		public PhisicalShopCart(int maxProductsInCart)
		{
			this.maxProductsInCart = maxProductsInCart;
			this.productsInCart = new List<Product>();
			numberOfCartsCounter++;
		}

		// GETTERS
		public List<Product> GetProductListInsideCart()
		{
			return this.productsInCart;
		}
		public static int GetNumberOfCarts()
		{
			return numberOfCartsCounter;
		}

		// SETTERS

		// METHODS
		public int GetNUmbersOfProductsInCart()
		{
			return productsInCart.Count;
		}

		public void AddProduct(Product newProduct)
		{
			if (productsInCart.Count < maxProductsInCart)
			{
				this.productsInCart.Add(newProduct);
			} else
			{
				Console.WriteLine("Il carrello è pieno!");
			}
		}

		public void EmptyCart()
		{
			this.productsInCart.Clear();
		}

		public override string ToString()
		{
			string stringa = "--------- CARRELLO DELLA SPESA ---------\n";
			for (int i=0; i<this.productsInCart.Count; i++)
			{
				stringa += $"PRODOTTO {i+1}:\n";
				Product prodottoEstratto = productsInCart[i];

				
					stringa += prodottoEstratto.ToString();
				

				stringa += "\n";
			}
			stringa += "---------------------------------";

			return stringa;
		}
	}
}
