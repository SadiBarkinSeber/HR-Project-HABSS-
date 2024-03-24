
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Domain.Entities
{
    public class Advance
    {

        

        public Advance()
        {
            Permission = false;
            IsCanceled = false;
        }

        public int Id { get; set; }
        public string ApprovalStatus { get; set; }
        public string? Response { get; set; }
        public bool Permission { get; set; }
        public Employee Employee { get; set; }
        private string advanceType;
        public string AdvanceType
        {
            get { return advanceType; }
            set
            {
                // Validation
                if (value == "Bireysel" || value == "Kurumsal")
                {
                    advanceType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid advance type. Accepted values are bireysel or kurumsal.");
                }
            }
        }
        public decimal Amount { get; set; }
        public decimal? AmountValue { get; set; }
        public DateTime RequestDate { get; set; }
        public int EmployeeId { get; set; }
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
                    throw new ArgumentException("Invalid advance type. Accepted values are TL, EUR or USD.");
                }
            }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (value != null && value.Length > 500)
                {
                    throw new ArgumentException("Description exceeds the character limit.");
                }
                else
                {
                    description = value;
                }
            }
        }
        public bool IsCanceled { get; set; }

    }
}
