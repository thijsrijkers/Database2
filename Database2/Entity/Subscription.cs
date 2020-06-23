using System;
using System.Collections.Generic;
using System.Text;

namespace Database2
{
    public class Subscription
    {
        public int SubscriptionID { get; set; }
        public String SubscriptionType { get; set; }
        public Double SubscriptionPrice { get; set; }
        public DateTime SubscriptionTime { get; set; }
        public int UserID { get; set; }
    }
}
