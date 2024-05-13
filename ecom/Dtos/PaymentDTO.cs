namespace ecom.Dtos
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Method { get; set; }
        public Double Amount { get; set; }
    }
}
