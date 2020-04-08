﻿using CryptoArbitrage.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoArbitrage.Services.Execution.API.Application.IntegrationEvents.Events
{
    public class ExchangeOrderPartiallyExecutedIntegrationEvent : IntegrationEvent
    {
        public int ExchangeId { get; private set; }
        public string ExchangeOrderId { get; private set; }
        public string BaseCurrency { get; private set; }
        public string QuoteCurrency { get; private set; }
        public decimal QuantityExecuted { get; private set; }
        public decimal Price { get; private set; }
        public decimal CommisionPaid { get; private set; }

        public ExchangeOrderPartiallyExecutedIntegrationEvent(int exchangeId, string exchangeOrderId, string baseCurrency, string quoteCurrency, decimal quantityExecuted, decimal price, decimal commisionPaid)
        {
            ExchangeId = exchangeId;
            ExchangeOrderId = exchangeOrderId;
            BaseCurrency = baseCurrency;
            QuoteCurrency = quoteCurrency;
            QuantityExecuted = quantityExecuted;
            Price = price;
            CommisionPaid = commisionPaid;
        }
    }
}
