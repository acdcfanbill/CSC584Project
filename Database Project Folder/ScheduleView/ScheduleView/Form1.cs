using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ScheduleView
{
    public partial class Form1 : Form
    {
        public delegate void bwtodo();

        public Form1()
        {
            InitializeComponent();
        }   
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // in here    Listening   DAte value is change 
       
            if(backgroundWorker1.IsBusy==false)     //if may too may data is in database  Form will delay   so in here checking busy
            {
                //run worker
                  backgroundWorker1.RunWorkerAsync();
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // worker   here call delegate void          
            // invokeing    void with delegate sub   is     helps               Backgroundworker through winForm control 'datagrid' 

            bwtodo dlbwtodo = new bwtodo(TodoSearch);
            //invoke TodoSearch
             Invoke(dlbwtodo);




        }
        private void TodoSearch()
        {
           
          
         dataGridView1.Rows.Clear();
           dataGridView2.Rows.Clear();
         
          // in here    reading data and   splitting   AM PM to data gridview
         
            
             String str =ScheduleView .Properties.Settings.Default.ConnectionStr;
            // this str is COnnection str from System Settings
         
            MySqlConnection con = null;
            
          
            MySqlDataReader reader = null;
            try
            {
                con = new MySqlConnection(str);
                con.Open(); 
               
                String cmdText = "SELECT * FROM Schedule";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                reader = cmd.ExecuteReader(); 
              
                while (reader.Read())
                {
                    if (Convert.ToDateTime(reader.GetString(3)).DayOfYear == dateTimePicker1.Value.DayOfYear)
                    {
                     
                        if (reader.GetString(4).ToString().Equals("True"))
                        {
                           
                            dataGridView1.Rows.Add( reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) );
                       }
                        if (reader.GetString(5).ToString().Equals("True"))
                        {
                            dataGridView2.Rows.Add( reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) );
                        }
                     
                    
                    }
                 
                }
            }
            catch (MySqlException err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close(); 
                }

            }


          
            
        }
        private void LoadTotal()
        {
            //These makes total list of data   s econd TAB
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(string)));
            dt.Columns.Add(new DataColumn("techid", typeof(string)));
            dt.Columns.Add(new DataColumn("ticketid", typeof(string)));
            dt.Columns.Add(new DataColumn("onDate", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("am", typeof(string)));
            dt.Columns.Add(new DataColumn("pm", typeof(string)));

          

            String str = ScheduleView.Properties.Settings.Default.ConnectionStr;
           
            MySqlConnection con = null;

           

            MySqlDataReader reader = null;
            try
            {
                con = new MySqlConnection(str);
                con.Open(); 
                String cmdText = "SELECT * FROM Schedule";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                reader = cmd.ExecuteReader(); 
                while (reader.Read())
                {
                    //adding all datas to datagrid

                    dt.Rows.Add(new object[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) });
                   
                }
            }
            catch (MySqlException err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }


            dataGridView3.DataSource = dt;
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //form load from here call LoadTotal
            LoadTotal();

        }
  
       
    }
}
