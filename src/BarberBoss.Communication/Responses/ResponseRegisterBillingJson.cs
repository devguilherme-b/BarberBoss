namespace BarberBoss.Communication.Responses;
public class ResponseRegisterBillingJson
{
    public string ServiceName { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public int paymentMethod { get; set; }
    public decimal Amount { get; set; }
    public int Status { get; set; }
}
