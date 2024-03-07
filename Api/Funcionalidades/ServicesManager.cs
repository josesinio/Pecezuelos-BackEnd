using Api.Funcionalidades.Carritos;
using Api.Funcionalidades.Clientes;
using Api.Funcionalidades.Comentarios;
using Api.Funcionalidades.Productos;
using Api.Funcionalidades.Promociones;
using Api.Funcionalidades.Vendedores;

namespace Api.Funcionalidades;

public static class  ServicesManager
{
    public static IServiceCollection AddServiceManager (this IServiceCollection services){
        services.AddSingleton<ICarritoService, CarritoService>();
        services.AddSingleton<IClienteService, ClienteService>();
        services.AddSingleton<IComentarioService, ComentarioService>();
        services.AddSingleton<IProductoService, ProductoService>();
        services.AddSingleton<IPromocionService, PromocionService>();
        services.AddSingleton<IVendedorService, VendedorService>();

        return services;
    }
}
