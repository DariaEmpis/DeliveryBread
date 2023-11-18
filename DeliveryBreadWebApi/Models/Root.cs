namespace DeliveryBreadWebApi.Models
{
    public class Root : BaseEntity
    {
        /// <summary>
        /// ID гейта
        /// </summary>
        public Gate Gate { get; set; }

        /// <summary>
        /// ID рейса
        /// </summary>
        public Expedition Expedition { get; set; }

        /// <summary>
        /// Время
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public string Status { get; set; }
    }
}
