namespace DeliveryBreadWebApi.Models;

public class Car : BaseEntity
{
    /// <summary>
    /// Гос номер машины
    /// </summary>
    public string LicencePlate { get; set; }

    /// <summary>
    /// Номер машины в системе
    /// </summary>
    public int CompanyNumber { get; set; }

    /// <summary>
    /// Водитель
    /// </summary>
    public Driver? Driver { get; set; }
}
