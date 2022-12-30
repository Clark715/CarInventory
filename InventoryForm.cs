using System;

namespace CarInventory
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // POPULATE GRID WITH USER INPUTS FROM PROVIDED TEXTBOXES
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Please fill in all fields.", "Oops!");
            }
            else
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = idText.Text;
                newRow.Cells[1].Value = makeText.Text;
                newRow.Cells[2].Value = modelText.Text;
                newRow.Cells[3].Value = yearText.Text;
                newRow.Cells[4].Value = colorText.Text;
                newRow.Cells[5].Value = bodyText.Text;
                newRow.Cells[6].Value = transText.Text;
                newRow.Cells[7].Value = drivetrainText.Text;
                newRow.Cells[8].Value = valueText.Text;
                dataGridView1.Rows.Add(newRow);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // REMOVE HIGHLIGHTED ROW FROM GRID 
            DialogResult deleteCar;
            deleteCar = MessageBox.Show("Are you sure you want to remove this vehicle?", "Vehicle Removal", MessageBoxButtons.YesNo);

            if (deleteCar == DialogResult.Yes)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // SAVE DATA TO DATABASE 
            }
            catch { }
            {
                MessageBox.Show("There was an error saving the file.", "Error");
            }

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
