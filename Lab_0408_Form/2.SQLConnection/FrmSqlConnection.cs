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
using System.Configuration;
using Lab_0408_Form.Properties;

namespace Starter

{
    public partial class FrmSqlConnection : Form
    {
        public FrmSqlConnection()
        {
            InitializeComponent();
            this.tabPage1.BackColor = Settings.Default.MyBackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //step 1 : Sql Connection
            //step 2 : Sql Command
            //step 3 : Sql DataReader
            //step 4 : UI Control

            string conString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
                 
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    //step1  準備連線
                    conn.Open();  //開啟連接

                    //step 2  下指令
                    SqlCommand command = new SqlCommand("select * from products", conn);

                    //step3  讀取資料
                    SqlDataReader dataReader = command.ExecuteReader();                   
                    this.listBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        string s = $"{dataReader["ProductName"],-40} - {dataReader["UnitPrice"]:c2}";
                        this.listBox1.Items.Add(s);
                    }
                }  //Auto conn.lose();  他會自動關連接

            }
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message);  
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //step 1 : Sql Connection
            //step 2 : Sql Command
            //step 3 : Sql DataReader
            //step 4 : UI Control

            string conString = "Data Source=.;Initial Catalog=Northwind;User ID=sa;Password=sa";
            SqlConnection conn = null;  //因為finally要用，所以宣告在外面，並且先讓他=null代表空值
            try
            {
                //step1  準備連線
                conn = new SqlConnection(conString);
                conn.Open();  //開啟連接

                //step 2  下指令
                SqlCommand command = new SqlCommand("select * from products", conn);
                SqlDataReader dataReader = command.ExecuteReader();

                //step3  讀取資料
                this.listBox1.Items.Clear();
                while (dataReader.Read())
                {
                    string s = $"{dataReader["ProductName"],-40} - {dataReader["UnitPrice"]:c2}";
                    this.listBox1.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e) //測試是否有連線成功
        {  
            //step 1 : Sql Connection
            //step 2 : Sql Command
            //step 3 : Sql DataReader
            //step 4 : UI Control
            string conString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            try
            {
                SqlConnection conn = null;
                using (conn = new SqlConnection(conString))
                {
                    //step1  準備連線
                    conn.Open();  //開啟連接
                    MessageBox.Show(conn.State.ToString());

                    //step 2  下指令
                    SqlCommand command = new SqlCommand("select * from products", conn);

                    //step3  讀取資料
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.listBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        string s = $"{dataReader["ProductName"],-40} - {dataReader["UnitPrice"]:c2}";
                        this.listBox1.Items.Add(s);
                    }
                }  //Auto conn.lose();  他會自動關連接
                MessageBox.Show(conn.State.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.MyNWConnectionString;  
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    //step1  準備連線
                    conn.Open();  //開啟連接

                    //step 2  下指令
                    SqlCommand command = new SqlCommand("select * from products", conn);

                    //step3  讀取資料
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.listBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        string s = $"{dataReader["ProductName"],-40} - {dataReader["UnitPrice"]:c2}";
                        this.listBox1.Items.Add(s);
                    }
                }  //Auto conn.lose();  他會自動關連接

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["Lab_0408_Form.Properties.Settings.NorthwindConnectionString"].ConnectionString;  //[]裡面放app.config 的name

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    //step1  準備連線
                    conn.Open();  //開啟連接

                    //step 2  下指令
                    SqlCommand command = new SqlCommand("select * from products", conn);

                    //step3  讀取資料
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.listBox1.Items.Clear();
                    while (dataReader.Read())
                    {
                        string s = $"{dataReader["ProductName"],-40} - {dataReader["UnitPrice"]:c2}";
                        this.listBox1.Items.Add(s);
                    }
                }  //Auto conn.lose();  他會自動關連接

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.MyBackColor = this.tabPage1.BackColor = this.colorDialog1.Color;  //
                Settings.Default.Save();
            }
            
        }

        private void button58_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSection section = config.Sections["connectionStrings"];
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                config.Save();
                MessageBox.Show("加密成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                ConfigurationSection section = config.Sections["connectionStrings"];
                section.SectionInformation.UnprotectSection();
                config.Save();
                MessageBox.Show("解密成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
