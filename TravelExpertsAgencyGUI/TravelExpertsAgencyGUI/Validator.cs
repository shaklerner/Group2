using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsAgencyGUI
{
    public static class Validator
    {
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text == "" || String.IsNullOrWhiteSpace(textBox.Text) )
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " is required.");
                textBox.Focus();
            }
            return isValid;
        }

        public static bool IsValidProductName(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text.Length > 50)
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " must be less than 50 characters.");
                textBox.Focus();
            }
            return isValid;
        }

        public static bool IsValidSupplierName(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text.Length > 255)
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " must be less than 255 characters.");
                textBox.Focus();
            }
            return isValid;
        }

        public static bool IsValidPackageName(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text.Length > 50)
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " must be less than 50 characters.");
                textBox.Focus();
            }
            return isValid;
        }

        public static bool IsValidEndDate(DateTimePicker startDate, DateTimePicker endDate)
        {
            bool isValid = true;
            if (DateTime.Compare(startDate.Value, endDate.Value) >= 0)
            {
                isValid = false;
                MessageBox.Show(endDate.Tag + " must be after " + startDate.Tag);
            }
            return !isValid;
        }

        public static bool IsValidDescription(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text.Length > 50)
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " must be less than 50 characters.");
                textBox.Focus();
            }
            return isValid;
        }

        public static bool isValidDecimal(TextBox textBox)
        {
            bool isValid = true;
            decimal value;
            if (!Decimal.TryParse(textBox.Text, out value))
            {
                isValid = false;
                MessageBox.Show("Invalid " + textBox.Tag + " value.");
                textBox.Focus();
            }
            return isValid;
        }

        public static bool isPositiveDecimal(TextBox textBox)
        {
            bool isValid = true;
            if (Convert.ToDecimal(textBox.Text) < 0)
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " cannot be negative.");
            }
            return isValid;
        }

        public static bool isValidCommissionValue(TextBox basePrice, TextBox commission)
        {
            bool isValid = true;
            if(Convert.ToDecimal(commission.Text) > Convert.ToDecimal(basePrice))
            {
                isValid |= false;
                MessageBox.Show("Commission cannot be greater than base price.");
            }
            return isValid;
        }


    }
}
