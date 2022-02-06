namespace API.Core.DbModels
{
    public class Product: BaseEntity
    {
        public ProductBrand Brand { get; set; }
        public int BrandId { get; set; }
        public ProductType Type { get; set; }
        public int TypeId { get; set; }
    }
}
