using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ProiectAsofronieiRoxana
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        private List<Tea> products;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HttpResponseMessage response = await client.GetAsync("http://127.0.0.1:8000/products");
            System.Diagnostics.Debug.WriteLine(response.Content.ReadAsStringAsync().Result);

            if (response.IsSuccessStatusCode)
            {
                products = JsonConvert.DeserializeObject<List<Tea>>(response.Content.ReadAsStringAsync().Result.Trim());
                foreach (var product in products)
                {
                    listBox1.Items.Add(product.toString());
                }
            } else
            {
                Debug.WriteLine(response.IsSuccessStatusCode);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            int nameEndPosition = listBox1.SelectedItem.ToString().IndexOf("-");
            string teaId = listBox1.SelectedItem.ToString().Substring(0, nameEndPosition).Trim();

            HttpResponseMessage response = await client.GetAsync($"http://127.0.0.1:8000/products/delete/{teaId}");

            if (response.IsSuccessStatusCode)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Tea.txt")))
            {
                foreach (var product in products)
                    outputFile.WriteLine(product.toString());
            }

            button2.Text = "Fisier generat! " + docPath;
        }

        private async void addNew_Click(object sender, EventArgs e)
        {
            string name = inputName.Text;
            string company = inputCompany.Text;
            string servings = inputServings.Text;
            string price = inputName.Text;


            HttpResponseMessage response = await client.GetAsync($"http://127.0.0.1:8000/products/new/{name}/{company}/{servings}/{price}");
            System.Diagnostics.Debug.WriteLine(response.Content.ReadAsStringAsync().Result);

            if (response.IsSuccessStatusCode)
            {
                this.Form1_Load(sender, e);
            }
            else
            {
                Debug.WriteLine(response.IsSuccessStatusCode);
            }
        }
    }
}
