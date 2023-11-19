using DeliveryBreadWebApi.Data;
using DeliveryBreadWebApi.Models;
using DeliveryBreadWebApi.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace DeliveryBreadWebApi.Repositories;

public class ExpeditionsRepository
{
    private readonly ApplicationDbContext _dbContext;
    public ExpeditionsRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Result> CreateExpedition(ExpeditionDto expeditionDto)
    {
        try
        {
            var driver = await _dbContext.Drivers.FirstOrDefaultAsync(x => x.Id == expeditionDto.DriverId);
            if (driver == null)
            {
                throw new ArgumentNullException("Водитель не найден");
            }

            var expedition = new Expedition
            {
                Driver = driver,
                Roots = expeditionDto.Roots,
            };

            await _dbContext.Expeditions.AddAsync(expedition);
            await _dbContext.SaveChangesAsync();
            return new Result { IsSuccess = true };
        } 
        catch (Exception ex)
        {
            return new Result { IsSuccess = false, Message = ex.Message};
        }
    }
}
