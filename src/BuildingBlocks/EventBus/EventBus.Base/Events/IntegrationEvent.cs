﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Events
{
    public class IntegrationEvent
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public IntegrationEvent() 
        {
            Id = Guid.NewGuid();

            CreateDate = DateTime.Now;
        }

        public IntegrationEvent(Guid id, DateTime createDate)
        {
            Id = id;

            CreateDate = createDate;
        }

    }
}
