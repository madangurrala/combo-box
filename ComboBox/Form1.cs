using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            string fileName = @"D:\Projects\ComboBox\combo_example.csv";
            List<Material> comboBoxData;
            //Load combo box with csv data
            using (var reader = new StreamReader(fileName))
            {
                using (var data = new CsvReader(reader, CultureInfo.CurrentCulture))
                {
                    comboBoxData = data.GetRecords<Material>().ToList();
                    cmbBox.DataSource = comboBoxData;
                    cmbBox.ValueMember = "Id";
                    cmbBox.DisplayMember = "Name";
                }
            }
        }

        //Show the selected combo box value's ID
        private void revealBtn_Click(object sender, EventArgs e)
        {
            var selectedValue = cmbBox.SelectedItem as Material;

            MessageBox.Show("Selected Material's Id is " + selectedValue.Id.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
