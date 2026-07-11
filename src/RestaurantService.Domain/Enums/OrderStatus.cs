using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantService.Domain.Enums;

public enum OrderStatus
{
    NONE = 0,
    PENDING_APPROVAL = 1,
    APPROVAL = 2,
    PREPARING = 3,
    READY_FOR_PEAKUP = 4,
    DELIEVERED = 5,
    DELAYED = 6,
    CANCELLED = 7,
}
