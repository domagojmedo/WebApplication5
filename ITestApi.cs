using System.Threading.Tasks;
using Refit;

namespace WebApplication5
{
    public interface ITestApi
    {
        [Post("/400")]
        Task<string> Post([Body] TestBody testBody);
    }

    public class TestBody
    {
        public int Number { get; set; }
    }
}
