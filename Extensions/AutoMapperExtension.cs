using Final_BLL.Mapper;

namespace CSC336FinalMiraFattal.Extensions
{
    public static class AutoMapperExtension
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));
            return service;
        }
    }
}
