namespace DeliveryBread.Models;

/// <summary>
/// Водитель
/// </summary>
public class Driver : BaseEntity
{
    /// <summary>
    /// Полное имя
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Машина
    /// </summary>
    public Car Car { get; set; }

    /// <summary>
    /// Логин
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; }

}
