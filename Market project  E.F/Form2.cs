using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_project__E.F
{
    public partial class Form2 : Form
    {
        marketEntities1 db;
        public Form2()
        {
            db = new marketEntities1();
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.marketDataSet.items);
            // TODO: This line of code loads data into the 'marketDataSet.Item_store' table. You can move, or remove it, as needed.
            this.item_storeTableAdapter.Fill(this.marketDataSet.Item_store);
            // TODO: This line of code loads data into the 'marketDataSet.store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.marketDataSet.store);
            var stname = (from d in db.stores
                          select d.store_name).Distinct();
            foreach (var st in stname)
            {
                comboBox1.Items.Add(st);
            }
            /////items report
            var ITM_ID = (from d in db.items
                          select d.Item_id).Distinct();
            foreach (var iD in ITM_ID)
            {
                comboBox2.Items.Add(iD);
            }
            //storeName combo box
            var stnam = (from s in db.stores
                          select s.store_name).Distinct();
            foreach (var sn in stnam)
            {
                comboBox3.Items.Add(sn);
            }
            //itemPeriod Report
            var ITM_ID2 = (from id in db.items
                          select id.Item_id).Distinct();
            foreach (var ID in ITM_ID2)
            {
                comboBox4.Items.Add(ID);
            }
            var ITM_ID1 = (from d in db.items
                          select d.Item_id).Distinct();
            foreach (var iD1 in ITM_ID1)
            {
                comboBox5.Items.Add(iD1);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int itmc = int.Parse(comboBox4.Text);
            int rg = int.Parse(textBox1.Text);
            if(comboBox4.Text !="" && textBox1.Text !="")
            {
                    item itm = db.items.Find(itmc);
                    if(itm!=null)
                    {
                    dataGridView3.DataSource = db.itemperiod(itmc, rg);
                    comboBox4.Text = textBox1.Text = string.Empty;
                    }
                else
                {
                    MessageBox.Show("The Item you eneterd is not avaliable");
                }

            }

            else
            {
                MessageBox.Show("You must select Item ID");
            }
        }

        private void Button2_Click(object sender, EventArgs e) //items report button
        {
            int itmID = int.Parse(comboBox2.Text);
            string stname = comboBox3.Text;

            if (comboBox2.Text != "" && comboBox3.Text != "")
            {
                item im = db.items.Find(itmID);
                if (im != null)

                {
                    dataGridView2.DataSource = db.itemreport(itmID, stname);
                    comboBox2.Text = comboBox3.Text = string.Empty;
                  
                }
                else
                {
                    MessageBox.Show("The Item you eneterd is not avalible");
                }

            }
            else
            {
                MessageBox.Show("You Must select the Item ID");
            }
        }

        private void Button3_Click(object sender, EventArgs e) //store report button
        {
            string strNm = comboBox1.Text;
            store str = new store();
            if (comboBox1.Text != "")
            {
                store st = db.stores.Find(strNm);
                if (st != null)

                {
                    dataGridView1.DataSource = db.storeReport(strNm);                
                    comboBox1.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("the store name you entered is not avaliable");
                }

            }
            else
            {
                MessageBox.Show("you must select the store name");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int idI = int.Parse(comboBox5.Text);
            int Rg = int.Parse(textBox2.Text);
            if (comboBox5.Text != "" && textBox2.Text != "")
            {
               item It = db.items.Find(idI);
                if (It != null)

                {
                    dataGridView4.DataSource = db.expdate(idI, Rg);           
                    textBox2.Text = comboBox5.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Item you entered isnot avalible");
                }

            }
            else
            {
                MessageBox.Show("Please enter Item ID and Days");
            }


        }
    }
}
