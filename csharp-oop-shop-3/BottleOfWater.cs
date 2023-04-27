using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3
{
    public class BottleOfWater : Product
    {
        //ATTRIBUTES

        private float bottleCapacity;
        private float pH;
        private string waterSource;

        //CONSTRUCTOR
        public BottleOfWater( string commercialName, string description, float price, float iva, Category categoryName, float bottleCapacity, float pH, string waterSource) 
                         :base(commercialName,  description,  price,  iva,  categoryName)
        {
            if(pH < 6.5f ||pH > 9.5f)
            {
                throw new ArgumentException("Water must have a pH in a range of 6.5-9.5 to be drinkable", "pH");
            }
            this.waterSource = waterSource;
            this.pH = pH;
            SetBottleCapacity(bottleCapacity);
            this.remainingWater = bottleCapacity;
            this.open = false;

        }

        //STATES
        private bool open;
        private float remainingWater;
        public float RemainingWater
        {
            get { return this.remainingWater; }
        }

        //SETTERS 
        public void  SetBottleCapacity( float bottleCapacity )
        {
            if ( bottleCapacity < 0 || bottleCapacity>1.5)
            {
                this.bottleCapacity = 1.5f;
            }
            else { this.bottleCapacity = bottleCapacity; }
        }
        public void openBottle()
        {
            if (open) 
            {
                Console.WriteLine("The bottle is already open");
            } 
            else 
            { 
            this.open = true; 
            }

        }

        public void closeBottle()
        {
            if (!open)
            {
                Console.WriteLine("The bottle is already closed");
            }
            else
            {
                this.open = false;
            }
        }

        //GETTERS
        public bool isBottleOpen()
        {
            return this.open;
        }
        public string GetBottleState()
        {
            string bottleState = "";
            if (open) 
            {
                bottleState = "The bottle is open.";
            }
            else
            {
                bottleState = "The bottle is closed";
            }

            return bottleState;
        }



        //METHODS
        public override string ToString()
        {
            string info = base.ToString();
            info += $"Bottle Size: {bottleCapacity} L \n";
            return info;
        }

        public void refillBottle(float amountToRefill)
        {
            if (remainingWater == bottleCapacity)
            {
                Console.WriteLine("The bottle is already full"); 
            }
            else if (open)//REFILL ONLY IF OPEN
                {
                    if (amountToRefill > 0)
                    {
                        if (remainingWater + amountToRefill > bottleCapacity)
                        {
                            Console.WriteLine("You used too much water, but your bottle is full");
                            remainingWater = bottleCapacity;
                        }else
                            {
                            remainingWater += amountToRefill;
                            }
                       
                    }else { Console.WriteLine("Not much sense, can try .emptyBottle or .removeWaterFromBottle instead"); }

            }else { Console.WriteLine("Should open the bottle first"); }
        }
            

        public void removeWaterFromBottle(float amountToRemove)
        {
            if (remainingWater == 0)
            {
                Console.WriteLine("The bottle is already empty");
            }
            else if (open)//REMOVE ONLY IF OPEN
            {
                if (amountToRemove > 0)
                {
                    if (remainingWater - amountToRemove < 0)
                    {
                        Console.WriteLine("There wasn't that much water, but your bottle is empty anyway");
                        remainingWater = 0;
                    }
                    else
                    {
                        remainingWater -= amountToRemove;
                    }

                }
                else { Console.WriteLine("Not much sense, can try .refillBottle instead"); }

            }
            else { Console.WriteLine("Should open the bottle first"); }
        }
        public void emptyBottle()
        {
            if (open)
            {
                remainingWater = 0;
            }
            else { Console.WriteLine("Should open the bottle first"); }
        }
    }
}
