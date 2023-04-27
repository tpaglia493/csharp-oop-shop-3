using csharp_oop_shop_3;

 //CATEGORIES
        //Category dress = new Category("Dress", "Something you wear");
        //Category furniture = new Category("Furniture", "Basic furnitures for every house");
        //Category tool = new Category("Tool", "You can use it to do things");
        //Category book = new Category("Book", "Can use it to read");
Category food = new Category("Food", "Something you eat");
Category beverage = new Category("Beverage", "something you drink");

//GENERAL PRODUCTS 
//Product acquaLeteBottled = new Product("Acqua Lete", "It's a very good water", 1.00f, 15.00f, beverage);
//Product product2 = new Product("Chair", "It's a chair", 25.00f, 22.00f, furniture);
//Product product3 = new Product("Spoon", "It's a spoon", 2.00f, 22.00f, tool);
//Product product4 = new Product("Expensive dress", "It's an expensive dress", 900.00f, 22.00f, dress);

//SPECIFIC PRODUCTS
BottleOfWater acquaLeteBigBottle = new BottleOfWater("Acqua Lete", "Just a bit of sodium", 1.00f, 17.00f, beverage, 1.0f, 7.2f, "A source");
BagOfFruits bagOfFragole = new BagOfFruits("Strawberry Bag", "A bag full of strawberries", food, "Strawberry", 4, 0.75f);

//CREATING LIST OF PRODUCTS (INVENTORIES)
//List<Product> inventoryBeverages = new List<Product>();
//List<Product> inventoryFoods = new List<Product>();
//List<Product> inventoryTools = new List<Product>();
//List<Product> inventoryFurnitures = new List<Product>();

//CARTS
PhisicalShopCart firstCart = new PhisicalShopCart(15);
PhisicalShopCart secondCart = new PhisicalShopCart(15);
PhisicalShopCart thirdCart = new PhisicalShopCart(15);

//SHOPS
Shop test1 = new Shop("fake name", "fake city", "fake street", 1234);

//ADDING SINGLE PRODUCT TO LIST OF PRODUCTS OF SHOP NAMED test1
test1.AddSingleProductToProducts(acquaLeteBigBottle);
test1.AddSingleProductToProducts(bagOfFragole);

//CONCATENATE LIST TO SHOP LIST
//.ConcatListToProducts(inventory);

firstCart.AddProduct(bagOfFragole);
firstCart.AddProduct(acquaLeteBigBottle);

Console.WriteLine($"There are {PhisicalShopCart.GetNumberOfCarts()} carts now");


//MAIN PROGRAM (TESTS)

try { 
foreach (Product anyProduct  in test1.products)
{

    string info = anyProduct.GetCategory().ToString();
    info += anyProduct.ToString();
    Console.WriteLine(info);
}


//la bottiglia nasce chiusa

//provo a riempire la bottiglia
Console.WriteLine("Refill the bottle");
acquaLeteBigBottle.refillBottle(1.5f);


//chiedo se la bottiglia è aperta
Console.WriteLine("Is the bottle open?");
Console.WriteLine(acquaLeteBigBottle.GetBottleState());

//apro la bottiglia
Console.WriteLine("Open the bottle");
acquaLeteBigBottle.openBottle();

//tolgo un po' d'acqua
Console.WriteLine("Remove some water");
acquaLeteBigBottle.removeWaterFromBottle(1.0f);

//chiudo la bottiglia
Console.WriteLine("Close the bottle");
acquaLeteBigBottle.closeBottle();

//chiedo quanta acqua rimane
Console.WriteLine($"There are now {acquaLeteBigBottle.RemainingWater} L of water in the bottle");

//chiedo se la bottiglia è aperta
Console.WriteLine("Is the bottle open?");
Console.WriteLine(acquaLeteBigBottle.GetBottleState());

//provo a riempire la bottiglia
Console.WriteLine("Refill the bottle");
acquaLeteBigBottle.refillBottle(1.5f);

//chiedo quanta acqua rimane
Console.WriteLine($"There are now {acquaLeteBigBottle.RemainingWater} L of water in the bottle");

//apro la bottiglia
Console.WriteLine("Open the bottle");
acquaLeteBigBottle.openBottle();

//apro la bottiglia
Console.WriteLine("Open the bottle");
acquaLeteBigBottle.openBottle();

//provo a riempire la bottiglia
Console.WriteLine("Refill the bottle");
acquaLeteBigBottle.refillBottle(1.5f);

//chiedo quanta acqua rimane
Console.WriteLine($"There are now {acquaLeteBigBottle.RemainingWater} L of water in the bottle");


//chiedo se la bottiglia è aperta
Console.WriteLine("Is the bottle open?");
Console.WriteLine(acquaLeteBigBottle.GetBottleState());

//chiudo la bottiglia
Console.WriteLine("Close the bottle");
acquaLeteBigBottle.closeBottle();
    //chiedo se la bottiglia è aperta
Console.WriteLine("Is the bottle open?");
Console.WriteLine(acquaLeteBigBottle.GetBottleState());

}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
    Console.WriteLine("Please close the program and fix the problem");
}