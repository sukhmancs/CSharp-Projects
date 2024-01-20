/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 28, 2023
 * Program's purpose - Windows form app that determines pricing of hair salon based on the services, client type
 * I, Sukhmanjeet Singh, 000838215 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B // Declare a namespace called "Lab3B" to contain the code.
{
    /// <summary>
    /// Define a public class named "Form1" that inherits from a class called "Form."
    /// </summary>
    public partial class Form1 : Form
    {

        // Data for hairdressercomboBox
        private Dictionary<string, decimal> hairdresserBaseRates = new Dictionary<string, decimal>
        {
            { "Jane Samley", 30m },
            { "Pat Johnson", 45m },
            { "Ron Chambers", 40m },
            { "Sue Pallon", 50m },
            { "Laurie Renkins", 55m }
        };

        // Data for serviceListBox
        private Dictionary<string, decimal> serviceRates = new Dictionary<string, decimal>
        {
            { "Cut", 30m },
            { "Wash, blow-dry, and style", 20m },
            { "Colour", 40m },
            { "Highlights", 50m },
            { "Extension", 200m },
            { "Up-do", 60m }
        };

        private decimal totalCost = 0m; // Intialize totalCost to zero

        bool isFirstServiceAdded = true; // Intialize the value to true for use in addService_Button_Click function

        /// <summary>
        /// Class constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitializeForm();  // Intialize the initial values for the form
        }

        /// <summary>
        /// It intialize the values on form's startup
        /// </summary>
        private void InitializeForm()
        {
            // Populate Hairdresser ComboBox
            hairDresserComboBox.Items.AddRange(hairdresserBaseRates.Keys.ToArray());
            hairDresserComboBox.SelectedIndex = 0;
            
            // Disable items listbox selection 
            itemsListBox.Enabled = false;

            // Disable price listbox selection 
            priceListBox.Enabled = false;

            // Disable total price listbox selection
            totalPriceListBox.Enabled = false;

            // Disable some buttons on start
            // Disable service and totalprice calculation before hairDresser selection
            addServiceButton.Enabled = false;
            calculateTotalPriceButton.Enabled = false; 

            // Populate Services ListBox
            serviceListBox.Items.AddRange(serviceRates.Keys.ToArray());
        }

        /// <summary>
        /// Event handler for calculateTotalPriceButton gets clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            // Calculate and display the total cost
            totalPriceListBox.Items.Clear();
            updateTotalCostLabel();
        }

        /// <summary>
        /// Event handler when addServiceButton gets clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addServiceButton_Click(object sender, EventArgs e)
        {
            string selectedHairdresser = hairDresserComboBox.SelectedItem.ToString(); // Get selected hairdresser from the drop-down list
            string selectedService = serviceListBox.SelectedItem.ToString(); // Get the selected service
            decimal serviceCost = serviceRates[selectedService]; // Get the Service Cost

            if (isFirstServiceAdded)
            {
                isFirstServiceAdded = false;
                
                // Add appropriate items to the items listbox and the price listbox
                itemsListBox.Items.Add(selectedHairdresser);
                itemsListBox.Items.Add(selectedService);
            }
            else
            {
                itemsListBox.Items.Add(selectedService);
            }
            
            priceListBox.Items.Add("$" + serviceCost);
            totalCost += serviceCost;       // Update the totalCost

            // Disable Hairdresser selection after the first service is added
            hairDresserComboBox.Enabled = false;

            // Enable calculate totalPrice button after the first service is added
            calculateTotalPriceButton.Enabled = true;
        }

        /// <summary>
        /// Add total cost to the totalpriceListBox
        /// </summary>
        private void updateTotalCostLabel()
        {
            totalPriceListBox.Items.Clear(); // Clear Total Price list
            totalPriceListBox.Items.Add("$" + totalCost.ToString());
        }

        /// <summary>
        /// Event handler for reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset the form to initial state
            itemsListBox.Items.Clear(); 
            priceListBox.Items.Clear();
            totalCost = 0; // Set total cost to zero
            updateTotalCostLabel();  // Update totalCost
            hairDresserComboBox.Enabled = true;  // Disable hairDresser comboBox
            hairDresserComboBox.SelectedIndex = 0;  // Reset to the first value of the ComboBox
            addServiceButton.Enabled = false;   // Disable addservicebutton
            calculateTotalPriceButton.Enabled = false; // Disable addservicebutton
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

        /// <summary>
        /// Event handler when serviceListBox gets clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serviceListBox.SelectedIndex != -1) 
            {
                addServiceButton.Enabled = true;
            }
        }
    }
}
