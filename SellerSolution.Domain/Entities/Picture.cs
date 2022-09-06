namespace SellerSolution.Domain.Entities
{
    public class Picture
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Secure_Url { get; set; }
        public string Size { get; set; }
        public string Max_Size { get; set; }
        public string? Quality { get; set; }
    }
}
