using System.Threading.Tasks;

namespace WebAPI.interfaces
{
    public interface IUnitOfWork
    {
        ICityRepository CityRepository { get; }
        IUserRepository UserRepository { get; }
        IPropertyRepository PorpertyRepository { get; }
        IPropertyTypeRepository PorpertyTypeRepository { get; }
        IFurnishingTypeRepository FurnishingTypeRepository { get; }
        Task<bool> SaveAsync();
    }
}