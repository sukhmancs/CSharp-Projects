/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - Windows form app that determines pricing of hair salon based on the services, client type, and number of visits.
 * I, Sukhmanjeet Singh, 000838215 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */

namespace Lab2B  // Declare a namespace called "Lab2A" to contain the code.
{
    /// <summary>
    /// Define a public class named "Form1" that inherits from a class called "Form."
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor of this class
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for selected index change in the checkedListBox1.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for Hairdresser_enter.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void Hairdresser_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for selected radioButton3.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for selected radioButton2
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for groupbox2_enter
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for radio button laura.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void lauraRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for label1 being clicked.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calculate the total price based on user input and display it.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Check if the clientVisitsTextBox is empty or the entered text is not a valid integer or the value is negative.            
            if (string.IsNullOrEmpty(clientVisitsTextBox.Text) || !int.TryParse(clientVisitsTextBox.Text, out int clientVisits) || clientVisits <= 0)
            {
                // If the condition is true, display an error message.
                MessageBox.Show("Please enter a valid number of visits greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set focus to the clientVisitsTextBox for user input correction.
                clientVisitsTextBox.Focus();

                // Exit the method early since the input is invalid. 
                return; 
            }

            // Check if none of the hairdresser radio buttons is selected.
            if (!(janeRadioButton.Checked || patRadioButton.Checked || ronRadioButton.Checked || sueRadioButton.Checked || lauraRadioButton.Checked))
            {
                // If the condition is true, display an error message.
                MessageBox.Show("Please select a Hairdresser.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Exit the method early since the input is invalid
                return;
            }

            // Check if none of the client type radio buttons is selected.
            if (!(standardAdultRadioButton.Checked || childRadioButton.Checked || studentRadioButton.Checked || seniorRadioButton.Checked))
            {
                // If the condition is true, display an error message.
                MessageBox.Show("Please select at least one client type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Exit the method early since the input is invalid
                return;
            }

            // Check if none of the service checkboxes is checked.
            if (!(cutCheckBox.Checked || colourCheckBox.Checked || highlightsCheckBox.Checked || extensionsCheckBox.Checked))
            {
                // If the condition is true, display an error message.
                MessageBox.Show("Please select at least one service.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Exit the method early since the input is invalid
                return;
            }

            // Calculate the base rate, service cost, discounts, and total price.
            decimal baseRate = GetBaseRate();
            decimal serviceCost = GetServiceCost();
            decimal discount = GetDiscount();
            decimal additonalDiscount = GetAdditionalDiscount();

            decimal totalPrice = (baseRate + serviceCost) - ((baseRate + serviceCost) * (discount + additonalDiscount));  // Calculate total price based on the discount.
            totalPriceLabel.Text = $"Total Price: {totalPrice}";    // Display the total price in the totalPriceLabel.
        }

        /// <summary>
        /// Get the base rate for the selected hairdresser.
        /// </summary>
        /// <returns>The base rate for the selected hairdresser.</returns>
        private decimal GetBaseRate()
        {
            if (janeRadioButton.Checked) return 30m;
            if (patRadioButton.Checked) return 45m;
            if (ronRadioButton.Checked) return 40m;
            if (sueRadioButton.Checked) return 50m;
            if (lauraRadioButton.Checked) return 55m;
            return 0m;
        }

        /// <summary>
        /// Get the cost of selected services.
        /// </summary>
        /// <returns>The total cost of selected services.</returns>
        private decimal GetServiceCost()
        {
            decimal cost = 0m;
            if (cutCheckBox.Checked) cost += 30m;
            if (colourCheckBox.Checked) cost += 40m;
            if (highlightsCheckBox.Checked) cost += 50m;
            if (extensionsCheckBox.Checked) cost += 200m;
            return cost;
        }

        /// <summary>
        /// Get the discount percentage based on the selected client type.
        /// </summary>
        /// <returns>The discount percentage as a decimal.</returns>
        private decimal GetDiscount()
        {
            if (childRadioButton.Checked) return 0.10m; // 10% discount
            if (studentRadioButton.Checked) return 0.05m; // 5% discount
            if (seniorRadioButton.Checked) return 0.15m; // 15% discount
            return 0m; // No discount for standard adult
        }

        /// <summary>
        /// Get additional discount based on the number of client visits.
        /// </summary>
        /// <returns>The additional discount percentage as a decimal.</returns>
        private decimal GetAdditionalDiscount()
        {
            if (int.TryParse(clientVisitsTextBox.Text, out int visits))
            {
                if (visits >= 1 && visits <= 3) return 0m; // 0% discount
                if (visits >= 4 && visits <= 8) return 0.05m; // 5% discount
                if (visits >= 9 && visits <= 13) return 0.10m; // 10% discount
                if (visits >= 14) return 0.15m; // 15% discount
            }
            else
            {
                MessageBox.Show("Please enter a valid number of visits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientVisitsTextBox.Focus();
            }
            return 0m; // No discount
        }

        /// <summary>
        /// Event handler to clear all input fields and result.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            clientVisitsTextBox.Clear();                // Clear client visits textbox
            janeRadioButton.Checked = true;             // Make jane RadioButton the default
            standardAdultRadioButton.Checked = true;    // Make StandAdult RadioButton the default
            cutCheckBox.Checked = false;                // Clear Cut checkbox 
            colourCheckBox.Checked = false;             // Clear Colour checkbox
            highlightsCheckBox.Checked = false;         // Clear Highlights checkbox
            extensionsCheckBox.Checked = false;         // Clear Extensions checkbox
            totalPriceLabel.Text = "Total Price: ";     // Clear Total price label
        }

        /// <summary>
        /// Event handler to exit the application.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Exit the application if Exit button is clicked
        }
    }
}