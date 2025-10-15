using BarberBoss.Communication.Enums;

namespace BarberBoss.Communication.Requests;
public class RequestBillingJson
{
    public string BarberName { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public string ServiceName { get; set; } = string.Empty;
    public string? Notes { get; set; }
    public DateTime Date { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public decimal Amount { get; set; }
    public Status Status { get; set; }
}
