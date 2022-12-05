//using Mapster;
//using MapsterMapper;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace Core.Mapper
//{
//    public static class MapperExtentionService
//    {
//        public static IServiceCollection AddMap(this IServiceCollection services)
//        {
//            var config = TypeAdapterConfig.GlobalSettings;
//            config.Scan(Assembly.GetExecutingAssembly());
//            services.AddSingleton(config);
//            services.AddScoped<IMapper, ServiceMapper>();

//            return services;
//        }
//    }
//}
