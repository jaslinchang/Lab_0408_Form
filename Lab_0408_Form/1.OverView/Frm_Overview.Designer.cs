
namespace Lab_0408_Form._1.OverView
{
    partial class Frm_Overview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Connected = new System.Windows.Forms.TabPage();
            this.Disconnected_Dataset = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.nwDataSet1 = new Lab_0408_Form.NWDataSet();
            this.productsTableAdapter1 = new Lab_0408_Form.NWDataSetTableAdapters.ProductsTableAdapter();
            this.categoriesTableAdapter1 = new Lab_0408_Form.NWDataSetTableAdapters.CategoriesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.Connected.SuspendLayout();
            this.Disconnected_Dataset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(25, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(42, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Items.AddRange(new object[] {
            "aaa",
            "bbb"});
            this.listBox1.Location = new System.Drawing.Point(143, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(611, 312);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Connected);
            this.tabControl1.Controls.Add(this.Disconnected_Dataset);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 624);
            this.tabControl1.TabIndex = 3;
            // 
            // Connected
            // 
            this.Connected.Controls.Add(this.listBox1);
            this.Connected.Controls.Add(this.button1);
            this.Connected.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connected.Location = new System.Drawing.Point(4, 28);
            this.Connected.Name = "Connected";
            this.Connected.Padding = new System.Windows.Forms.Padding(3);
            this.Connected.Size = new System.Drawing.Size(1054, 550);
            this.Connected.TabIndex = 0;
            this.Connected.Text = "Connected";
            this.Connected.UseVisualStyleBackColor = true;
            // 
            // Disconnected_Dataset
            // 
            this.Disconnected_Dataset.Controls.Add(this.button6);
            this.Disconnected_Dataset.Controls.Add(this.label4);
            this.Disconnected_Dataset.Controls.Add(this.label3);
            this.Disconnected_Dataset.Controls.Add(this.dataGridView2);
            this.Disconnected_Dataset.Controls.Add(this.button5);
            this.Disconnected_Dataset.Controls.Add(this.label2);
            this.Disconnected_Dataset.Controls.Add(this.label1);
            this.Disconnected_Dataset.Controls.Add(this.button4);
            this.Disconnected_Dataset.Controls.Add(this.button3);
            this.Disconnected_Dataset.Controls.Add(this.dataGridView1);
            this.Disconnected_Dataset.Controls.Add(this.button2);
            this.Disconnected_Dataset.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnected_Dataset.Location = new System.Drawing.Point(4, 28);
            this.Disconnected_Dataset.Name = "Disconnected_Dataset";
            this.Disconnected_Dataset.Padding = new System.Windows.Forms.Padding(3);
            this.Disconnected_Dataset.Size = new System.Drawing.Size(1054, 592);
            this.Disconnected_Dataset.TabIndex = 1;
            this.Disconnected_Dataset.Text = "Disconnected_Dataset";
            this.Disconnected_Dataset.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ado.Net 1.0 - Sql Data Adapter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ado.Net 2.0 - xxx Table Adapter";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(332, 306);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(681, 248);
            this.dataGridView2.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(42, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 39);
            this.button5.TabIndex = 7;
            this.button5.Text = "Product";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(39, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(974, 11);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Disconnect";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(42, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Product-price>30";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(42, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Disconnect-Categories\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 248);
            this.dataGridView1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1054, 550);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(42, 413);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(203, 39);
            this.button6.TabIndex = 11;
            this.button6.Text = "Categories";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // nwDataSet1
            // 
            this.nwDataSet1.DataSetName = "NWDataSet";
            this.nwDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 624);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Overview";
            this.Text = "Frm_Overview";
            this.tabControl1.ResumeLayout(false);
            this.Connected.ResumeLayout(false);
            this.Disconnected_Dataset.ResumeLayout(false);
            this.Disconnected_Dataset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Connected;
        private System.Windows.Forms.TabPage Disconnected_Dataset;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private NWDataSet nwDataSet1;
        private NWDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private NWDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private System.Windows.Forms.Button button6;
    }
}