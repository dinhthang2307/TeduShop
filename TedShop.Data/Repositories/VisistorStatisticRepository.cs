using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface IVisistorStatisticRepository
    {
    }

    public class VisistorStatisticRepository : RepositoryBase<VisistorStatistic>, IVisistorStatisticRepository
    {
        public VisistorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}