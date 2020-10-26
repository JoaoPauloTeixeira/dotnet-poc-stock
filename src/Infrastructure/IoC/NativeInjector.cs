using Microsoft.Extensions.DependencyInjection;

namespace src.Infrastructure.IoC
{
    public class NativeInjector
    {
        // os métodos dessa classe servem para fazer a injeção de dependencias
        // pode ser seu repository, ou um service, ou qlq outra coisa
        // o legal é fazer um método para cada coisa
        // como exemplo vou deixar um RegisterData para os repositories
        // mas pode ser por exemplo RegisterAdapters...
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterData(services);
        }

        public static void RegisterData(IServiceCollection services)
        {
            // esse método é onde vc injeta os seus repositories
            // vou deixar esse aqui comentado só de exemplo
            // services.AddScoped<IUserRespository, UserRepository>();
        }

    }
}