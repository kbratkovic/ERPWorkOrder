using VsiteZavrsniRad.Models;

namespace VsiteZavrsniRad.Database.Repository.SparePart;

public interface ISparePartRepository
{
    IQueryable<SparePartModel> SpareParts { get; }

    void CreateSparePart(SparePartModel sparePart);
    void SaveSparePart(SparePartModel sparePart);
    void DeleteSparePart(SparePartModel sparePart);
}
