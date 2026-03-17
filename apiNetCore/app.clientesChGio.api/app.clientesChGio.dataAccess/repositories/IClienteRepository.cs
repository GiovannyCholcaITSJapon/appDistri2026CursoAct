using app.clientesChGio.entities.models;

namespace app.clientesChGio.dataAccess.repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> GetCliente(int id);

        Task<Cliente> CreateCliente(Cliente cliente);

        Task<List<Cliente>> GetClientes();

        Task UpdateCliente(Cliente cliente);

        Task DeleteCliente(int id);

    }
}
