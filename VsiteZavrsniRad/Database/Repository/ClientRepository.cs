using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository;

public class ClientRepository : IClientRepository
{
    private ZavrsniRadDbContext _dbContext;

    public ClientRepository(ZavrsniRadDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<ClientModel> Clients => _dbContext.Clients;



    public void CreateClient(ClientModel client)
    {
        throw new NotImplementedException();
    }

    public void DeleteClient(ClientModel client)
    {
        throw new NotImplementedException();
    }

    public void SaveClient(ClientModel client)
    {
        throw new NotImplementedException();
    }
}
