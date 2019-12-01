namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.TextBox();
            this.A1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.B3 = new System.Windows.Forms.TextBox();
            this.B2 = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.O2 = new System.Windows.Forms.TextBox();
            this.O3 = new System.Windows.Forms.TextBox();
            this.O4 = new System.Windows.Forms.TextBox();
            this.O1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.C1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(861, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "          Library Manage System          ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(437, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(831, 408);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.BtnDelete_Click_Book);
            // 
            // C1
            // 
            this.C1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.C1.Controls.Add(this.tabPage1);
            this.C1.Controls.Add(this.tabPage2);
            this.C1.Controls.Add(this.tabPage3);
            this.C1.Controls.Add(this.tabPage4);
            this.C1.Location = new System.Drawing.Point(12, 71);
            this.C1.Multiline = true;
            this.C1.Name = "C1";
            this.C1.SelectedIndex = 0;
            this.C1.Size = new System.Drawing.Size(1282, 425);
            this.C1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.A3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.A2);
            this.tabPage1.Controls.Add(this.A1);
            this.tabPage1.Location = new System.Drawing.Point(22, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(1256, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book";
            this.tabPage1.UseWaitCursor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.Call_Book);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(230, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 46);
            this.button5.TabIndex = 15;
            this.button5.Text = "변경";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.Book_Update);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(47, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 46);
            this.button4.TabIndex = 13;
            this.button4.Text = "삽입";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.Book_Insert);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(203, 149);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(169, 21);
            this.A3.TabIndex = 5;
            this.A3.UseWaitCursor = true;
            this.A3.TextChanged += new System.EventHandler(this.Book_Price);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(47, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(47, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Publisher";
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(47, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bookname";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(203, 90);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(169, 21);
            this.A2.TabIndex = 1;
            this.A2.UseWaitCursor = true;
            this.A2.TextChanged += new System.EventHandler(this.Book_Publisher);
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(203, 39);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(169, 21);
            this.A1.TabIndex = 0;
            this.A1.UseWaitCursor = true;
            this.A1.TextChanged += new System.EventHandler(this.Book_Bookname);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.B3);
            this.tabPage2.Controls.Add(this.B2);
            this.tabPage2.Controls.Add(this.B1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(22, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(199, 179);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(169, 21);
            this.B3.TabIndex = 24;
            this.B3.UseWaitCursor = true;
            this.B3.TextChanged += new System.EventHandler(this.Customer_Phone);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(199, 115);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(169, 21);
            this.B2.TabIndex = 23;
            this.B2.UseWaitCursor = true;
            this.B2.TextChanged += new System.EventHandler(this.Customer_Address);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(199, 49);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(169, 21);
            this.B1.TabIndex = 22;
            this.B1.UseWaitCursor = true;
            this.B1.TextChanged += new System.EventHandler(this.Customer_Name);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(64, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Phone";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(64, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Address";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(64, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name";
            this.label5.UseWaitCursor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(33, 327);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(142, 46);
            this.button8.TabIndex = 18;
            this.button8.Text = "삽입";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.UseWaitCursor = true;
            this.button8.Click += new System.EventHandler(this.Customer_Insert);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(33, 254);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(142, 46);
            this.button7.TabIndex = 17;
            this.button7.Text = "조회";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Call_Customer);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(226, 327);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 46);
            this.button6.TabIndex = 16;
            this.button6.Text = "변경";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.UseWaitCursor = true;
            this.button6.Click += new System.EventHandler(this.Customer_Update);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnDelete_Click_Customer);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(435, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(833, 387);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.O2);
            this.tabPage3.Controls.Add(this.O3);
            this.tabPage3.Controls.Add(this.O4);
            this.tabPage3.Controls.Add(this.O1);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button12);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(22, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1256, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Orders";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // O2
            // 
            this.O2.Location = new System.Drawing.Point(216, 112);
            this.O2.Name = "O2";
            this.O2.Size = new System.Drawing.Size(169, 21);
            this.O2.TabIndex = 29;
            this.O2.UseWaitCursor = true;
            this.O2.TextChanged += new System.EventHandler(this.Orders_Bookid);
            // 
            // O3
            // 
            this.O3.Location = new System.Drawing.Point(216, 162);
            this.O3.Name = "O3";
            this.O3.Size = new System.Drawing.Size(169, 21);
            this.O3.TabIndex = 28;
            this.O3.UseWaitCursor = true;
            this.O3.TextChanged += new System.EventHandler(this.Orders_Saleprice);
            // 
            // O4
            // 
            this.O4.Location = new System.Drawing.Point(216, 211);
            this.O4.Name = "O4";
            this.O4.Size = new System.Drawing.Size(169, 21);
            this.O4.TabIndex = 27;
            this.O4.UseWaitCursor = true;
            this.O4.TextChanged += new System.EventHandler(this.Orders_Orderdate);
            // 
            // O1
            // 
            this.O1.Location = new System.Drawing.Point(216, 56);
            this.O1.Name = "O1";
            this.O1.Size = new System.Drawing.Size(169, 21);
            this.O1.TabIndex = 26;
            this.O1.UseWaitCursor = true;
            this.O1.TextChanged += new System.EventHandler(this.Orders_Custid);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(56, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Bookid";
            this.label11.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(56, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Saleprice";
            this.label10.UseWaitCursor = true;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(56, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Orderdate";
            this.label9.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(56, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Custid";
            this.label8.UseWaitCursor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(243, 338);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(142, 46);
            this.button12.TabIndex = 21;
            this.button12.Text = "변경";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.UseWaitCursor = true;
            this.button12.Click += new System.EventHandler(this.Orders_Update);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(37, 338);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(142, 46);
            this.button11.TabIndex = 20;
            this.button11.Text = "삽입";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.UseWaitCursor = true;
            this.button11.Click += new System.EventHandler(this.Orders_Insert);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(243, 265);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(142, 46);
            this.button10.TabIndex = 19;
            this.button10.Text = "삭제";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.BtnDelete_Click_Orders);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(37, 265);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 46);
            this.button9.TabIndex = 18;
            this.button9.Text = "조회";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Call_Orders);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(438, 9);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(833, 387);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.comboBox2);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(22, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1256, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Search";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(38, 150);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(144, 58);
            this.button13.TabIndex = 9;
            this.button13.Text = "Search";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Search);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 132);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(35, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(423, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(833, 387);
            this.dataGridView4.TabIndex = 4;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(236, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Made by REX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 523);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.C1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl C1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox A3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox B1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox B2;
        private System.Windows.Forms.TextBox B3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox O2;
        private System.Windows.Forms.TextBox O3;
        private System.Windows.Forms.TextBox O4;
        private System.Windows.Forms.TextBox O1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label12;
    }
}

