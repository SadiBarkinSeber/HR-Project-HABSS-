using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HR_PROJECT.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }


        private string mersisNo;

        public string MersisNo
        {
            get { return mersisNo; }
            set 
            { 
                if (!string.IsNullOrEmpty(value))
                {
                    if (!Regex.IsMatch(value, @"^\d{16}$"))
                    {
                        throw new Exception("Mersis No must be 16 digits.");
                    }
                }
                mersisNo = value;
            }
        }



        private string taxNumber;

        public string TaxNumber
        {
            get { return taxNumber; }
            set 
            { 
                if (!string.IsNullOrEmpty (value))
                {
                    if (!Regex.IsMatch(value, @"^\d{10}$"))
                    {
                        throw new Exception("Tax number must be 10 digits.");
                    }
                } 
                taxNumber = value;
            }
        }

        public string TaxDepartment { get; set; }
        public string PhoneNumber { get; set; }
        public string LogoImagePath { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int EmployeeCount { get; set; }
        public DateTime FoundingDate { get; set; }
        public DateTime DealStartDate { get; set; }


        private DateTime? dealEndDate;

        public DateTime? DealEndDate
        {
            get { return dealEndDate; }
            set 
            { 
                if (value.HasValue && value <= DealStartDate)
                {
                    throw new Exception("Deal end date cannot be equal or lower than the deal start date.");
                }
                dealEndDate = value;
            }
        }

        public bool IsActive { get; set; }

        

    }
}
