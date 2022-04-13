using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab_0408_Form._1.OverView
{
    public partial class Frm_Overview : Form
    {
        public Frm_Overview()
        {
            InitializeComponent();
            //this.tabControl1.SelectedIndex = this.tabControl1.TabCount -1;
            this.tabControl1.SelectedIndex = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //step 1 : Sql Connection
            //step 2 : Sql Command
            //step 3 : Sql DataReader
            //step 4 : UI Control

            SqlConnection conn = null;  //因為finally要用，所以宣告在外面，並且先讓他=null代表空值
            try  
            {
                //step1  準備連線
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();  //開啟連接

                //step 2  下指令
                SqlCommand command = new SqlCommand ( "select * from products", conn);
                SqlDataReader  dataReader= command.ExecuteReader();

                //step3  讀取資料
                this.listBox1.Items.Clear();  
                while (dataReader.Read())  //當DataReader 為true，就做下面的事情
                {   
                    //--使用字串
                    string s = $"{dataReader["ProductName"],-40} - {dataReader["UnitPrice"]:c2}";
                    this.listBox1.Items.Add(s);

                    //--直接等於值
                    //因為他有多筆資料，並且因為加進去的都是object物件，所以在最後一個改成字串即可
                    //this.listBox1.Items.Add(dataReader["ProductName"] + dataReader["UnitPrice"].ToString());
                }

                //--當只要讀一行的時候
                //dataReader.Read();  //因為原本在最begin 的位置(那邊沒有資料)，然後讓他讀下一行的資料

                //step4  使用UI展現控制項
                //MessageBox.Show(dataReader["ProductName"].ToString());

            
            }
            catch(Exception ex)  //保護程式，抓一些無法掌控的錯誤
            {
                MessageBox.Show(ex.Message);  //show 錯誤的提示訊息
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();  //斷開連接
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //step 1 : Sql Connection
            //step 2 : Sql DataAdapter
            //step 3 : DataSet - In memory DB
            //step 4 : UI Control  -DataGridView- table
            
            //step 1 先連結
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            
            //step 2 下指令 (轉接頭) 
            SqlDataAdapter adapter=new SqlDataAdapter("select * from products", conn);

            //step 3 dataset記憶體中的 database，所以宣告一個變數存進去
            DataSet ds = new DataSet();
            
            //Auto connect  : conn.open() =>SqlCommand.Execute("Select*  ...")  =>while DataReader.Read()  =>conn.Close();
            adapter.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn=new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Categories",conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");

            //step 2 下指令 (轉接頭) 
            SqlDataAdapter adapter = new SqlDataAdapter("select * from products where UnitPrice>30 order by unitprice", conn);

            //step 3 dataset記憶體中的 database，所以宣告一個變數存進去
            DataSet ds = new DataSet();

            //Auto connect  : conn.open() =>SqlCommand.Execute("Select*  ...")  =>while DataReader.Read()  =>conn.Close();
            adapter.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Auto connect  : conn.open() =>SqlCommand.Execute("Select*  ...")  =>while DataReader.Read()  =>conn.Close();
            this.productsTableAdapter1.Fill(nwDataSet1.Products);  //從dataset裡拿

            this.dataGridView2.DataSource = this.nwDataSet1.Products;
        }

        private void button6_Click(object sender, EventArgs e)
        { //查詢categories資料表
            this.categoriesTableAdapter1.Fill(nwDataSet1.Categories);
            this.dataGridView2.DataSource = this.nwDataSet1.Categories;
        }

        private void button7_Click(object sender, EventArgs e)
        {  //查詢customers資料表
            this.customersTableAdapter1.Fill(nwDataSet1.Customers);
            this.dataGridView2.DataSource = this.nwDataSet1.Customers;
        }

        private void button8_Click(object sender, EventArgs e)
        {  //查詢產品價格>30
            this.productsTableAdapter1.FillByUnitPrice(nwDataSet1.Products, 30);  //使用方法呼叫
            this.dataGridView2.DataSource = this.nwDataSet1.Products;
        }

        private void button9_Click(object sender, EventArgs e)
        {  //新增一筆資料到產品
            this.productsTableAdapter1.MyInsertProduct("xxx", true, 100);  //使用方法呼叫，內容值直接打所設參數的值
            this.dataGridView2.DataSource = this.nwDataSet1.Products;
        }

        private void button10_Click(object sender, EventArgs e)
        {  //更新資料表
            this.productsTableAdapter1.Update(this.nwDataSet1.Products);  
        }

        //PAGE 3 Binding Sourse

        private void button15_Click(object sender, EventArgs e)
        {
            //product
            //this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            ////this.dataGridView3.DataSource = this.nwDataSet1.Products;

            //this.bindingSource1.DataSource = this.nwDataSet1.Products;   
            //this.dataGridView3.DataSource = this.bindingSource1;  //把datagrid的資料存到binding source
            ////this.label5.Text = $"{this.bindingSource1.Position + 1} / { this.bindingSource1.Count}";
           
            //catorgies
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.bindingSource1.DataSource = this.nwDataSet1.Categories;
            this.dataGridView3.DataSource = this.bindingSource1;

            this.textBox1.DataBindings.Add("Text", this.bindingSource1, "CategoryName");
            this.pictureBox1.DataBindings.Add("image", this.bindingSource1, "picture", true);

            //bindingnavigator
            this.bindingNavigator1.BindingSource = this.bindingSource1;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position= 0;
            //this.label5.Text = $"{this.bindingSource1.Position+1} / { this.bindingSource1.Count}";  //因為第一個是0，所以位置要記得+1
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //this.bindingSource1.Position -= 1;
            this.bindingSource1.MovePrevious();
            //this.label5.Text = $"{this.bindingSource1.Position + 1} / { this.bindingSource1.Count}";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //this.bindingSource1.Position += 1;
            this.bindingSource1.MoveNext();
            //this.label5.Text = $"{this.bindingSource1.Position + 1} / { this.bindingSource1.Count}";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = this.bindingSource1.Count-1;
            //this.label5.Text = $"{this.bindingSource1.Position + 1} / { this.bindingSource1.Count}";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {  //註冊當binding的事件有改變時，就執行他
            this.label5.Text = $"{this.bindingSource1.Position + 1} / { this.bindingSource1.Count}";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FrmTool ft = new FrmTool();
            ft.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //連線呼叫資料庫
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.customersTableAdapter1.Fill(nwDataSet1.Customers);

            this.dataGridView4.DataSource = this.nwDataSet1.Categories;
            this.dataGridView5.DataSource = this.nwDataSet1.Products;
            this.dataGridView6.DataSource = this.nwDataSet1.Customers;

            //=============================================
            this.listBox2.Items.Clear();
            
            //Column schema
            //叫資料表出來       
            for(int i = 0; i < this.nwDataSet1.Tables.Count ; i++)
            {
                DataTable table= this.nwDataSet1.Tables[i];  //設一個變數把table存在裡面
                this.listBox2.Items.Add(table.TableName);

                //叫資料表內的欄位  Column
                string s = "";
                for(int column = 0; column < table.Columns.Count ; column++)  //當column<那個資料表內的欄位數時
                {
                    s += table.Columns[column].ColumnName + "  ";  //取得集合的name
                }
                this.listBox2.Items.Add(s);

                //叫資料表的行數  //Rows
                //for (int row = 0; row < table.Rows.Count; row++)
                //{
                //    this.listBox2.Items.Add(table.Rows[row][0]);  //呼叫第幾個row的第幾個資料行
                //}
                string a = "";
                for (int row = 0; row < table.Rows.Count; row++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {

                        a += table.Rows[row][k].ToString();
                        this.listBox2.Items.Add(a);
                    }

                }

                this.listBox2.Items.Add("=================================");
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {  //抓product資料表第一個欄位的productname
            //weak type
            MessageBox.Show(this.nwDataSet1.Products.Rows[0]["productname"].ToString());
            MessageBox.Show(this.nwDataSet1.Products.Rows[0][1].ToString());
            //strong type
            MessageBox.Show(this.nwDataSet1.Products[0].ProductName);
        }

        private void button19_Click(object sender, EventArgs e)
        {  //寫XML檔，預設會存在跟exe同樣的地點
            this.nwDataSet1.Products.WriteXml("Product.xml", XmlWriteMode.WriteSchema);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.nwDataSet1.Clear();
            this.nwDataSet1.Products.ReadXml("Product.xml");
            this.dataGridView5.DataSource = this.nwDataSet1.Products;
        }
    }
}
