using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsAgencyGUI
{
    public static class Validator
    {
        /// <summary>
        /// Checks if text box contains empty string, null, or white space
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true if text is present, false if not</returns>
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
        /// <summary>
        /// Checks if text box contains empty string, null, or white space
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true if text is present, false if not</returns>
        public static bool IsPresent(RichTextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text == "" || String.IsNullOrWhiteSpace(textBox.Text))
            {
                isValid = false;
                MessageBox.Show(textBox.Tag + " is required.");
                textBox.Focus();
            }
            return isValid;
        }




        /// <summary>
        /// Checks whether the text field exceeds allowed character length in database
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true if within allowed character length, false if not</returns>
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

        /// <summary>
        /// Checks whether the text field exceeds allowed character length in database
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true if within allowed character length, false if not</returns>
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

        /// <summary>
        /// Checks whether the text field exceeds allowed character length in database
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true if within allowed character length, false if not</returns>
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

        /// <summary>
        /// Checks whether package end date is after the start date
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>true if end date is greater than start date, false if not</returns>
        public static bool IsValidEndDate(DateTimePicker startDate, DateTimePicker endDate)
        {
            bool isValid = true;
            if (DateTime.Compare(startDate.Value, endDate.Value) >= 0)
            {
                isValid = false;
                MessageBox.Show(endDate.Tag + " must be after " + startDate.Tag);
            }
            return isValid;
        }

        /// <summary>
        /// Checks whether the text field exceeds allowed character length in database
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true if within allowed character length, false if not</returns>
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

        /// <summary>
        /// Checks whether the textbox contains a valid decimal
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true if valid, false if not</returns>
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

        /// <summary>
        /// Checks whether a textbox contains a valid positive decimal
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>true if positive, false if not</returns>
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

        /// <summary>
        /// Checks whether base price is greater than commission or not
        /// </summary>
        /// <param name="basePrice"></param>
        /// <param name="commission"></param>
        /// <returns>true if base price is greater than commission, false if not</returns>
        public static bool isValidCommissionValue(TextBox basePrice, TextBox commission)
        {
            bool isValid = false;
            decimal commresult;
            decimal result;
            decimal.TryParse(commission.Text, out commresult);
            decimal.TryParse(basePrice.Text, out result);
            if ((commresult <= result) && decimal.TryParse(commission.Text, out commresult) && decimal.TryParse(basePrice.Text, out result))
            {
                isValid = true;
                
            }
            else
            {
                MessageBox.Show("Commission cannot be greater than base price.");
            }
            
            return isValid;
        }


    }
}
