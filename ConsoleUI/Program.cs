
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

//SOLID 
//Open Closed Principle: Yeni bir özellik eklendiğinde mevcuttaki hiç bir koda dokunamazsın.

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetAllByCategoryId(2))
{
    Console.WriteLine(product.ProductName);
}
Console.WriteLine("------");
foreach (var product in productManager.GetByUnitPrice(40, 100))
{
    Console.WriteLine(product.ProductName);
}

