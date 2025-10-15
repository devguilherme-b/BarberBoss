using BarberBoss.Communication.Requests;
using BarberBoss.Communication.Responses;

namespace BarberBoss.Application.UseCases.Billing.Register;
public class RegisterBillingUseCase : IRegisterBillingUseCase
{
    public async Task<ResponseRegisterBillingJson> ExecuteAsync(RequestBillingJson request)
    {
        return await Task.FromResult(new ResponseRegisterBillingJson
        {
            ServiceName = request.ServiceName,
            Amount = request.Amount,
            Date = request.Date,
        });
    }
}
