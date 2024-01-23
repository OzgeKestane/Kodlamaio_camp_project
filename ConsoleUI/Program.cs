
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
//Data Transformation Object - DTO
//SOLID 
//Open Closed Principle: Yeni bir özellik eklendiğinde mevcuttaki hiç bir koda dokunamazsın.
//ProductTest();
//CategoryTest();

ProductManager productManager = new ProductManager(new EfProductDal());
var result = productManager.GetProductDetails();
if (result.Success)
{
    foreach (var product in result.Data)
    {
        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    }
}
else
{
    Console.WriteLine(result.Message);
}


//static void ProductTest()
//{
//    ProductManager productManager = new ProductManager(new EfProductDal());

//    foreach (var product in productManager.GetAllByCategoryId(2))
//    {
//        Console.WriteLine(product.ProductName);
//    }
//    Console.WriteLine("------");
//    foreach (var product in productManager.GetByUnitPrice(40, 100))
//    {
//        Console.WriteLine(product.ProductName);
//    }
//}

//static void CategoryTest()
//{
//    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
//    foreach (var category in categoryManager.GetAll())
//    {
//        Console.WriteLine(category.CategoryName);
//    }
//}