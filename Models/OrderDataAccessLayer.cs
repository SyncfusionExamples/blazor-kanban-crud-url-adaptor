using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KanbanWithCRUDUrlAdaptor.Models
{
    public class OrderDataAccessLayer
    {
        OrderContext db = new OrderContext();

        //To Get all Orders details   
        public DbSet<OrderDetail> GetAllOrders()
        {
            try
            {
                return db.OrderDetails;
            }
            catch
            {
                throw;
            }
        }

       // To Add new Order record
        public void AddOrder(OrderDetail Order)
        {
            try
            {
                db.OrderDetails.Add(Order);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particular Order    
        public void UpdateOrder(OrderDetail Order)
        {
            try
            {
                db.Entry(Order).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Order    
        public OrderDetail GetOrderData(int id)
        {
            try
            {
                OrderDetail Order = db.OrderDetails.Find(id);
                return Order;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Order    
        public void DeleteOrder(int data)
        {
            try
            {
                db.OrderDetails.Remove(db.OrderDetails.Where(or => or.EmployeeId == data).FirstOrDefault());
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
