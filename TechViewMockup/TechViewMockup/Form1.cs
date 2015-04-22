using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TechViewMockup
{
    public partial class Form1 : Form
    {
        List<TicketData> ticketDataList = new List<TicketData>();
        private DataGridView dataGridView1 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private Button reloadButton = new Button();
        private Button submitButton = new Button();
        private int selectedPart = -1;
        private int selectedTech = -1;
        private int selectedTicket = -1;
        private int selectedPartToRemove = -1;

        string myConnString = "server=127.0.0.1;user id=electric_util_ad;password=eleadmin;database=electricutility;Pooling=false;";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electricutilityDataSet.itemtable' table. You can move, or remove it, as needed.
            this.itemtableTableAdapter.Fill(this.electricutilityDataSet.itemtable);
            // TODO: This line of code loads data into the 'electricutilityDataSet.perticket' table. You can move, or remove it, as needed.
            //this.perticketTableAdapter.Fill(this.electricutilityDataSet.perticket);
            // TODO: This line of code loads data into the 'electricutilityDataSet.status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.electricutilityDataSet.status);
            // TODO: This line of code loads data into the 'electricutilityDataSet.techdailyticket' table. You can move, or remove it, as needed.
            //this.techdailyticketTableAdapter.Fill(this.electricutilityDataSet.techdailyticket);
            // TODO: This line of code loads data into the 'electricutilityDataSet.tech' table. You can move, or remove it, as needed.
            this.techTableAdapter.Fill(this.electricutilityDataSet.tech);

        }

        private void techDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox box = (ComboBox) sender;

            //set our selected tech
            selectedTech = Convert.ToInt32(box.SelectedValue);

            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(theDate);
            
            //Display query
            string query = "SELECT * FROM TechDailyTicket WHERE techId = "+box.SelectedValue+" AND onDate='"+theDate+"';";
            using (MySqlConnection myConn = new MySqlConnection(myConnString))
            {
                using (MySqlCommand myComm = new MySqlCommand(query, myConn))
                {
                    //For offline connection we weill use  MySqlDataAdapter class.
                    MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                    myAdapter.SelectCommand = myComm;
                    DataTable dTable = new DataTable();
                    myAdapter.Fill(dTable);
                    techTicketsDataGrid.DataSource = dTable;
                    if (dTable == null || dTable.Rows.Count <= 0)
                    {
                        //updateTicketInfo(ticketId, custId, name, address1, address2, address3, notes, statusId);
                        updateTicketInfo(-1, -1, "", "", "", "", "", -1);
                    }
                    myAdapter.Dispose();
                    myComm.Dispose();
                }
                myConn.Close();
                myConn.Dispose();
                MySqlConnection.ClearPool(myConn);
            }

            MySqlConnection.ClearAllPools();

            

            // we want to load specific data into the Ticket Data Grid
            //Console.WriteLine(sender.GetType());
            //Console.WriteLine(sender.ToString());
            

            //int index = box.SelectedIndex;
            //DataRowView item = (DataRowView)box.SelectedItem;
            //item.DataView.
            //Console.WriteLine(index);
            //Console.WriteLine(item);
            //DataTable curr = techTicketsDataGrid.Rows.GetNextRow;
            
            //DataRowView schedule = (DataRowView)
            //DataGridViewRowCollection origData = techTicketsDataGrid.Rows;
            //DataGridViewRowCollection newData = new DataGridViewRowCollection();
            //DataGridView newData = new DataGridView();

            //Console.WriteLine("item value: " + box.SelectedValue);
            //foreach (DataGridViewRow row in origData)
            //{
            //    checkIfTech(row, (int)box.SelectedValue);
            //}
            //techTicketsDataGrid

            //for (int i = 0; i < techTicketsDataGrid.Rows.Count; i++)
            //{
            //    //DataGridViewRow curr = 
            //    //techTicketsDataGrid.Columns.IndexOf("techId");
            //    //techTicketsDataGrid.Columns[7].;
            //    //if( origData.G)

            //    //Console.WriteLine(techTicketsDataGrid.get);
            //    //DataGridViewRow row = 
            //    //Console.WriteLine(techTicketsDataGrid.Rows.SharedRow(i).Cells[6].Value);
            //    //Console.WriteLine(row.Cells[6].Value);
            //    checkIfTech(origData.SharedRow(i), (int)box.SelectedValue);
            //}

        }

        private void techTicketsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridView box = (DataGridView)sender;
            //Console.WriteLine(box.SelectedRows);
            //DataGridViewSelectedRowCollection myrows = box.SelectedRows;
            //Console.WriteLine(box.SelectedRows.Count);
            if(box.SelectedRows.Count > 0)
            {
                int ticketId = (int) box.SelectedRows[0].Cells[0].Value;
                selectedTicket = ticketId;
                //Console.WriteLine(ticketId);
                //Display query
                string queryTicket = "SELECT * FROM TicketInfo WHERE ticketId = " + ticketId + ";";
                using (MySqlConnection myConn = new MySqlConnection(myConnString))
                {
                    using (MySqlCommand myComm = new MySqlCommand(queryTicket, myConn))
                    {
                        //For offline connection we weill use  MySqlDataAdapter class.
                        MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                        myAdapter.SelectCommand = myComm;
                        DataTable ticketTable = new DataTable();
                        DataTable custData = new DataTable();
                        myAdapter.Fill(ticketTable);

                        int custId = 0;
                        int statusId = 0;
                        String name = null;
                        String address1 = null;
                        String address2 = null;
                        String address3 = null;
                        String notes = null;

                        DataRow curr = ticketTable.Rows[0];

                        if (!(curr["customerId"] is System.DBNull))
                            custId = (int)curr["customerId"];
                        if (!(curr["name"] is System.DBNull))
                            name = (string)curr["name"];
                        if (!(curr["address1"] is System.DBNull))
                            address1 = (string)curr["address1"];
                        if (!(curr["address2"] is System.DBNull))
                            address2 = (string)curr["address2"];
                        if (!(curr["cityState"] is System.DBNull))
                            address3 = (string)curr["cityState"];
                        if (!(curr["notes"] is System.DBNull))
                            notes = (String)curr["notes"];
                        if (!(curr["statusId"] is System.DBNull))
                            statusId = (int)curr["statusId"];

                        updateTicketInfo(ticketId, custId, name, address1, address2, address3, notes, statusId);

                        myAdapter.Dispose();
                        myComm.Dispose();
                    }
                    myConn.Close();
                    myConn.Dispose();
                    MySqlConnection.ClearPool(myConn);
                }

                MySqlConnection.ClearAllPools();
            }
        }

        private void updateTicketInfo(int ticketId, int custId, String name, String addr1, String addr2, String addr3, String notes, int statusId)
        {
            if (ticketId < 0)
            {
                ticketIdTextBox.Text = "";
                customerIdTextBox.Text = "";
                custAddressTextBox.Text = "";
                notesTextBox.Text = "";
                ticketStatusDropDown.SelectedValue = 0;
                this.partsOnTixDisplay.DataSource = null;
            }
            else
            {
                ticketIdTextBox.Text = ticketId.ToString();
                customerIdTextBox.Text = custId.ToString();
                custAddressTextBox.Text = name + "\r\n" + addr1 + "\r\n" + addr2 + "\r\n" + addr3;
                notesTextBox.Text = notes;
                ticketStatusDropDown.SelectedValue = statusId;
                fillPerTicket(ticketId);
            }
        }

        private void updateTicketStatusButton_Click(object sender, EventArgs e)
        {
            int ticketId = Convert.ToInt32(ticketIdTextBox.Text);
            int newStatus = (int)ticketStatusDropDown.SelectedValue;
            String newNotes = notesTextBox.Text;

            using (MySqlConnection myConn = new MySqlConnection(myConnString))
            {
                //string query = "select * from TechDailyTicket where techId = " + box.SelectedValue + ";";
                string query = "UPDATE Ticket SET statusId="+newStatus+", notes='"+newNotes+"' WHERE ticketId="+ticketId+";";
                using (MySqlCommand myComm = new MySqlCommand(query, myConn))
                {
                    myComm.Connection.Open();
                    myComm.ExecuteNonQuery();
                    myComm.Dispose();
                }
                myConn.Close();
                myConn.Dispose();
                MySqlConnection.ClearPool(myConn);
            }

            MySqlConnection.ClearAllPools();
        }

        private void searchPartBtn_MouseClick(object sender, MouseEventArgs e)
        {
            //int i = 
            DataGridViewRow row = searchPartDisplay.SelectedRows[0];
            //row[];
        }

        private void searchPartDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow selectedRow = searchPartDisplay.Rows[row];
                //String test = selectedRow.Cells[0].Value.ToString();
                //Console.WriteLine(test);
                selectedPart = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
        }

        private void addPartBtn_Click(object sender, EventArgs e)
        {
            int ticketId = selectedTicket;
            int techId = selectedTech;
            int itemId = selectedPart;

            if (ticketId == -1 || techId == -1 || itemId == -1)
                return;

            using (MySqlConnection myConn = new MySqlConnection(myConnString))
            {
                //string query = "select * from TechDailyTicket where techId = " + box.SelectedValue + ";";
                string query = "INSERT INTO ItemsUsed VALUES(NULL, " + ticketId + ", " + itemId + ", " + techId + ", 1);"; //always add one for starters
                Console.WriteLine(query);
                using (MySqlCommand myComm = new MySqlCommand(query, myConn))
                {
                    myComm.Connection.Open();
                    myComm.ExecuteNonQuery();
                    myComm.Dispose();
                }
                myConn.Close();
                myConn.Dispose();
                MySqlConnection.ClearPool(myConn);
            }

            MySqlConnection.ClearAllPools();

            //refresh the per ticket stuff
            fillPerTicket(ticketId);
        }

        private void fillPerTicket(int ticketId)
        {
            DataTable ticketTable = new DataTable();

            using (MySqlConnection myConn = new MySqlConnection(myConnString))
            {
                //string query = "select * from TechDailyTicket where techId = " + box.SelectedValue + ";";
                string query = "SELECT * FROM PerTicket WHERE ticketId=" + ticketId + ";"; //always add one for starters
                Console.WriteLine(query);
                using (MySqlCommand myComm = new MySqlCommand(query, myConn))
                {
                    MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                    myAdapter.SelectCommand = myComm;
                    myAdapter.Fill(ticketTable);

                    myComm.Dispose();
                }
                myConn.Close();
                myConn.Dispose();
                MySqlConnection.ClearPool(myConn);
            }

            MySqlConnection.ClearAllPools();

            //this.perticketTableAdapter.Fill(ticketTable);
            this.partsOnTixDisplay.DataSource = ticketTable;
            resetPartsOnDisplayForRowOne();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int ticketId = selectedTicket;
            int itemId = selectedPartToRemove;

            if (ticketId == -1 || itemId == -1)
                return;

            using (MySqlConnection myConn = new MySqlConnection(myConnString))
            {
                //string query = "select * from TechDailyTicket where techId = " + box.SelectedValue + ";";
                string query = "DELETE FROM ItemsUsed WHERE ticketId=" + ticketId + " AND itemId=" + itemId + ";"; //always add one for starters
                Console.WriteLine(query);
                using (MySqlCommand myComm = new MySqlCommand(query, myConn))
                {
                    myComm.Connection.Open();
                    myComm.ExecuteNonQuery();
                    myComm.Dispose();
                }
                myConn.Close();
                myConn.Dispose();
                MySqlConnection.ClearPool(myConn);
            }

            MySqlConnection.ClearAllPools();

            //refresh the per ticket stuff
            fillPerTicket(ticketId);
        }

        private void partsOnTixDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow selectedRow = partsOnTixDisplay.Rows[row];
                String test = selectedRow.Cells[1].Value.ToString();
                Console.WriteLine("row index is: " + test);
                selectedPartToRemove = Convert.ToInt32(selectedRow.Cells[1].Value);
            }
        }

        private void resetPartsOnDisplayForRowOne()
        {
            if (partsOnTixDisplay.Rows.Count != 0)
            {
                DataGridViewRow selectedRow = partsOnTixDisplay.Rows[0];
                selectedPartToRemove = Convert.ToInt32(selectedRow.Cells[1].Value);
            }
            else
            {
                selectedPartToRemove = -1;
            }
        }


        //public bool checkIfTech (DataGridViewRow row, int techId)
        //{

        //    Console.WriteLine(((DataGridViewCell)row.Cells[6]).Value);
        //    //((DataGridViewColumn)row.RowIndex[7]).ValueType
        //    //if ((int)((DataGridViewCell)row.Cells[6]).Value == techId)
        //    //{
        //    //    Console.WriteLine("true");
        //    //    return true;
        //    //}
        //    // Console.WriteLine("false");
        //     return false;
        //}

        //private void GetTicketData(string selectCommand)
        //{
        //    try
        //    {
        //        // Specify a connection string. Replace the given value with a  
        //        // valid connection string for a Northwind SQL Server sample 
        //        // database accessible to your system.
        //        String connectionString =
        //            "Integrated Security=SSPI;Persist Security Info=False;" +
        //            "Initial Catalog=Northwind;Data Source=localhost";

        //        // Create a new data adapter based on the specified query.
        //        dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

        //        // Create a command builder to generate SQL update, insert, and 
        //        // delete commands based on selectCommand. These are used to 
        //        // update the database.
        //        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

        //        // Populate a new data table and bind it to the BindingSource.
        //        DataTable table = new DataTable();
        //        table.Locale = System.Globalization.CultureInfo.InvariantCulture;
        //        dataAdapter.Fill(table);
        //        bindingSource1.DataSource = table;

        //        // Resize the DataGridView columns to fit the newly loaded content.
        //        dataGridView1.AutoResizeColumns(
        //            DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show("To run this example, replace the value of the " +
        //            "connectionString variable with a connection string that is " +
        //            "valid for your system.");
        //    }
        //}
    }
}
