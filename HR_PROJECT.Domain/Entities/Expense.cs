using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Domain.Entities
{
    public class Expense
    {
        public Expense()
        {
            IsApproved = false;
            IsCancelled = false;
        }

        public int Id { get; set; }
        private string expenseType;

        public string ExpenseType
        {
            get { return expenseType; }
            set 
            { 
                // Validation
                if (value == "İş Seyahatleri" || value == "Ofis Malzemeleri" || value == "Eğitim ve Gelişim" || value == "Reklam ve Pazarlama" || value == "İş İlişkileri" || value == "Personel Harcamaları")
                {
                    expenseType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid expense type.");
                }
            }
        }

        public decimal Amount { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime RequestDate { get; set; }
        public string? Response { get; set; }
        private string currency;

        public string Currency
        {
            get { return currency; }
            set 
            { 
                // Validation
                if (value == "TL" || value == "USD" || value == "EUR")
                {
                    currency = value;
                }
                else
                {
                    throw new ArgumentException("Invalid advance type. Accepted values are TL, EUR or USD");
                }
            }
        }

        public bool IsApproved { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string? FileName { get; set; }
        public decimal? AmountValue { get; set; }
        public bool IsCancelled { get; set; }
    }
}
