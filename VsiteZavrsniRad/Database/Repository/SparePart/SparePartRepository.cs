using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository.SparePart;

public class SparePartRepository : ISparePartRepository
{
    private ZavrsniRadDbContext _dbContext;

    public SparePartRepository(ZavrsniRadDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<SparePartModel> SpareParts => _dbContext.SpareParts;



    public void CreateSparePart(SparePartModel sparePart)
    {
        _dbContext.Add(sparePart);
        _dbContext.SaveChanges();
    }


    public void SaveSparePart(SparePartModel sparePart)
    {
        _dbContext.SaveChanges();
    }
}
