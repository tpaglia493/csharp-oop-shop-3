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
            this.waterSource = waterSource;
            try
            {
                SetpH(pH);
            }
            catch(ArgumentException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please insert the correct value for pH:");
                float correctedpH= float.Parse(Console.ReadLine());
                SetpH(correctedpH);
            }
            try 
            { 
                SetBottleCapacity(bottleCapacity);
            }
            catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please insert the correct value for capacity:");
                    float correctedBottleCapacity = float.Parse(Console.ReadLine());
                    SetBottleCapacity(correctedBottleCapacity);
                }
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

        public void SetpH(float pH)
        {
        if (pH < 6.5f || pH > 9.5f)
            {
            throw new ArgumentException("Water must have a pH in a range of 6.5-9.5 to be drinkable", "pH");
            }
        }
        public void  SetBottleCapacity( float bottleCapacity )
        {
            if ( bottleCapacity < 0 || bottleCapacity>1.5)
            {
                throw new ArgumentException("Bottle capacity must be in a range of 0,25L-1,5L", "bottleCapacity");
            }
            else { this.bottleCapacity = bottleCapacity; }
        }
        public void openBottle()
        {
            if (open) 
            {
                throw new Exception("The bottle is already open");
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
                throw new Exception("The bottle is already closed");
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
                throw new Exception("The bottle is already full"); 
            }
            else if (open)//REFILL ONLY IF OPEN
                {
                    if (amountToRefill > 0)
                    {
                        if (remainingWater + amountToRefill > bottleCapacity)
                        {
                        remainingWater = bottleCapacity;
                        throw new ArgumentException("You used too much water, but your bottle is full", "amountToRefill");
                            
                        }else
                            {
                            remainingWater += amountToRefill;
                            }
                       
                    }else { throw new Exception("Not much sense, can try .emptyBottle or .removeWaterFromBottle instead"); }

            }else { throw new Exception("Should open the bottle first"); }
        }
            

        public void removeWaterFromBottle(float amountToRemove)
        {
            if (remainingWater == 0)
            {
                throw new Exception("The bottle is already empty");
            }
            else if (open)//REMOVE ONLY IF OPEN
            {
                if (amountToRemove > 0)
                {
                    if (remainingWater - amountToRemove < 0)
                    { 
                        remainingWater = 0;
                        throw new ArgumentException("There wasn't that much water, but your bottle is empty anyway");
                       
                    }
                    else
                    {
                        remainingWater -= amountToRemove;
                    }

                }
                else { throw new Exception("Not much sense, can try .refillBottle instead"); }

            }
            else { throw new Exception("Should open the bottle first"); }
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
