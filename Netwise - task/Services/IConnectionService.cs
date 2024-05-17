namespace Netwise___task.Services
{
    public interface IConnectionService
    {
        Task<string?> GetFromApiAsync(string apiURL);
    }
}