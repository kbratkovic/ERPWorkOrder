using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository;

public interface IClientRepository
{
    IQueryable<ClientModel> Clients { get; }

    void CreateClient(ClientModel client);
    void SaveClient(ClientModel client);
    void DeleteClient(ClientModel client);
}
