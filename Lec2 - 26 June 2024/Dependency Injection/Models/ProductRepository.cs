namespace WebApplication6.Models
{
    public class ProductRepository : IProductService
    {

        public string GetData() { 
        Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
    }
}
