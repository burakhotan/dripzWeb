namespace shopapp.webui.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool isApproved { get; set; }
        public string Image {get; set; }
    }
}