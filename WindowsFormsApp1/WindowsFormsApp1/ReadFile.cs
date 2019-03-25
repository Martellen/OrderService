using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Xml;
using Newtonsoft.Json;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace WindowsFormsApp1
{
    class ReadFile
    {
        public static List<Request> ReadCSV(List<Request> requestListCSV, string fileName)
        {
            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                parser.CommentTokens = new string[] { "#" };
                parser.SetDelimiters(new string[] { "," });
                parser.HasFieldsEnclosedInQuotes = true;

                // Skip over header line.
                parser.ReadLine();

                for (int i=0; i<parser.LineNumber; i++)
                {
                    try
                    {
                        string[] fields = parser.ReadFields();
                        var results = new List<ValidationResult>();

                        Request request = new Request();

                        request.clientId = fields[0];
                        request.requestId = Convert.ToInt64(fields[1]);
                        request.name = fields[2];
                        request.quantity = Convert.ToInt32(fields[3]);
                        request.price = Convert.ToDouble(fields[4].Replace(",", "."), CultureInfo.GetCultureInfo("en"));

                        var context = new ValidationContext(request, null, null);
                        bool IsValid = Validator.TryValidateObject(request, context, results, true);
                        if (IsValid)
                        {
                            requestListCSV.Add(request);
                        }
                        else
                        {
                            foreach (var validationResult in results)
                            {
                                MessageBox.Show(validationResult.ErrorMessage + ". At line: " + (i+2) + "\n\n" + "The record will be skipped");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message + ". At line: " + (i+2) + "\n\n" + "This record will be skipped");
                    }
                }

                return requestListCSV;
            }
        }


        public static List<Request> ReadXML(List<Request> requestListXML, string fileName)
        {
            {
                XmlDocument doc = new XmlDocument();

                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

                doc.Load(fileName);
                // NIE CZYTA POLSKICH ZNAKOW - INVALID CHAR !!!

                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    try
                    {
                        string text = node.InnerText; //or loop through its children as well
                        var results = new List<ValidationResult>();

                        Request request = new Request();

                        request.clientId = node["clientId"].InnerText;
                        request.requestId = Convert.ToInt64((node["requestId"].InnerText));
                        request.name = node["name"].InnerText;
                        request.quantity = Convert.ToInt32(node["quantity"].InnerText);
                        request.price = Convert.ToDouble(node["price"].InnerText.Replace(",", "."), CultureInfo.GetCultureInfo("en"));

                        var context = new ValidationContext(request, null, null);
                        bool IsValid = Validator.TryValidateObject(request, context, results, true);
                        if (IsValid)
                        {
                            requestListXML.Add(request);
                        }
                        else
                        {
                            foreach (var validationResult in results)
                            {
                                MessageBox.Show(validationResult.ErrorMessage + ". At node: " + node.InnerText + "\n\n" + "This record will be skipped");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message + " At node: " + node.InnerText + "\n\n" + "The record will be skipped");
                    }

                }

            }

            return requestListXML;
        }


        public static List<Request> ReadJSON(List<Request> requestListJSON, string fileName)
        {
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(File.ReadAllText(fileName));

            DataTable dataTable = dataSet.Tables["requests"];
            int count = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                count++;
                try
                {
                    var results = new List<ValidationResult>();
                    Request request = new Request();

                    request.clientId = row["clientId"].ToString();
                    request.requestId = Convert.ToInt64(row["requestId"]);
                    request.name = row["name"].ToString();
                    request.quantity = Convert.ToInt32(row["quantity"]);
                    request.price = Convert.ToDouble(row["price"].ToString().Replace(",", "."), CultureInfo.GetCultureInfo("en"));

                    var context = new ValidationContext(request, null, null);
                    bool IsValid = Validator.TryValidateObject(request, context, results, true);
                    if (IsValid)
                    {
                        requestListJSON.Add(request);
                    }
                    else
                    {
                        foreach (var validationResult in results)
                        {
                            MessageBox.Show(validationResult.ErrorMessage + ". At : " + dataTable.TableName + " no. " + count + "\n\n" + "The record will be skipped");
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + " At: " + dataTable.TableName + "\n\n" + "This record will be skipped");
                }

            }

            return requestListJSON;
        }


        public class Request
        {
            [Required(ErrorMessage = "requestId field is required")]
            [StringLength(6, ErrorMessage = "clientId field is longer than 6")]
            [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
            public string clientId { get; set; }

            [Required (ErrorMessage = "requestId field is required")]
            public long requestId { get; set; }

            [Required(ErrorMessage = "requestId field is required")]
            [StringLength(255, ErrorMessage = "name field is longer than 255")]
            public string name { get; set; }

            [Required (ErrorMessage = "quantity field is required")]
            public int quantity { get; set; }

            [Required(ErrorMessage = "requestId field is required")]
            [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "price field needs to be decimal")]
            public double price { get; set; }
        }

    }
}
