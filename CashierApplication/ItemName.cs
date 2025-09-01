using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNameSpace

{
    public class Item
    {
        protected string itemName;
        protected double itemPrice;
        protected int itemQuantity;
        private double total_price;

        public Item(string name, double price, int quantity)
        {
            itemName = name;
            itemPrice = price;
            itemQuantity = quantity;
        }

        public virtual double getTotalPrice()
        {
            total_price = itemPrice * itemQuantity;
            return total_price;
        }
        public virtual void setPayment (double amount)
        {
            
        }
    }
    public class DiscountedItem : Item
    {
        private double itemDiscount;
        private double discountedPrice;
        private double paymentAmount;
        private double change;
        

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            itemDiscount = discount;
        }

        public override double getTotalPrice()
        {
           double discount = itemDiscount * 0.01;
           double result = itemPrice * discount;
           discountedPrice = (itemPrice - result) * itemQuantity;
           return discountedPrice;
        }
        public override void setPayment(double amount)
        {
            paymentAmount = amount;
            change = paymentAmount - discountedPrice;
        }
        public double getChange()
        {
            return change;
        }
    }
}
