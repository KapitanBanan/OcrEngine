
namespace TextScan
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public int CostsId { get; set; }
        public Costs Costs { get; set; }
    }
}
