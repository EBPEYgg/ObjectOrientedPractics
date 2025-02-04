﻿using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий заказы приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        private string _requestedDeliveryTime;

        /// <summary>
        /// Дата доставки.
        /// </summary>
        private DateTime _requestedDeliveryDate;

        /// <summary>
        /// Возвращает и задает желаемое время доставки.
        /// </summary>
        public string RequestedDeliveryTime
        {
            get => _requestedDeliveryTime;
            set => _requestedDeliveryTime = value;
        }

        /// <summary>
        /// Возвращает и задает дату доставки.
        /// </summary>
        [JsonIgnore]
        public DateTime RequestedDeliveryDate
        {
            get => _requestedDeliveryDate;
            set => _requestedDeliveryDate = value;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="requestedDeliveryTime">Желаемое время доставки.</param>
        /// <param name="requestedDeliveryDate">Дата доставки.</param>
        public PriorityOrder(string requestedDeliveryTime, DateTime requestedDeliveryDate)
        {
            RequestedDeliveryTime = requestedDeliveryTime;
            RequestedDeliveryDate = requestedDeliveryDate;
        }
    }
}