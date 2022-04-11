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
            //dataGridView1.SelectedRows
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
        {
            this.categoriesTableAdapter1.Fill(nwDataSet1.Categories);
            this.dataGridView2.DataSource = this.nwDataSet1.Categories;
        }
    }
}
