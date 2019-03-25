using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static WindowsFormsApp1.ReadFile;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Database database = new Database();

        public Form1()
        {
            InitializeComponent();
            database.ConnectToDatabase();
            database.DeleteDatabase();
        }


        private void selectFileButton_Click(object sender, EventArgs e)
        {
            database.DeleteDatabase();
            RaportFunctions.LoadFromFiles(database, selectedFilesLabel, dataGridView1);
        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }


        private void NumberOfOrdersClick(object sender, EventArgs e)
        {
            LoadAllDataGridVievData(dataGridView1, database);
            //RaportFunctions.NumberOfOrders(numberOfOrdersIdInput, numberOfOrdersLabel, dataGridView1);
            RaportFunctions.NumberOfOrdersV2(numberOfOrdersIdInput, numberOfOrdersLabel, dataGridView1);
        }


        private void ValueOfOrdersClick(object sender, EventArgs e)
        {
            LoadAllDataGridVievData(dataGridView1, database);
            RaportFunctions.ValueOfOrders(totalValueOfOrdersIdInput, totalValueOfOrdersLabel, dataGridView1);
        }


        private void ListOrdersClick(object sender, EventArgs e)
        {
            LoadAllDataGridVievData(dataGridView1, database);
            RaportFunctions.ListOfOrders(listOfOrdersIdInput, dataGridView1);
        }


        private void AverageValueOfOrdersClick(object sender, EventArgs e)
        {
            LoadAllDataGridVievData(dataGridView1, database);
            //RaportFunctions.AvarageValueOfOrders(averageValueOfOrdersIdInput, averageValueOfOrdersLabel, dataGridView1);
            RaportFunctions.AvarageValueOfOrdersV2(averageValueOfOrdersIdInput, averageValueOfOrdersLabel, dataGridView1);
        }


        private void OrdersByNameClick(object sender, EventArgs e)
        {
            LoadAllDataGridVievData(dataGridView1, database);
            RaportFunctions.OrdersByName(numberOfOrdersByNameIdInput, dataGridView1);
        }


        private void OrdersInRangeClick(object sender, EventArgs e)
        {
            LoadAllDataGridVievData(dataGridView1, database);
            //RaportFunctions.OrdersInRange(numericUpDown6, numericUpDown7, dataGridView1);
            RaportFunctions.OrdersInRangeV2(numericUpDown6, numericUpDown7, dataGridView1);
        }


        static void LoadAllDataGridVievData(DataGridView dataGridView, Database database)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            database.RefreshDatabase(dataGridView);
        }

        private void saveTableToCSVClick(object sender, EventArgs e)
        {
            RaportFunctions.SaveRaportToCSV(dataGridView1);
        }

        private void saveRaportDetailsToCSVClick(object sender, EventArgs e)
        {
            RaportFunctions.SaveRaportToCSV(numberOfOrdersLabel, totalValueOfOrdersLabel, averageValueOfOrdersLabel);
        }

    }
}