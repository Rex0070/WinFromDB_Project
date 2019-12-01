using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataSet dataSet;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load(@"C:\Users\rex97\Documents\Visual Studio 2017\Projects\WindowsFormsApp1\WindowsFormsApp1\ricardo.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string con = "server=localhost;database=mydb;uid=root;pwd=iamperfectman007";
            conn = new MySqlConnection(con);
            dataSet = new DataSet();
            
            
            conn.Open();
            comboBox1.Items.Add("Item 1");
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "book", "customer", "orders" });
        }









        private void BtnInsert_Click(object sender, EventArgs e)
        {

        }



        private void BtnChange_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            A1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            A2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            A3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            B1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            B2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            B3.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            O1.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            O2.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            O3.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            O4.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Book_Bookname(object sender, EventArgs e)
        {

        }

        private void Book_Publisher(object sender, EventArgs e)
        {

        }
        private void Book_Price(object sender, EventArgs e)
        {

        }

        private void Call_Book(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("select * from book", conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "book");
            dataGridView1.DataSource = dataSet.Tables["book"];
        }

        private void Call_Customer(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("select * from customer", conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "customer");
            dataGridView2.DataSource = dataSet.Tables["customer"];
        }

        private void Call_Orders(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("select * from orders", conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "orders");
            dataGridView3.DataSource = dataSet.Tables["orders"];
        }
        private void BtnDelete_Click_Book(object sender, EventArgs e)
        {
            /* 
            DialogResult result = MessageBox.Show("정말 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if (result == DialogResult.Yes)
             {


                 for (int i = dataGridView1.RowCount - 1; i > 0; i--)
                 {
                     if (dataGridView1.Rows[i].Selected == true)
                         dataGridView1.Rows.RemoveAt(i);

                     string queryString = $"DELETE FROM book WHERE id='{dataGridView1.Rows}'";


                 }
             }
             */
            string sql = "DELETE FROM book WHERE bookid=@bookid";
            adapter.DeleteCommand = new MySqlCommand(sql, conn);
            int id = (int)dataGridView1.SelectedRows[0].Cells["bookid"].Value;
            adapter.DeleteCommand.Parameters.AddWithValue("@bookid", id);


            if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
            {
                dataSet.Clear();
                adapter.Fill(dataSet, "book");
                dataGridView1.DataSource = dataSet.Tables["book"];
            }
            else
            {
                MessageBox.Show("삭제된 데이터가 없습니다.");
            }

        }

        private void BtnDelete_Click_Customer(object sender, EventArgs e)
        {
            string sql = "DELETE FROM customer WHERE custid=@custid";
            adapter.DeleteCommand = new MySqlCommand(sql, conn);
            int id = (int)dataGridView2.SelectedRows[0].Cells["custid"].Value;
            adapter.DeleteCommand.Parameters.AddWithValue("@custid", id);


            if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
            {
                dataSet.Clear();
                adapter.Fill(dataSet, "customer");
                dataGridView1.DataSource = dataSet.Tables["customer"];
            }
            else
            {
                MessageBox.Show("삭제된 데이터가 없습니다.");
            }
        }

        private void BtnDelete_Click_Orders(object sender, EventArgs e)
        {
            string sql = "DELETE FROM orders WHERE orderid=@orderid";
            adapter.DeleteCommand = new MySqlCommand(sql, conn);
            int id = (int)dataGridView3.SelectedRows[0].Cells["orderid"].Value;
            adapter.DeleteCommand.Parameters.AddWithValue("@orderid", id);

            if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
            {
                dataSet.Clear();
                adapter.Fill(dataSet, "orders");
                dataGridView1.DataSource = dataSet.Tables["orders"];
            }
            else
            {
                MessageBox.Show("삭제된 데이터가 없습니다.");
            }
        }

        private void Customer_Name(object sender, EventArgs e)
        {

        }

        private void Customer_Address(object sender, EventArgs e)
        {

        }

        private void Customer_Phone(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Orders_Custid(object sender, EventArgs e)
        {

        }

        private void Orders_Bookid(object sender, EventArgs e)
        {

        }

        private void Orders_Saleprice(object sender, EventArgs e)
        {

        }

        private void Orders_Orderdate(object sender, EventArgs e)
        {

        }



        private void Book_Insert(object sender, EventArgs e)
        {

            string query = "insert into book (bookname, publisher, price) values(@bookname, @publisher, @price)";
            MySqlCommand insertCommand = new MySqlCommand(query, conn);

            adapter.InsertCommand = new MySqlCommand(query, conn);
            adapter.InsertCommand.Parameters.AddWithValue("@bookname", A1.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@publisher", A2.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@price", A3.Text);

            DataRow newRow = dataSet.Tables["book"].NewRow();
            newRow["bookname"] = A1.Text;
            newRow["publisher"] = A2.Text;
            newRow["price"] = A3.Text;


            dataSet.Tables["book"].Rows.Add(newRow);
            try
            {
                adapter.Update(dataSet, "book");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void Customer_Insert(object sender, EventArgs e)
        {
            string query = "insert into customer (name, address, phone) values(@name, @address, @phone)";
            MySqlCommand insertCommand = new MySqlCommand(query, conn);

            adapter.InsertCommand = new MySqlCommand(query, conn);
            adapter.InsertCommand.Parameters.AddWithValue("@name", B1.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@address", B2.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@phone", B3.Text);

            DataRow newRow = dataSet.Tables["customer"].NewRow();
            newRow["name"] = B1.Text;
            newRow["address"] = B2.Text;
            newRow["phone"] = B3.Text;


            dataSet.Tables["customer"].Rows.Add(newRow);
            try
            {
                adapter.Update(dataSet, "customer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Orders_Insert(object sender, EventArgs e)
        {
            string query = "insert into orders (saleprice, orderdate) values(@saleprice, @orderdate)";
            MySqlCommand insertCommand = new MySqlCommand(query, conn);

            adapter.InsertCommand = new MySqlCommand(query, conn);
            adapter.InsertCommand.Parameters.AddWithValue("@saleprice", O3.Text);
            adapter.InsertCommand.Parameters.AddWithValue("@orderdate", O4.Text);


            DataRow newRow = dataSet.Tables["orders"].NewRow();
            newRow["saleprice"] = O3.Text;
            newRow["orderdate"] = O4.Text;



            dataSet.Tables["orders"].Rows.Add(newRow);
            try
            {
                adapter.Update(dataSet, "orders");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void Book_Update(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells["bookid"].Value;

            //adapter = new MySqlDataAdapter($"UPDATE book SET bookname= { A1.Text } , publisher= { A2.Text } , price= { A3.Text }  WHERE bookid= { id }",conn);
            //adapter.UpdateCommand = new MySqlCommand();
            string query = "UPDATE book SET bookname=@bookname,publisher=@publisher, price=@price WHERE bookid=@bookid";

            adapter.UpdateCommand = new MySqlCommand(query, conn);
            adapter.UpdateCommand.Parameters.AddWithValue("@bookid", id);
            adapter.UpdateCommand.Parameters.AddWithValue("@bookname", A1.Text);
            adapter.UpdateCommand.Parameters.AddWithValue("@publisher", A2.Text);
            adapter.UpdateCommand.Parameters.AddWithValue("@price", A3.Text);


            string filter = "bookid=" + id;
            DataRow[] findRows = dataSet.Tables["book"].Select(filter);
            findRows[0]["bookid"] = id;
            findRows[0]["bookname"] = A1.Text;
            findRows[0]["publisher"] = A2.Text;
            findRows[0]["price"] = A3.Text;

            
            adapter.Update(dataSet,"book");
            


        }
        private void Customer_Update(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.SelectedRows[0].Cells["custid"].Value;

            string query = "UPDATE customer SET name=@name,address=@address, phone=@phone WHERE custid=@custid";

            adapter.UpdateCommand = new MySqlCommand(query, conn);
            adapter.UpdateCommand.Parameters.AddWithValue("@custid", id);
            adapter.UpdateCommand.Parameters.AddWithValue("@name", B1.Text);
            adapter.UpdateCommand.Parameters.AddWithValue("@address", B2.Text);
            adapter.UpdateCommand.Parameters.AddWithValue("@phone", B3.Text);


            string filter = "custid=" + id;
            DataRow[] findRows = dataSet.Tables["customer"].Select(filter);
            findRows[0]["custid"] = id;
            findRows[0]["name"] = B1.Text;
            findRows[0]["address"] = B2.Text;
            findRows[0]["phone"] = B3.Text;

            adapter.Update(dataSet, "customer");
        }
        private void Orders_Update(object sender, EventArgs e)
        {
            int id = (int)dataGridView3.SelectedRows[0].Cells["orderid"].Value;

            string query = "UPDATE orders SET saleprice=@saleprice, orderdate=@orderdate WHERE orderid=@orderid";

            adapter.UpdateCommand = new MySqlCommand(query, conn);
            adapter.UpdateCommand.Parameters.AddWithValue("@orderid", id);
            adapter.UpdateCommand.Parameters.AddWithValue("@saleprice", O3.Text);
            adapter.UpdateCommand.Parameters.AddWithValue("@orderdate", O4.Text);


            string filter = "orderid=" + id;
            DataRow[] findRows = dataSet.Tables["orders"].Select(filter);
            findRows[0]["orderid"] = id;
            findRows[0]["saleprice"] = O3.Text;
            findRows[0]["orderdate"] = O4.Text;


            adapter.Update(dataSet, "orders");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("bookname");
                comboBox2.Items.Add("publisher");
                comboBox2.Items.Add("price");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("name");
                comboBox2.Items.Add("address");
                comboBox2.Items.Add("phone");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("custid");
                comboBox2.Items.Add("bookid");
                comboBox2.Items.Add("saleprice");
                comboBox2.Items.Add("orderdate");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
     
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search(object sender, EventArgs e)
        {
            
            adapter = new MySqlDataAdapter($"select {comboBox2.SelectedItem.ToString()} from {comboBox1.SelectedItem.ToString()}", conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet, comboBox1.SelectedIndex.ToString());
            dataGridView4.DataSource = dataSet.Tables[comboBox1.SelectedIndex.ToString()];
            
        }
        
    }
}
