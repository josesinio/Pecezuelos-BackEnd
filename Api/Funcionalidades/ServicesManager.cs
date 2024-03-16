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
        services.AddScoped<ICarritoService, CarritoService>();
        services.AddScoped<IClienteService, ClienteService>();
        services.AddScoped<IComentarioService, ComentarioService>();
        services.AddScoped<IProductoService, ProductoService>();
        services.AddScoped<IPromocionService, PromocionService>();
        services.AddScoped<IVendedorService, VendedorService>();

        return services;
    }
}
