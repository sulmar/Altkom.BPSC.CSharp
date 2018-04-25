namespace BPSC.CSharp.Shop.Models
{
    public class Product : Item
    {
        public string Color { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} Color: {Color}";
        }
    }
}
