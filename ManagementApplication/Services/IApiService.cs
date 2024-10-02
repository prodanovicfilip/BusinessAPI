
namespace ManagementApplication.Services
{
    public interface IApiService
    {
        Task Create<T>(T value, string fieldName);
        Task Delete<T>(int id, string fieldName);
        Task<IEnumerable<T>> GetAll<T>(string fieldName);
        Task<T> GetById<T>(int id, string fieldName);
        Task<T> Update<T>(int id, T value, string fieldName);
    }
}