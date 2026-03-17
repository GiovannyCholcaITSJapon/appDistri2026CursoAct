using app.clientesChGio.dataAccess.context;
using app.clientesChGio.entities.models;

namespace app.clientesChGio.dataAccess.repositories
{
    public class ClienteRepository : CrudGenericService<Cliente>, IClienteRepository
    {
        public ClienteRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            return await InsertEntity(cliente);
        }

        public async Task DeleteCliente(int id)
        {
            await DeleteEntity(id);
        }

        public async Task<Cliente> GetCliente(int id)
        {
           return await SelectEntity(id);
        }

        public async Task<List<Cliente>> GetClientes()
        {
            return await SelectEntitiesAll();
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            await UpdateEntity(cliente);
        }
    }
}
