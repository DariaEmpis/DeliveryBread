using DeliveryBreadWebApi.Data;
using Microsoft.EntityFrameworkCore;

namespace DeliveryBreadWebApi.Repositories;

public class UserAuthRepository
{
    private readonly ApplicationDbContext _dbContext;
    public UserAuthRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> Login(string login, string password)
    {
        var User = await _dbContext.Drivers.FirstOrDefaultAsync(x => x.Login == login && x.Password == password);
        return User != null;
    }
}
