using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Kanban_Crud_UrlAdaptor.Data
{
    public class Order
    {
        [Key]
        public int EmployeeID { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }

    }
}
