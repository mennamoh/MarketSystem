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
    public partial class Form1 : Form
    {
        marketEntities1 db;
        public Form1()
        {
            InitializeComponent();
            db = new marketEntities1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.Export_Quantity' table. You can move, or remove it, as needed.
            this.export_QuantityTableAdapter.Fill(this.marketDataSet.Export_Quantity);
            // TODO: This line of code loads data into the 'marketDataSet.Export_permession' table. You can move, or remove it, as needed.
            this.export_permessionTableAdapter.Fill(this.marketDataSet.Export_permession);
            //suppliers
            var sup = from d in db.suppliers
                       select d.suplier_email;
            foreach (var s in sup)
            {
                comboBox1.Items.Add(s);
            }
            //items
            var itm = from d in db.items
                      select d.Item_id;
            foreach (var i in itm)
            {
                comboBox2.Items.Add(i);
            }
            //stores
            var str = from d in db.stores
                      select d.store_name;
            foreach (var s in str)
            {
                comboBox3.Items.Add(s);
            }
            ////update import permession
            //permesion number
            var imp = (from d in db.import_permession
                      select d.Iper_num).Distinct();
            foreach (var p in imp)
            {
                comboBox4.Items.Add(p);
            }
            //suplier name
            var sup1 = from d1 in db.suppliers
                      select d1.suplier_email;
            foreach (var dd in sup1)
            {
                comboBox5.Items.Add(dd);
            }
            //items
            var itm1 = from d in db.items
                      select d.Item_id;
            foreach (var i1 in itm1)
            {
                comboBox6.Items.Add(i1);
            }
            //stores
            var str1 = from d in db.stores
                      select d.store_name;
            foreach (var s in str1)
            {
                comboBox7.Items.Add(s);
            }
            ///export permession
             //items
            var exitm = (from d in db.Import_Quantity
                      select d.item_id).Distinct();
            foreach (var i in exitm)
            {
                comboBox8.Items.Add(i);
            }
            //customer Email
            var cust = from c1 in db.customers
                       select c1.c_email;
            foreach (var cc in cust)
            {
                comboBox9.Items.Add(cc);
            }
            //storename
            var strNm = from sn in db.stores
                        select sn.store_name;
            foreach (var stn in strNm)
            {
                comboBox10.Items.Add(stn);
            }
            //update export permession

            var ux = from x in db.Export_permession
                     select x.eper_num;
            foreach (var uxn in ux)
            {
                comboBox11.Items.Add(uxn);
            }
            //items
            var exi = (from d in db.items
                      select d.Item_id).Distinct();
            foreach (var p in exi)
            {
                comboBox12.Items.Add(p);
            }
            //customers
            var xcust = (from cx in db.customers
                       select cx.c_email).Distinct();
            foreach (var cxx in xcust)
            {
                comboBox13.Items.Add(cxx);
            }
            //stores
            var XSNm = (from XSN in db.stores
                        select XSN.store_name).Distinct();
            foreach (var xt in XSNm)
            {
                comboBox14.Items.Add(xt);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e) //Add store
        {
            store st = new store();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text !="")
            {
                store str = db.stores.Find(textBox1.Text);
                if (str==null)
                {
                    st.store_name = textBox1.Text;
                    st.store_Address = textBox2.Text;
                    st.store_manager = textBox3.Text;
                    db.stores.Add(st);
                    db.SaveChanges();
                    MessageBox.Show("A new store is added successfully");
                    textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("The Store you have entered is already exists");
                }
              
            }
            else
            {
                MessageBox.Show("please enter all data");
            }
        }

        private void Button2_Click(object sender, EventArgs e) //update store
        {
            String nm = textBox4.Text;
            store str = db.stores.Find(nm);
            if (str!=null)
            {
                if( textBox5.Text != "" && textBox6.Text != "")
                {
                    str.store_Address= textBox5.Text;
                    str.store_manager = textBox6.Text;
                    db.SaveChanges();
                    MessageBox.Show("The store data is updated successfully");
                    textBox4.Text = textBox5.Text = textBox6.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please enter all the required data");
                }
            }
            else
            {
                MessageBox.Show("This store is not exits");
            }
        }

        private void Button3_Click(object sender, EventArgs e) //Add item
        {
            item itm = new item();

            if(textBox7.Text !="" && textBox8.Text !="" && textBox9.Text!="" &&textBox10.Text!="")
            {
                item it = db.items.Find(int.Parse(textBox7.Text));
                if(it==null)
                {   int id = int.Parse(textBox7.Text);
                    itm.Item_id = int.Parse(textBox7.Text);
                    itm.item_name = textBox8.Text;
                    itm.prod_date = DateTime.Parse(textBox9.Text);
                    itm.Ex_date = DateTime.Parse(textBox10.Text);
                    db.items.Add(itm);
                    db.SaveChanges();
                    MessageBox.Show("A new item is added successfully");
                    textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("This item is already exits");
                }

            }
            else
            {
                MessageBox.Show("please enter all required data");
            }

        }


        private void Button4_Click(object sender, EventArgs e) //update items
        {
            int id = int.Parse(textBox11.Text);
           item itms = db.items.Find(id);
            if (id !=null)
            {
                if (textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "")
                {
                    itms.Item_id = int.Parse(textBox11.Text);
                    itms.item_name = textBox12.Text;
                    itms.prod_date = DateTime.Parse(textBox13.Text);
                    itms.Ex_date= DateTime.Parse(textBox14.Text);
                    db.SaveChanges();
                    MessageBox.Show("The Item data is updated successfully");
                    textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please enter all the required data");
                }
            }
            else
            {
                MessageBox.Show("This Item is not exits");
            }
        }

        private void TabPage8_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e) //Add supplier
        {
            supplier sup = new supplier();
            if(textBox15.Text !="" && textBox16.Text !="" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "" && textBox20.Text != "")
            {
                supplier sp = db.suppliers.Find(textBox16.Text);
                if (sp == null)
                {
                    sup.suplier_name = textBox15.Text;
                    sup.suplier_email = textBox16.Text;
                    sup.Suplier_site = textBox19.Text;
                    sup.Suplier_fax = textBox20.Text;
                    sup.suplier_phone = int.Parse(textBox17.Text);
                    sup.suplier_mobile = int.Parse(textBox18.Text);
                    db.suppliers.Add(sup);
                    db.SaveChanges();
                    MessageBox.Show("A new supplier is added successfully");
                    textBox15.Text = textBox16.Text = textBox17.Text = textBox18.Text = textBox19.Text = textBox20.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("This supplier is already exits");
                }
            }
            else
            {
                MessageBox.Show("please enter all required data");
            }
        }

        private void Button6_Click(object sender, EventArgs e) //update supplier
        {
            string mail = textBox22.Text;
            supplier sup = db.suppliers.Find(mail);
            if(mail !=null)
            {
                if(textBox21.Text !="" && textBox22.Text != "" && textBox23.Text != "" && textBox24.Text != "" && textBox26.Text != "")
                {
                    sup.suplier_name = textBox21.Text;
                    sup.suplier_email = textBox22.Text;
                    sup.Suplier_site = textBox23.Text;
                    sup.Suplier_fax = textBox24.Text;
                    sup.suplier_phone = int.Parse(textBox25.Text);
                    sup.suplier_mobile = int.Parse(textBox26.Text);
                    db.SaveChanges();
                    MessageBox.Show("The Supplier data is updated successfully");
                    textBox21.Text = textBox22.Text = textBox23.Text = textBox24.Text = textBox25.Text = textBox26.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("Please enter all the required data");
                }
            }
            else
            {
                MessageBox.Show("This Supplier is not exits");
            }
        }

        private void TextBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabControl5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)//Add customer
        {
            customer cust  = new customer();
            if (textBox27.Text != "" && textBox28.Text != "" && textBox29.Text != "" && textBox30.Text != "" && textBox31.Text != "")
            {
                customer cs = db.customers.Find(textBox28.Text);
                if (cs == null)
                {
                   cust.c_name = textBox27.Text;
                   cust.c_email = textBox28.Text;
                   cust.c_phone = int.Parse(textBox29.Text);
                   cust.c_website = textBox30.Text;
                   cust.c_fax = textBox31.Text;
                   db.customers.Add(cust);
                   db.SaveChanges();                  
                    MessageBox.Show("A new customer is added successfully");
                    textBox27.Text = textBox28.Text = textBox29.Text = textBox30.Text = textBox31.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("This customer is already exits");
                }
            }
            else
            {
                MessageBox.Show("please enter all required data");
            }
        }

        private void Button8_Click(object sender, EventArgs e) //update customer
        {
            string mail = textBox33.Text;
            customer custs = db.customers.Find(mail);
            if (mail != null)
            {
                if (textBox32.Text != "" && textBox33.Text != "" && textBox34.Text != "" && textBox35.Text != "" && textBox36.Text != "")
                {
                    custs.c_name = textBox32.Text;
                    custs.c_email = textBox33.Text;
                    custs.c_phone = int.Parse(textBox34.Text);
                    custs.c_website = textBox35.Text;
                    custs.c_fax = textBox36.Text;
                    db.SaveChanges();
                    MessageBox.Show("The customer data is updated successfully");
                    textBox32.Text = textBox33.Text = textBox34.Text = textBox35.Text = textBox36.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("Please enter all the required data");
                }
            }
            else
            {
                MessageBox.Show("This customer is not exits");
            }
        }

        private void TextBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label52_Click(object sender, EventArgs e)
        {

        }

        private void Label55_Click(object sender, EventArgs e)
        {

        }

        private void Label57_Click(object sender, EventArgs e)
        {

        }

        private void TabPage7_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TabPage15_Click(object sender, EventArgs e)
        {
           
        }

        private void Button9_Click(object sender, EventArgs e)//Add import permession
        {
            import_permession imp = new import_permession();
            Import_Quantity imQ = new Import_Quantity();
            Item_store itS= new Item_store();
            if (textBox38.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && date.Value != null)
            {
                import_permession ip = db.import_permession.Find(int.Parse(textBox38.Text), int.Parse(comboBox2.Text));
                if(ip==null)
                {  
                    imp.Iper_num = int.Parse(textBox38.Text);
                    imp.suplier_email = comboBox1.Text;
                    imp.item_id = int.Parse(comboBox2.Text);
                    imp.store_name = comboBox3.Text;
                    imp.Iper_date = date.Value;
                    db.import_permession.Add(imp);
                    db.SaveChanges();
                    int num= int.Parse(textBox38.Text);
                    int itmid = int.Parse(comboBox2.Text);
                    string mail= comboBox1.Text;
                    string stname = comboBox3.Text;
                    int qun= int.Parse(textBox39.Text);

                    db.impdate(itmid,num,itmid,mail,stname,qun); //procedure
                    db.SaveChanges();
                    itS.item_id= int.Parse(comboBox2.Text);
                    itS.store_name= comboBox3.Text;
                    itS.quantity= int.Parse(textBox39.Text);
                    db.Item_store.Add(itS);
                    db.SaveChanges();
                    MessageBox.Show("A new import permession is added successfully");
                    comboBox1.Text = comboBox2.Text = comboBox3.Text = textBox39.Text = textBox38.Text = string.Empty;

                    comboBox4.Items.Clear();
                    var imp1 = (from d in db.import_permession
                               select d.Iper_num).Distinct();
                    foreach (var p in imp1)
                    {
                        comboBox4.Items.Add(p);
                    }
                }
                else
                {
                    MessageBox.Show("The permession you have entered is already exists");
                }
            }
            else
            {
                MessageBox.Show("please enter all data");
            }
        }

        private void TabPage16_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e) //update import permession
        {
            import_permession imp1 = new import_permession();
            Import_Quantity imQ1 = new Import_Quantity();
            if (comboBox4.Text != "" && comboBox5.Text != "" && comboBox6.Text != "" && comboBox7.Text != "" && date.Value!= null)
            {
                import_permession ip = db.import_permession.Find(int.Parse(comboBox4.Text), int.Parse(comboBox6.Text));
                if (ip != null)
                {    
                    imp1.suplier_email = comboBox5.Text;
                    imp1.store_name = comboBox7.Text;
                    imp1.Iper_date = date.Value;
                    db.SaveChanges();

                    int ID = int.Parse(comboBox4.Text);
                    int itmid1 = int.Parse(comboBox6.Text);
                    string mail1 = comboBox5.Text;
                    string stname1 = comboBox7.Text;
                    int qun1 = int.Parse(textBox40.Text);                    
                    db.impQ_update(ID,itmid1,mail1,stname1,qun1); //procedure
                    db.SaveChanges();
                    MessageBox.Show("the import permession is updated successfully");
                    comboBox4.Text = comboBox5.Text = comboBox6.Text = comboBox7.Text = textBox40.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("The permession you have entered not exists");
                }
            }
            else
            {
                MessageBox.Show("please enter all data");
            }
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = int.Parse(comboBox4.Text);
            var imp = (from d in db.import_permession
                       where d.Iper_num == ID
                       select d).Distinct();

            listBox1.Items.Clear();    
            foreach(var i in imp)
            {
                listBox1.Items.Add(i.item_id);
            }
                              
        }

        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = int.Parse(comboBox8.Text);
            var exp = (from d in db.Import_Quantity
                       where d.item_id== ID
                       select d).Distinct();

            listBox2.Items.Clear();
            foreach (var i in exp)
            {
                listBox2.Items.Add(i.I_quantity);
                listBox2.Items.Add(i.store_name);
            }
        }

        private void Label67_Click(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)//Add_export_permession
        {
            Export_permession exp = new Export_permession();
            if (textBox41.Text != "" && comboBox9.Text != "" && comboBox8.Text != "" && textBox43.Text != "" &&/*comb*/ comboBox10.Text !="" && date.Value != null)
            {
                Export_permession xp = db.Export_permession.Find(int.Parse(textBox41.Text), int.Parse(comboBox8.Text));
                if (xp == null)
                {
                    exp.eper_num = int.Parse(textBox41.Text);
                    exp.item_id = int.Parse(comboBox8.Text);
                    exp.c_email = comboBox9.Text;
                    exp.store_name = comboBox10.Text; 
                    exp.eper_date = date.Value;
                    db.Export_permession.Add(exp);
                    db.SaveChanges();                  
                    int expnum = int.Parse(textBox41.Text);
                    int exitmid = int.Parse(comboBox8.Text);
                    string cmail = comboBox9.Text;
                    string exstname = comboBox10.Text; 
                    int exqun = int.Parse(textBox43.Text);

                    db.expQuant(exitmid, expnum, exitmid, cmail, exstname, exqun); //procedure
                    db.MiniusImpQun_(exqun, exitmid, exstname);
                    db.Up_itemstorQ(exitmid, exstname, exqun);
                    db.SaveChanges();
                    MessageBox.Show("A new Export permession is added successfully");
                    var ux1 = from x in db.Export_permession
                             select x.eper_num;
                    foreach (var uxn in ux1)
                    {
                        comboBox11.Items.Add(uxn);
                    }
                }
                else
                {
                    MessageBox.Show("The permession you have entered is already exists");
                }
            }
            else
            {
                MessageBox.Show("please enter all data");
            }
        }

        private void ComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int tid = int.Parse(comboBox11.Text);
            var tex = (from d in db.Export_permession
                       where d.eper_num == tid
                       select d).Distinct();

            dataGridView1.DataSource = tex.ToList();
        }

        private void Button12_Click(object sender, EventArgs e) //update ex_permession
        {
            Export_permession exp1 = new Export_permession();
           
            if (comboBox11.Text != "" && comboBox12.Text != "" && comboBox13.Text != "" && comboBox14.Text != "" && textBox42.Text != "" && date.Value !=null)
            {
                Export_permession xp = db.Export_permession.Find(int.Parse(comboBox11.Text), int.Parse(comboBox12.Text));
                if (xp != null)
                {

                    exp1.c_email = comboBox13.Text;
                    exp1.store_name = comboBox14.Text;
                    exp1.eper_date = date.Value;
                    db.SaveChanges();

                    int itemI = int.Parse(comboBox12.Text);
                    int perNO = int.Parse(comboBox11.Text);
                    string cmail2 = comboBox13.Text;
                    string cstname2 = comboBox14.Text;
                    int cqun1 = int.Parse(textBox42.Text);

                    db.expQ_update(itemI, perNO, cmail2, cstname2, cqun1); //procedure
                    db.SaveChanges();                  
                    db.MiniusImpQun_(cqun1, itemI, cstname2);
                    db.SaveChanges();
                    MessageBox.Show("the export permession is updated successfully");

                }
                else
                {
                    MessageBox.Show("The permession you have entered not exists");
                }
            }
            else
            {
                MessageBox.Show("please enter all data");
            }
        }
    }
}
