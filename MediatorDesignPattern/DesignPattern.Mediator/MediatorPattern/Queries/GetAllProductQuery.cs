using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    //Burada IRequest sınıfından miras alıyoruz ve List olarak Queryresult sınıfını veriyoruz.

    //Burası istek sorgumuzun yapıldıgı sınıf.
    public class GetAllProductQuery:IRequest<List<GetAllProductQueryResult>>
    {
    }
}
