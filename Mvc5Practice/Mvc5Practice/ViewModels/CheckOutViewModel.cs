using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5Practice.ViewModels
{
    public class CheckOutViewModel
    {
        public string SelectedPaymentType { set; get; }
        public IEnumerable<SelectItems> PaymentTypes { set; get; }
    }
}