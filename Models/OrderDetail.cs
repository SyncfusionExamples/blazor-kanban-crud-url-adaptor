using System;
using System.Collections.Generic;

namespace KanbanWithCRUDUrlAdaptor.Models;

public partial class OrderDetail
{
    public int EmployeeId { get; set; }

    public string? ShipName { get; set; }

    public string? ShipCity { get; set; }
}
