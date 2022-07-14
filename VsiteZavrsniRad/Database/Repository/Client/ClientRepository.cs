using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository.Client;

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
        _dbContext.Add(client);
        _dbContext.SaveChanges();
    }


    public void SaveClient(ClientModel client)
    {
        _dbContext.SaveChanges();

    }
}
