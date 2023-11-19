namespace DeliveryBreadWebApi.Models.Dto;

public class ExpeditionDto
{
    public int DriverId { get; set; }
    
    public List<Root> Roots { get; set; }
}
