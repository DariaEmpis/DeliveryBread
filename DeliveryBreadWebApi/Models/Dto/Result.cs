namespace DeliveryBreadWebApi.Models.Dto;

public class Result
{
    public bool IsSuccess { get; set; }
    public string? Message { get; set; }
}

public class Result<T> : Result
{
    public T Object { get; set; }
}
