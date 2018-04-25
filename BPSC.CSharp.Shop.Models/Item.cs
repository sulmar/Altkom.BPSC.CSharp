namespace BPSC.CSharp.Shop.Models
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public decimal UnitPrice { get; set; }


        public override string ToString()
        {
            return $"Name: {this.Name} Code: {this.Code}";
        }
    }
}
