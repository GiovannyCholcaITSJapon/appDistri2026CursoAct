using app.clientesChGio.common.DTOs;

namespace app.clientesChGio.services.Interfaces
{
    public interface IClienteService
    {
        Task<BaseResponse<ClienteDTO>> CrearCliente(ClienteDTO clienteDTO);

        Task<BaseResponse<ClienteDTO>> ObtenerCliente(int id);

        Task<BaseResponse<List<ClienteDTO>>> ObtenerClientes();

        Task<BaseResponse<ClienteDTO>> ActualizarCliente(int id, ClienteDTO cliente);

        Task<BaseResponse<string>> EliminarCliente(int id);

    }
}
