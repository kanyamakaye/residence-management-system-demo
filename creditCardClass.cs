namespace ManagementSystem
{
    class CreditCardPaymentService : IPaymentService
{
    public void ProcessPayment(Payment payment)
    {
        Console.WriteLine($"Processed {payment.Amount} credit card payment on {payment.PaymentDate.ToShortDateString()} with type {payment.Type}");
    }
}
}