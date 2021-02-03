using System.Threading.Tasks;
using Refit;

namespace Consulta_de_cep
{
    public interface CepService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAdderessAsync(string cep);
    }
}
