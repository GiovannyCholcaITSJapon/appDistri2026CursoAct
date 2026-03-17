using app.clientesChGio.common.DTOs;
using app.clientesChGio.services.Interfaces;

namespace app.clientesChGio.services.Implementations
{
    public class ClienteService : IClienteService
    {

        public Task<BaseResponse<ClienteDTO>> ActualizarCliente(int id, ClienteDTO cliente)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<ClienteDTO>> CrearCliente(ClienteDTO clienteDTO)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<string>> EliminarCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<ClienteDTO>> ObtenerCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<List<ClienteDTO>>> ObtenerClientes()
        {
            throw new NotImplementedException();
        }
    }
}
