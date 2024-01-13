using Entities.Abstract;

namespace Entities.Concrete
{ //bir classın default berişim belirteci internal'dır. sadece o katman erişebilir. 
    //public: diğer katmanların erişimine açık
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
