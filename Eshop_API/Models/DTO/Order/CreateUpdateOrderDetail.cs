using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_api.Models.DTO.Order
{
    public class CreateUpdateOrderDetail
    {
        public Guid idOrder{get; set;}
        public int ProductId{get;set;}
        public int Quantity{get;set;}
        public string Note{get;set;}
    }
}