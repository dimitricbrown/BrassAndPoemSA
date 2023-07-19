
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "French Horn",
        Price = 200,
        ProductIdType = 1
    },

    new Product()
    {
        Name = "Trombone",
        Price = 200,
        ProductIdType = 1
    },

    new Product()
    {
        Name = "Tuba",
        Price = 200,
        ProductIdType = 1
    },

    new Product()
    {
        Name = "Milk and Honey",
        Price = 15,
        ProductIdType = 2
    },

    new Product()
    {
        Name = "Above Ground", 
        Price = 15,
        ProductIdType = 2
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List.
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass",
        Id = 1,
    },

    new ProductType()
    {
        Title = "Poem",
        Id = 2,
    }
};

//put your greeting here
string greeting = @"Welcome to Brass & Poem!
Your one-stop shop for blissful poetry books and new/used brass musical instruments!";

Console.WriteLine(greeting);


//implement your loop here
Console.WriteLine("Please choose an option: ");


int response = int.Parse(Console.ReadLine().Trim()); // This will prompt the user to input a number

while (response < 5)
{
    Console.WriteLine("Please choose an option: ");
    response = int.Parse(Console.ReadLine().Trim());
}

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }