using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository.Client;

public interface IClientRepository
{
    IQueryable<ClientModel> Clients { get; }

    void CreateClient(ClientModel client);
    void SaveClient(ClientModel client);
}
