using System.Collections.Generic;
using System.Threading.Tasks;
using Sunshine.UWP.Models;

namespace Sunshine.UWP.Services
{
    public interface IApiService
    {
        Task<IReadOnlyCollection<Previsao>> ListarPrevisoes();
    }
}