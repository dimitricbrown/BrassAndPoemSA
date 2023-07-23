
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System.Reflection.PortableExecutable;
using System;

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "French Horn",
        Price = 200.00M,
        ProductIdType = 1
    },

    new Product()
    {
        Name = "Trombone",
        Price = 200.00M,
        ProductIdType = 1
    },

    new Product()
    {
        Name = "Tuba",
        Price = 200.00M,
        ProductIdType = 1
    },

    new Product()
    {
        Name = "Milk and Honey",
        Price = 15.00M,
        ProductIdType = 2
    },

    new Product()
    {
        Name = "Above Ground", 
        Price = 15.00M,
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
DisplayMenu();

//implement your loop here
Console.WriteLine("Please choose a menu option: ");
int response = int.Parse(Console.ReadLine().Trim()); // This will prompt the user to input a number

while (response < 5)
{
    if (response == 0)
    {
        Console.WriteLine("Invalid entry!");
    }
    else if (response == 1)
    {
        DisplayAllProducts(products, productTypes);
    }
    else if (response == 2)
    {
        DeleteProduct(products, productTypes);
    }
    else if (response == 3)
    {
        AddProduct(products, productTypes);
    }
    else if (response == 4) 
    {
        UpdateProduct(products, productTypes);
    }

    Console.WriteLine("Please choose another menu option: ");
    response = int.Parse(Console.ReadLine().Trim());
}

Console.WriteLine("Thanks for visiting Brass & Poem! Y'all come back now!");

void DisplayMenu()
{
    string menu = @"
    1. Display all products
    2. Delete a product
    3. Add a new product
    4. Update product properties
    5. Exit";

    Console.WriteLine(menu);
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Products List:");
    for (int i = 0; i < products.Count; i++)
    {
        Product product = products[i];
        // The 'GetProductTypeName' method is called here to fetch the product type name.
        string productTypeName = GetProductTypeName(product.ProductIdType, productTypes);
        Console.WriteLine($"{i + 1}. {product.Name} - ${product.Price}, {productTypeName} Category.");
    }
}

//Two parameters needed: the product type ID and the list of ProductTypes.
string GetProductTypeName(int productTypeId, List<ProductType> productTypes)
{
    // The 'FirstOrDefault' method returns the first matching element or 'null' if not found.
    ProductType productType = productTypes.FirstOrDefault(type => type.Id == productTypeId);

    if (productType != null)
    {
        return productType.Title;
    }
    else
    {
        return "Undefined";
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);    
    Console.WriteLine("Please choose the index of a product that needs to be removed: ");
    int productToRemove = int.Parse(Console.ReadLine().Trim()) - 1;

    if (productToRemove >= 0 && productToRemove < products.Count)
    {
        products.RemoveAt(productToRemove);

        Product chosenProduct = products[productToRemove - 1];
        Console.WriteLine($"You choose to remove {chosenProduct.Name}. Please see the updated Product List below.");
        DisplayAllProducts(products,productTypes);
    }
    else
    {
        Console.WriteLine("Invalid response. You did not make a proper selection.");
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Please enter the product name: ");
    string Name = Console.ReadLine();
    Console.WriteLine("Please enter the product price: ");
    decimal Price = decimal.Parse(Console.ReadLine());
    Console.WriteLine(@"Please enter the index of the choosen product type:
    1. Brass
    2. Poem");
    int Id = int.Parse(Console.ReadLine());

    Product newProduct = new Product() 
    { 
        Name = Name,
        Price = Price, 
        ProductIdType = Id
    };
    products.Add(newProduct);
    Console.WriteLine($"{newProduct.Name} has been added to the product list!. Take a look!");
    DisplayAllProducts(products, productTypes);
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.WriteLine("Please choose the index of a product that needs to be updated: ");
    int productToUpdate = int.Parse(Console.ReadLine().Trim()) - 1;

    Product updatedProduct = products[productToUpdate];
    Console.WriteLine($@"You choose to update {updatedProduct.Name} - ${updatedProduct.Price}, {updatedProduct.ProductIdType} Category.");
    Console.WriteLine("Please enter the updated name: ");
    string updatedName = Console.ReadLine();
    Console.WriteLine("Please enter the updated price: ");
    decimal updatedPrice = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the updated product type: ");
    int updatedId = int.Parse(Console.ReadLine());

    if (!string.IsNullOrEmpty(updatedName))
    {
        updatedProduct.Name = updatedName;
    }
    else
    {
        updatedProduct = products[productToUpdate];
    }
    if (updatedPrice > 0)
    {
        updatedProduct.Price = updatedPrice;
    }
 
    if (updatedId == 1 || updatedId == 2)
    {
        updatedProduct.ProductIdType = updatedId;
    }

    Product productUpdated = new Product()
    {
        Name = updatedProduct.Name,
        Price = updatedProduct.Price,
        ProductIdType = updatedProduct.ProductIdType,
    };

    products[productToUpdate] = productUpdated;

    Console.WriteLine($"{productUpdated.Name} has been updated on the product list!. Take a look!");
    DisplayAllProducts(products, productTypes);
}

// don't move or change this!
public partial class Program { }