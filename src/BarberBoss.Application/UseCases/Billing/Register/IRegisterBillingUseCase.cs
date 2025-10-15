using BarberBoss.Communication.Requests;
using BarberBoss.Communication.Responses;

namespace BarberBoss.Application.UseCases.Billing.Register;
public interface IRegisterBillingUseCase
{
    Task<ResponseRegisterBillingJson> ExecuteAsync(RequestBillingJson request);
}
