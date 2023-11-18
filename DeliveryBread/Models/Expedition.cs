namespace DeliveryBread.Models
{
    public class Expedition : BaseEntity
    {
        /// <summary>
        /// Водитель
        /// </summary>
        public Driver? Driver { get; set; }

        /// <summary>
        /// Маршруты
        /// </summary>
        public List<Root>? Roots { get; set; }
    }
}
