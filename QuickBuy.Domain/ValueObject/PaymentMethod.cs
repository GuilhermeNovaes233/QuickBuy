using QuickBuy.Domain.Enums;
using System;

namespace QuickBuy.Domain.ValueObject
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public DateTime OrderData { get; set; }
        public string Description { get; set; }

        public bool IsTicket{
            get { return Id == (int) TypePaymentMethodEnum.Ticket; }
        }
        public bool IsCreditCard
        {
            get { return Id == (int)TypePaymentMethodEnum.CreditCard; }
        }

        public bool IsBankDeposit
        {
            get { return Id == (int)TypePaymentMethodEnum.BankDeposit; }
        }

        public bool IsPix
        {
            get { return Id == (int)TypePaymentMethodEnum.Pix; }
        }

        public bool IsNotDefined
        {
            get { return Id == (int)TypePaymentMethodEnum.NotDefined; }
        }
    }
}