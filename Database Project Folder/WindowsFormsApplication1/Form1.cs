using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        //Dictionary<int, string> techList = new Dictionary<int, string>();

        List<string> techList = new List<string>();
        //Create a list of techs for display
        //List<string> techList = new List<string>();
        //create a list of items for display
        List<string> itemList = new List<string>();
        // create a list of items used
        List<ItemsUsed> itemsUsedList = new List<ItemsUsed>();

        //create a list of scheduled techs
        List<ScheduledTechs> schedTechsList = new List<ScheduledTechs>();
        //Create a binding source to bind data obtained from the database
        BindingSource bs = new BindingSource();
        BindingSource bs1 = new BindingSource();
      



        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electricutilityDataSet1.ticketstatus' table. You can move, or remove it, as needed.
            this.ticketstatusTableAdapter.Fill(this.electricutilityDataSet1.ticketstatus);
            // TODO: This line of code loads data into the 'electricutilityDataSet.prio' table. You can move, or remove it, as needed.
            this.prioTableAdapter.Fill(this.electricutilityDataSet.prio);
            //Connection code to connect to the MySQL database
            String myCon = @"Server = localhost; Database = electricutility; Uid = root; Pwd = password;";
            MySqlConnection connection = new MySqlConnection(myCon);


            MySqlDataReader reader = null;



            try
            {
                connection.Open();
                // MessageBox.Show("Connection Established");
                String cmdText = "select * from itemtable";
                MySqlCommand cmd = new MySqlCommand(cmdText, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(1));
                    itemList.Add(reader.GetString(1));

                }

            }
            catch (MySqlException err)
            {
                Console.WriteLine("Error : " + err.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();

                }
                if (connection != null)
                {
                    connection.Close();

                }
            }
            // End of the connection to the database

            bs.DataSource = itemList;
            listBox3.DataSource = bs;
            listBox3.Update();



            
            //try
            //{
            //    connection.Open();
            //    // MessageBox.Show("Connection Established");
            //    //String cmdText = "select * from tech";
            //    String cmdText = " select t.techId, t.name " + 
            //        " from tech t " + 
            //        " where t.techId not in (select t.techId from tech t " +
            //        " join schedule s " +
            //        " on t.techId = s.techId " +
            //        " where onDate = @Date " +
            //        " );";

            //    MySqlCommand cmd = new MySqlCommand(cmdText, connection);
            //    cmd.Parameters.Add("@Date", MySqlDbType.Date).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //    reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        //Console.Write(reader.GetString(0));
            //        Console.WriteLine(reader.GetString(1));
            //        //techList.Add(Convert.ToInt32(reader.GetString(0)),reader.GetString(1));
            //        techList.Add(reader.GetString(1));

            //    }

            //}
            //catch (MySqlException err)
            //{
            //    Console.WriteLine("Error : " + err.ToString());
            //}
            //finally
            //{
            //    if (reader != null)
            //    {
            //        reader.Close();

            //    }
            //    if (connection != null)
            //    {
            //        connection.Close();

            //    }
            //}


            //bs1.DataSource = techList;
            //listBox1.DataSource = bs1;
            //listBox1.Update();



            textBox1.Text = "15156516156";
            textBox1.Enabled = false;

            //this.comboBox1.Items.Add("HIGH");
            //this.comboBox1.Items.Add("MEDIUM");
            //this.comboBox1.Items.Add("LOW");

            //this.comboBox2.Items.Add("OPEN");
            //this.comboBox2.Items.Add("PENDING");
            //this.comboBox2.Items.Add("CLOSED");



            numericUpDown1.Value = 0;
            numericUpDown1.Maximum = 10;
            numericUpDown1.Minimum = 0;

            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket Created");
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Text = listBox3.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String item = textBox10.Text;
            short qty = (short) numericUpDown1.Value;

           // Console.WriteLine(item + "\t" + qty);
            itemsUsedList.Add(new ItemsUsed(item, qty));



            // create a binging datasource for itemsUsed
            BindingSource itemsUsed_bs = new BindingSource();
            itemsUsed_bs.DataSource = itemsUsedList;
            dataGridView1.DataSource = itemsUsed_bs;
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = dataGridView1.SelectedRows[0].Index;
                
                if (idx >= 0)
                {
                    dataGridView1.Rows.RemoveAt(idx);
                    dataGridView1.Update();
                }
                /*else
                {
                    MessageBox.Show("The DataGridView is Empty");
                }*/
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("There is nothing to remove.");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("You picked up " + dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            
            //Connection code to connect to the MySQL database
            String myCon = @"Server = localhost; Database = electricutility; Uid = root; Pwd = password;";
            MySqlConnection connection = new MySqlConnection(myCon);


            MySqlDataReader reader = null;

            //foreach (String t in techList)
            //{
            //    techList.Remove(t);
            //}
            techList = new List<String>();

            try
            {
                connection.Open();
                // MessageBox.Show("Connection Established");
                //String cmdText = "select * from tech";
                String cmdText = " select t.techId, t.name " +
                    " from tech t " +
                    " where t.techId not in (select t.techId from tech t " +
                    " join schedule s " +
                    " on t.techId = s.techId " +
                    " where onDate = @Date " +
                    " );";

                MySqlCommand cmd = new MySqlCommand(cmdText, connection);
                cmd.Parameters.Add("@Date", MySqlDbType.Date).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Console.Write(reader.GetString(0));
                    Console.WriteLine("\n\n");
                    Console.WriteLine(reader.GetString(1));
                    //techList.Add(Convert.ToInt32(reader.GetString(0)),reader.GetString(1));
                    techList.Add(reader.GetString(1));

                }

            }
            catch (MySqlException err)
            {
                Console.WriteLine("Error : " + err.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();

                }
                if (connection != null)
                {
                    connection.Close();

                }
            }


            bs1.DataSource = techList;
            listBox1.DataSource = bs1;
            listBox1.Update();

        }








        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            textBox8.Text = listBox1.SelectedItem.ToString();
            List<string> newList = new List<string>();
            // This method is supposed to return a list of expertise for the selected tech
           
            newList = getTechExpertise(listBox1.SelectedItem.ToString());
            BindingSource techExpertise_bs = new BindingSource();
            techExpertise_bs.DataSource = newList;
            listBox2.DataSource = techExpertise_bs;
            listBox2.Refresh();
            // Working on a prototype for this method
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string techName = textBox8.Text;
            DateTime date = dateTimePicker1.Value;
            bool am, pm;
            if (checkBox1.Checked)
            {
                 am = true;
            }
            else
            {
                 am = false;
            }

            if (checkBox2.Checked)
            {
                 pm = true;
            }
            else
            {
                 pm = false;
            }
            schedTechsList.Add(new ScheduledTechs(techName, date, am, pm));

            // create a binging datasource for scheduledTechsList
            BindingSource schedTechs_bs = new BindingSource();
            schedTechs_bs.DataSource = schedTechsList;
            dataGridView2.DataSource = schedTechs_bs;
            dataGridView2.Refresh();

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
           try
            {
                int idx = dataGridView2.SelectedRows[0].Index;

                if (idx >= 0)
                {
                    dataGridView2.Rows.RemoveAt(idx);
                    dataGridView2.Update();
                }
            }
            
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There is nothing to remove.");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       //method to query the customer in the database 
        //public void findCustomer(String name)


        //method to get the list of expertise for a selected tech
        public List<string> getTechExpertise(string name)
        {
            //Connection code to connect to the MySQL database
            String myCon = @"Server = localhost; Database = electricutility; Uid = root; Pwd = password;";
            MySqlConnection connection = new MySqlConnection(myCon);
            List<String> skillList = new List<string>();

            MySqlDataReader reader = null;
            

            try{
                connection.Open();
                //string cmdText = "select description, name from expertise e " +
                //    " join techexpertise te " +
                //    " on e.expertiseId = te.expertiseId " + 
                //    " join tech t " +
                //    " on t.techId = te.techId " +
                //    " where name = @Name "  ;
                


                // use the view Created in MySQL
                string cmdText = "select description from techspeciality where name = @Name " ;

                MySqlCommand cmd = new MySqlCommand(cmdText, connection);
                cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 20).Value = textBox8.Text;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                    skillList.Add(reader.GetString(0));

                }

            }
            catch (MySqlException err)
            {
                Console.WriteLine("Error : " + err.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();

                }
                if (connection != null)
                {
                    connection.Close();

                }
            }

            return skillList;
        }

        


        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show(textBox2.Text);
                getCustomer(textBox2.Text);
            }
        }

        public void getCustomer(String name)
        {
            //MessageBox.Show("UH Oh!! This method is complete yet!! Sorry Pal!! ");


            //Connection code to connect to the MySQL database

            //String myCon = @"server=206.176.2.186;user id=yadav;persistsecurityinfo=True;database=db_class;";
            
            String myCon = @"Server = localhost; Database = electricutility; Uid = root; Pwd = password;";
            MySqlConnection connection = new MySqlConnection(myCon);
            //List<String> customerList = new List<string>();

            MySqlDataReader reader = null;


            try
            {
                connection.Open();
                
                // use the view Created in MySQL
                string cmdText = "SELECT * FROM CustomerDetails WHERE name = @Name ";

                MySqlCommand cmd = new MySqlCommand(cmdText, connection);
                cmd.Parameters.Add("@Name", MySqlDbType.VarChar, 20).Value = textBox2.Text;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox3.Text = reader.GetString(0) ;
                    textBox5.Clear();

                    if (!(reader["address1"] is DBNull))
                    {
                        textBox5.Text += reader.GetString(1) + Environment.NewLine;
                    }


                    if (!(reader["address2"] is DBNull))
                    {
                        textBox5.Text += reader.GetString(2) + Environment.NewLine;
                    }
                    else
                    {
                        textBox5.Text = " ";
                    }


                    if (!(reader["cityState"] is DBNull))
                    {
                        textBox5.Text += reader.GetString(3) + Environment.NewLine;
                    }
                    else
                    {
                        textBox5.Text = " ";
                    }



                    
                    //textBox5.Text += reader.GetString(1) + Environment.NewLine;
                    //textBox5.Text += reader.GetString(2) + Environment.NewLine;
                    //textBox5.Text += reader.GetString(3) + Environment.NewLine;
                    textBox6.Text = reader.GetString(4);
             
                                
                    //customerList.Add(reader.GetString(0));

                }

            }
            catch (MySqlException err)
            {
                Console.WriteLine("Error : " + err.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();

                }
                if (connection != null)
                {
                    connection.Close();

                }
            }

            //return skillList;
            
        }

        
    }
}
