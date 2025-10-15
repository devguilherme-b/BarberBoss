﻿using BarberBoss.Domain.Enums;

namespace BarberBoss.Domain.Entities;
public class Billing
{
    public Guid Id { get; set; }
    public string BarberName { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public string ServiceName { get; set; } = string.Empty;
    public string? Notes { get; set; }
    public DateTime Date { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public decimal Amount { get; set; }
    public Status Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }
}
