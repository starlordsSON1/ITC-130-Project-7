using System;
using System.Windows.Forms;

namespace Aiden_Tschebykin_7
{
    public partial class Project7Form : Form
    {
        public Project7Form()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check first name capitalization
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter a first name.", "Missing First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (!char.IsUpper(txtFirstName.Text.Trim()[0]))
            {
                MessageBox.Show("Please capitalize the first letter of the first name.", "First Name Capitalization", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Focus();
                return;
            }

            // Check last name capitalization
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter a last name.", "Missing Last Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (!char.IsUpper(txtLastName.Text.Trim()[0]))
            {
                MessageBox.Show("Please capitalize the first letter of the last name.", "Last Name Capitalization", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLastName.Focus();
                return;
            }

            // Convert state to uppercase
            var state = (txtState.Text ?? string.Empty).Trim().ToUpper();

            // Create formatted string: last name, first name, state
            var last = txtLastName.Text.Trim();
            var first = txtFirstName.Text.Trim();
            var entry = $"{last}, {first}, {state}";

            // Add to listbox
            lstCustomers.Items.Add(entry);

            // Clear textboxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtState.Clear();
            txtFirstInitial.Clear();
            txtLastInitial.Clear();

            // Set focus to first name
            txtFirstName.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer from the list to search.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = lstCustomers.SelectedItem.ToString();
            // Expecting format: last, first, state
            var parts = selected.Split(',');
            if (parts.Length < 3)
            {
                MessageBox.Show("Selected entry is not in the expected format.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var last = parts[0].Trim();
            var first = parts[1].Trim();
            var state = parts[2].Trim();

            txtFirstName.Text = first;
            txtLastName.Text = last;
            txtState.Text = state;

            txtFirstInitial.Text = string.IsNullOrEmpty(first) ? string.Empty : first[0].ToString();
            txtLastInitial.Text = string.IsNullOrEmpty(last) ? string.Empty : last[0].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
