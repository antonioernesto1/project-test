﻿using System;
using System.Collections.Generic;
using System.Text;
using Aula5.Entities.Enums;

namespace Aula5.Entities {
    class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return Id +
                ", " +
                Moment +
                ", " +
                Status;
        }
    }
}
