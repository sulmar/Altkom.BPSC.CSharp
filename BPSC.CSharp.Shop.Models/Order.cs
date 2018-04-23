using System;
using System.Collections.Generic;

namespace BPSC.CSharp.Shop.Models
{
    public class Order
    {
        public int Id { get; set; }

        #region
        //public void SetOrderDate(DateTime orderDate)
        //{
        //    this.orderDate = orderDate;
        //}

        //public DateTime GetOrderDate()
        //{
        //    return this.orderDate;
        //}

        #endregion

        // backfield
        private DateTime orderDate;

        // Właściwość (property)
        public DateTime OrderDate
        {
            get
            {
                return this.orderDate;
            }

            set
            {
                this.orderDate = value;
            }
        }

        public string OrderNumber { get; set;  }
        public DateTime? DeliveryDate { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> Details { get; set; }
    }
}
