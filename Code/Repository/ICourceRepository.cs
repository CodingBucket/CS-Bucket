using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace Queries.Core.Repositories
namespace ConsoleApp.Repository
{
    public interface ICourseRepository: IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCources(int count);
        IEnumerable<Cource> GetCourcesWithAuthors(int pageIndex, int pageSize);
    }
}
