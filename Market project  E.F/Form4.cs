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
    public partial class Form4 : Form
    {
        marketEntities1 db;
        public Form4()
        {
            
            InitializeComponent();
            db = new marketEntities1();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var itm = from d in db.items
                      select d.Item_id;
            foreach (var i in itm)
            {
                comboBox1.Items.Add(i);
            }
            ///
            var stn = from d in db.Item_store
                      select d.store_name;
            foreach (var i in stn)
            {
                comboBox3.Items.Add(i);
            }


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itmd = int.Parse(comboBox1.Text);
           var onm = (from d in db.Item_store
                       where d.item_id == itmd
                       select d.store_name).FirstOrDefault();
            textBox1.Text = onm.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int itemID = int.Parse(comboBox1.Text);            
            string Nsname = comboBox3.Text;
            
           DateTime prodate = dateTimePicker1.Value;
           DateTime Exdate = dateTimePicker2.Value;
           if(comboBox1.Text!="" && comboBox3.Text!="")
            {
                item it = db.items.Find(itemID);
                if(it!=null)
                {
                    db.updatetrans(itemID, prodate, Exdate, Nsname);
                    db.SaveChanges();
                    MessageBox.Show("The data has been transformed succesfully");
                    comboBox1.Text = comboBox3.Text = textBox1.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("This Item is not avalible in a store please select a correct item");
                }
            }
           else
            {
                MessageBox.Show("please enter all data ");
            }

        }
    }
}
