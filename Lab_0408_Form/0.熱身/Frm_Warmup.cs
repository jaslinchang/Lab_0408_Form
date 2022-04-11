using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_0408_Form
{
    public partial class Frm_Warmup : Form
    {
        public Frm_Warmup()  //建構子方法
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hello
            MessageBox.Show("Hello , "+textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hi
            MessageBox.Show("Hi , " + textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //set property 
            label1.BackColor = Color.LightPink;
            label1.ForeColor = Color.DarkKhaki;

            button1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //當這個按鈕按下時，會讓裡面的內容被註冊，並告訴他們該指向的方法
            button4.Click += Button4_Click;  //指向Button4_Click 的這個方法
            button4.Click += aaa;  //指向aaa的這個方法
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //呼應btn5被按下
            MessageBox.Show("Hello button 4");
        }

        private void aaa(object sender, EventArgs e)  //建立一個aaa的方法
        {
            //呼應btn5被按下
            MessageBox.Show("aaa");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //呼叫一個Form1的新視窗
            Frm_Warmup f1= new Frm_Warmup();  //建立一個Form1的實體，並用變數f1代表他
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //static property
            MessageBox.Show(SystemInformation.ComputerName);

            //instance property
            button1.Text = "xxx";
            button2.Text = "yyy";

           // SystemInformation.ComputerName = "xxx";     //set property  --其為唯讀	
            string a = SystemInformation.ComputerName;      //get property-- 只能get 去得到值
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //static method
            File.Copy("a.txt", "a1.txt", true);  //複製第一個txt，新建第二個txt，如遇到相同檔名ㄉ則可以覆蓋他

            //-------------------------------------------------------
            //Instance method    
            FileInfo f = new FileInfo("b.txt");   //建立一個實體給他
            MessageBox.Show(f.FullName + "\n" + f.Extension + "\n" + f.CreationTime);  //呼叫 剛建立ㄉb.txt的
                
            f.CopyTo("b1.txt", true);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //更改表單標題的名字
            //Error  Demo 1 
            //錯誤  CS0120 需要有物件參考，才可使用非靜態欄位、方法或屬性
            //Form1.Text= "Hello , " + textBox1.Text;

            //Error   Demo 2 
            //錯在 現在會變成你打開新視窗的名稱改變，而不是更改到現在的main表單
            //Form1 f = new Form1();
            //f.Text= "Hello , " + textBox1.Text;
            //f.Show();

            //Right!!!    Demo  3
            this.Text = "Hello , " + this.textBox1.Text;   //最好在textbox上也加this ，代表抓的一定是現在這個表單的物件
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //關閉表單
            this.Close();
            //Close();
        }
    }
}