namespace Composite.DAL
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int UpperCategoryId { get; set; }
        public List<Product> Products { get; set; }
    }
}
