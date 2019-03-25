using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.ReadFile;

namespace WindowsFormsApp1
{
    class RaportFunctions
    {
        internal static void NumberOfOrders(TextBox textBox, Label raportDetailsLabel, DataGridView dataGridView)
        {
            string clientId = textBox.Text;

            if (clientId == "")
            {
                raportDetailsLabel.Text = "Total request count: " + dataGridView.Rows.Count;
            }
            else
            {
                int count = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string cellClientIdValue = row.Cells["clientIdColumn"].Value.ToString();

                    if (cellClientIdValue == clientId)
                    {
                        count++;
                    }
                }
                raportDetailsLabel.Text = "Total request count for client Id " + clientId + " is: " + count;
            }
        }

        internal static void NumberOfOrdersV2(TextBox textBox, Label raportDetailsLabel, DataGridView dataGridView)
        {
            string clientId = textBox.Text;

            if (clientId == "")
            {
                raportDetailsLabel.Text = "Total request count: " + CountNoumberOfOrders(dataGridView);
            }
            else
            {
                raportDetailsLabel.Text = "Total request count for client Id " + clientId + " is: " + CountNoumberOfOrders(dataGridView, clientId);
            }
        }

        internal static void ValueOfOrders(TextBox textBox, Label raportDetailsLabel, DataGridView dataGridView)
        {
            string clientId = textBox.Text;

            if (clientId == "")
            {
                double count = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    double cellValue = Convert.ToDouble(row.Cells["priceColumn"].Value);
                    count += cellValue;
                }
                raportDetailsLabel.Text = "Total value of requests is: " + count;
            }
            else
            {
                double count = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string cellClientIdValue = row.Cells["clientIdColumn"].Value.ToString();
                    double cellValue = Convert.ToDouble(row.Cells["priceColumn"].Value);

                    if (cellClientIdValue == clientId)
                    {
                        count += cellValue;
                    }
                }
                raportDetailsLabel.Text = "Total price of requests for client Id " + clientId + " is: " + count;
            }
        }

        internal static void ListOfOrders(TextBox textBox, DataGridView dataGridView)
        {
            string clientId = textBox.Text;

            if (clientId != "")
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    string clientIdInCell = dataGridView.Rows[i].Cells["clientIdColumn"].Value.ToString();

                    if (clientId != clientIdInCell)
                    {
                        dataGridView.Rows.RemoveAt(dataGridView.Rows[i].Index);
                        i--;
                    }

                }
                dataGridView.Refresh();
            }
        }

        internal static void AvarageValueOfOrders(TextBox textBox, Label raportDetailsLabel, DataGridView dataGridView)
        {
            string clientId = textBox.Text;

            if (clientId == "")
            {
                double count = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    double cellValue = Convert.ToDouble(row.Cells["priceColumn"].Value);
                    count += cellValue;
                }
                count = count / dataGridView.RowCount;
                raportDetailsLabel.Text = "Avarage value of order is: " + Math.Round(count, 2);
            }
            else
            {
                double count = 0;
                int iterationCount = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string cellClientIdValue = row.Cells["clientIdColumn"].Value.ToString();
                    double cellValue = Convert.ToDouble(row.Cells["priceColumn"].Value);

                    if (cellClientIdValue == clientId)
                    {
                        count += cellValue;
                        iterationCount++;
                    }
                }
                count = count / iterationCount;
                raportDetailsLabel.Text = "Avarage value of order for client Id " + clientId + " is: " + Math.Round(count, 2);
            }
        }

        internal static void AvarageValueOfOrdersV2(TextBox textBox, Label raportDetailsLabel, DataGridView dataGridView)
        {
            string clientId = textBox.Text;

            if (clientId == "")
            {
                double count = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    double cellValue = Convert.ToDouble(row.Cells["priceColumn"].Value);
                    count += cellValue;
                }
                count = count / CountNoumberOfOrders(dataGridView);
                raportDetailsLabel.Text = "Avarage value of order is: " + Math.Round(count, 2);
            }
            else
            {
                double count = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (clientId == row.Cells["clientIdColumn"].Value.ToString())
                    {
                        double cellValue = Convert.ToDouble(row.Cells["priceColumn"].Value);
                        count += cellValue;
                    }
                }
                count = count / CountNoumberOfOrders(dataGridView, clientId);
                raportDetailsLabel.Text = "Avarage value of order for client Id " + clientId + " is: " + Math.Round(count, 2);
            }
        }

        internal static void OrdersByName(TextBox textBox, DataGridView dataGridView)
        {
            List<string> itemsList = new List<string>();
            List<int> quantityList = new List<int>();
            List<double> priceList = new List<double>();
            string clientId = textBox.Text;

            if (clientId == "")
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (itemsList.Count == 0)
                    {
                        itemsList.Add(Convert.ToString(dataGridView.Rows[i].Cells["nameColumn"].Value));
                        quantityList.Add(Convert.ToInt32(dataGridView.Rows[i].Cells["quantityColumn"].Value));
                        priceList.Add(Convert.ToDouble(dataGridView.Rows[i].Cells["priceColumn"].Value));
                    }
                    else
                    {
                        for (int j = 0; j < itemsList.Count; j++)
                        {
                            if (itemsList[j] == Convert.ToString(dataGridView.Rows[i].Cells["nameColumn"].Value))
                            {
                                quantityList[j] += Convert.ToInt32(dataGridView.Rows[i].Cells["quantityColumn"].Value);
                                priceList[j] += Convert.ToDouble(dataGridView.Rows[i].Cells["priceColumn"].Value);
                            }

                            if (itemsList.Contains(Convert.ToString(dataGridView.Rows[i].Cells["nameColumn"].Value)) == false)
                            {
                                itemsList.Add(Convert.ToString(dataGridView.Rows[i].Cells["nameColumn"].Value));
                                quantityList.Add(0);
                                priceList.Add(0);
                            }
                        }
                    }
                }

                dataGridView.Rows.Clear();
                dataGridView.Refresh();

                for (int i = 0; i < itemsList.Count; i++)
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["nameColumn"].Value = itemsList[i];
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["quantityColumn"].Value = quantityList[i];
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["priceColumn"].Value = priceList[i];
                }

            }
            else
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {

                    string clientIdInCell = dataGridView.Rows[i].Cells["clientIdColumn"].Value.ToString();

                    if (itemsList.Count == 0 && clientId == clientIdInCell)
                    {
                        itemsList.Add(Convert.ToString(dataGridView.Rows[i].Cells["nameColumn"].Value));
                        quantityList.Add(Convert.ToInt32(dataGridView.Rows[i].Cells["quantityColumn"].Value));
                        priceList.Add(Convert.ToDouble(dataGridView.Rows[i].Cells["priceColumn"].Value));
                    }
                    else
                    {
                        for (int j = 0; j < itemsList.Count; j++)
                        {
                            if (itemsList[j] == Convert.ToString(dataGridView.Rows[i].Cells["nameColumn"].Value) && clientId == clientIdInCell)
                            {
                                quantityList[j] += Convert.ToInt32(dataGridView.Rows[i].Cells["quantityColumn"].Value);
                                priceList[j] += Convert.ToDouble(dataGridView.Rows[i].Cells["priceColumn"].Value);
                            }

                            if (itemsList.Contains(Convert.ToString(dataGridView.Rows[i].Cells["nameColumn"].Value)) == false && clientId == clientIdInCell)
                            {
                                itemsList.Add(Convert.ToString(dataGridView.Rows[i].Cells["nameColumn"].Value));
                                quantityList.Add(0);
                                priceList.Add(0);
                            }
                        }
                    }
                }

                dataGridView.Rows.Clear();
                dataGridView.Refresh();

                for (int i = 0; i < itemsList.Count; i++)
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["clientIdColumn"].Value = clientId;
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["nameColumn"].Value = itemsList[i];
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["quantityColumn"].Value = quantityList[i];
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["priceColumn"].Value = priceList[i];
                }

            }
            dataGridView.Refresh();
        }

        internal static void OrdersInRange(NumericUpDown numericUpDownMin, NumericUpDown numericUpDownMax, DataGridView dataGridView)
        {
            double minValue = Convert.ToDouble(numericUpDownMin.Value);
            double maxValue = Convert.ToDouble(numericUpDownMax.Value);

            if (minValue != 0 && maxValue != 0)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    double cellValue = Convert.ToDouble(dataGridView.Rows[i].Cells["priceColumn"].Value);

                    if (cellValue < minValue || cellValue > maxValue)
                    {
                        dataGridView.Rows.RemoveAt(dataGridView.Rows[i].Index);
                        i--;
                    }

                }
                dataGridView.Refresh();
            }
        }

        internal static void OrdersInRangeV2(NumericUpDown numericUpDownMin, NumericUpDown numericUpDownMax, DataGridView dataGridView)
        {
            List<string> clientIdList = new List<string>();
            List<long> requestIdList = new List<long>();
            List<double> priceList = new List<double>();

            double minValue = Convert.ToDouble(numericUpDownMin.Value);
            double maxValue = Convert.ToDouble(numericUpDownMax.Value);


            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (clientIdList.Count == 0)
                {
                    clientIdList.Add(Convert.ToString(dataGridView.Rows[i].Cells["clientIdColumn"].Value));
                    requestIdList.Add(Convert.ToInt32(dataGridView.Rows[i].Cells["requestIdColumn"].Value));
                    priceList.Add(Convert.ToDouble(dataGridView.Rows[i].Cells["priceColumn"].Value));
                }
                else
                {
                    for (int j = 0; j < clientIdList.Count; j++)
                    {
                        if (clientIdList[j] == Convert.ToString(dataGridView.Rows[i].Cells["clientIdColumn"].Value) && requestIdList[j] == Convert.ToInt64(dataGridView.Rows[i].Cells["requestIdColumn"].Value))
                        {
                            priceList[j] += Convert.ToDouble(dataGridView.Rows[i].Cells["priceColumn"].Value);
                        }
                        if (clientIdList.Contains(Convert.ToString(dataGridView.Rows[i].Cells["clientIdColumn"].Value)))
                        {
                            if (!requestIdList.Contains(Convert.ToInt64(dataGridView.Rows[i].Cells["requestIdColumn"].Value))) { 
                                clientIdList.Add(Convert.ToString(dataGridView.Rows[i].Cells["clientIdColumn"].Value));
                                requestIdList.Add(Convert.ToInt64(dataGridView.Rows[i].Cells["requestIdColumn"].Value));
                                priceList.Add(0);
                            }
                        }
                        if (!clientIdList.Contains(Convert.ToString(dataGridView.Rows[i].Cells["clientIdColumn"].Value)))
                        {
                            clientIdList.Add(Convert.ToString(dataGridView.Rows[i].Cells["clientIdColumn"].Value));
                            requestIdList.Add(Convert.ToInt64(dataGridView.Rows[i].Cells["requestIdColumn"].Value));
                            priceList.Add(0);
                        }
                    }
                }
            }
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            for (int i = 0; i < clientIdList.Count; i++)
            {
                if (minValue < priceList[i] && maxValue > priceList[i])
                {
                    dataGridView.Rows.Add();
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["clientIdColumn"].Value = clientIdList[i];
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["requestIdColumn"].Value = requestIdList[i];
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["priceColumn"].Value = priceList[i];
                }
            }
            dataGridView.Refresh();
        }
            
        internal static void LoadFromFiles(Database database, Label selectedFilesLabel, DataGridView dataGridView)
        {
            List<string> filenameList = new List<string>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            StringBuilder stringBuilder = new StringBuilder();

            openFileDialog.Filter = "Data Types (*.json;*.xml;*.csv)|*.json;*.xml;*.csv";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog.FileNames)
                {
                    filenameList.Add(file);
                    stringBuilder.Append(" " + file.Substring(file.LastIndexOf('\\')));
                }

                foreach (string fileName in filenameList)
                {
                    FileInfo fileInfo = new FileInfo(fileName);

                    switch (fileInfo.Extension)
                    {
                        case ".csv":
                            List<Request> requestListCSV = new List<Request>();
                            ReadFile.ReadCSV(requestListCSV, fileName);

                            foreach (Request request in requestListCSV)
                            {
                                database.AddRowToDatabase(request);
                            }

                            break;

                        case ".xml":
                            List<Request> requestListXML = new List<Request>();
                            ReadFile.ReadXML(requestListXML, fileName);

                            foreach (Request request in requestListXML)
                            {
                                database.AddRowToDatabase(request);
                            }

                            break;


                        case ".json":
                            List<Request> requestListJSON = new List<Request>();
                            ReadFile.ReadJSON(requestListJSON, fileName);

                            foreach (Request request in requestListJSON)
                            {
                                database.AddRowToDatabase(request);
                            }

                            break;

                        default:

                            break;
                    }
                }

                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                database.RefreshDatabase(dataGridView);
            }

            string selectedFiles = stringBuilder.ToString();
            selectedFilesLabel.Text = "Selected files: " + selectedFiles;
        }

        internal static void SaveRaportToCSV(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "CSV (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] output = new string[dataGridView.RowCount + 1];
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    output[0] += dataGridView.Columns[i].Name.ToString().Replace("Column", "");
                    if (i != dataGridView.ColumnCount - 1)
                    {
                        output[0] += ",";
                    }
                }
                for (int i = 1; (i - 1) < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        output[i] += dataGridView.Rows[i - 1].Cells[j].Value.ToString();
                        if (j != dataGridView.ColumnCount - 1)
                        {
                            output[i] += ",";
                        }
                    }
                }
                try
                {
                    System.IO.File.WriteAllLines(saveFileDialog.FileName, output, System.Text.Encoding.UTF8);
                    MessageBox.Show("Succes! \n\n Your file has been saved.");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        internal static void SaveRaportToCSV(Label totalRequestCount, Label totalRequestValue, Label averageRequestValue)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "CSV (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] output = new string[2];
                output[0] = totalRequestCount.Name.Replace("Label", "") + "," + totalRequestValue.Name.Replace("Label", "") + "," + averageRequestValue.Name.Replace("Label", "");
                output[1] = totalRequestValue.Text + "," + totalRequestValue.Text + "," + averageRequestValue.Text;
                try
                {
                    System.IO.File.WriteAllLines(saveFileDialog.FileName, output, System.Text.Encoding.UTF8);
                    MessageBox.Show("Succes! \n\n Your file has been saved.");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        internal static int CountNoumberOfOrders(DataGridView dataGridView)
        {
            bool found = false;
            int count = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string clientIdInRow = dataGridView.Rows[i].Cells["clientIdColumn"].Value.ToString();
                long requestIdInRow = Convert.ToInt64(dataGridView.Rows[i].Cells["requestIdColumn"].Value);

                for (int j = 0; j < i; j++)
                {
                    if (clientIdInRow == dataGridView.Rows[j].Cells["clientIdColumn"].Value.ToString() && requestIdInRow == Convert.ToInt64(dataGridView.Rows[j].Cells["requestIdColumn"].Value))
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    count++;
                }

                found = false;
            }
            return count;
        }

        internal static int CountNoumberOfOrders(DataGridView dataGridView, string clientId)
        {
            bool found = false;
            int count = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string clientIdInRow = dataGridView.Rows[i].Cells["clientIdColumn"].Value.ToString();
                string requestIdInRow = dataGridView.Rows[i].Cells["requestIdColumn"].Value.ToString();

                if (clientId == clientIdInRow)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (clientIdInRow == dataGridView.Rows[j].Cells["clientIdColumn"].Value.ToString() && requestIdInRow == dataGridView.Rows[j].Cells["requestIdColumn"].Value.ToString())
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        count++;
                    }
                    found = false;
                }
            }
            return count;
        }

    }
}
