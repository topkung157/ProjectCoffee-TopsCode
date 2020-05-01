using System;
using System.Activities.Expressions;
using System.Activities.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AventStack.ExtentReports.Gherkin.Model;

namespace proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh_coffee();

        }

        private void refresh_coffee()
        {
            throw new NotImplementedException();
        }

        Public Sub refresh_coffee()
        {
            sql = "select coffee_id, coffee_name, coffee_image from coffee";
            Dim data_table As DataTable = cmd_excuteDataTable()


            Load_Sale_item(ImageList1, listViewcoff, data_table, My.Resources.default_coffee, "coffee_image", "coffee_id", "coffee_name")

        }
         

        Public Sub private object keys;

        search_coffee()
        {
            sql = String.Format"select coffee_id, coffee_name, coffee_image from coffee where coffe_id like '%{0}%' OR coffee_name like '%{0}%'",txt_search .Text );
            Dim data_table As DataTable = cmd_excuteDataTable()


            Load_Sale_item(ImageList1, listViewcoff, data_table, My.Resources.default_coffee, "coffee_image", "coffee_id", "coffee_name")

        }
         
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            If e.keyData = keys.Enter Then
                search_coffee();
        }
    }
}
