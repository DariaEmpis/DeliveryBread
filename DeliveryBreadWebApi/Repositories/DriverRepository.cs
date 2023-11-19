using DeliveryBreadWebApi.Data;
using DeliveryBreadWebApi.Models;
using DeliveryBreadWebApi.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace DeliveryBreadWebApi.Repositories;

public class DriverRepository
{
    private readonly ApplicationDbContext _dbContext;
    public DriverRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Result<List<Root>>> GetRootsForDriver(int driverId)
    {
        try
        {
            var roots = await _dbContext.Roots.Where(x => x.Expedition.Driver.Id == driverId).ToListAsync();
            return new Result<List<Root>> { IsSuccess = true, Object = roots };
        }
        catch (Exception ex)
        {
            return new Result<List<Root>> { IsSuccess = false, Message = ex.Message };
        }
    }
}
