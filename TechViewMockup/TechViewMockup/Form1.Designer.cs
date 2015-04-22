namespace TechViewMockup
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.techTicketsDataGrid = new System.Windows.Forms.DataGridView();
            this.ticketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.techIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techdailyticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electricutilityDataSet = new TechViewMockup.electricutilityDataSet();
            this.techLabel = new System.Windows.Forms.Label();
            this.techDropDown = new System.Windows.Forms.ComboBox();
            this.techBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addPartBtn = new System.Windows.Forms.Button();
            this.searchPartDisplay = new System.Windows.Forms.DataGridView();
            this.itemIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchPartBtn = new System.Windows.Forms.Button();
            this.searchPartLabel = new System.Windows.Forms.Label();
            this.searchPartBox = new System.Windows.Forms.TextBox();
            this.partsOnTixDisplay = new System.Windows.Forms.DataGridView();
            this.ticketIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ticketStatusDropDown = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateTicketStatusButton = new System.Windows.Forms.Button();
            this.ticketStatusLabel = new System.Windows.Forms.Label();
            this.custAddressTextBox = new System.Windows.Forms.TextBox();
            this.CustAddress = new System.Windows.Forms.Label();
            this.TicketIDLabel = new System.Windows.Forms.Label();
            this.ticketIdTextBox = new System.Windows.Forms.TextBox();
            this.techTableAdapter = new TechViewMockup.electricutilityDataSetTableAdapters.techTableAdapter();
            this.techdailyticketTableAdapter = new TechViewMockup.electricutilityDataSetTableAdapters.techdailyticketTableAdapter();
            this.statusTableAdapter = new TechViewMockup.electricutilityDataSetTableAdapters.statusTableAdapter();
            this.perticketTableAdapter = new TechViewMockup.electricutilityDataSetTableAdapters.perticketTableAdapter();
            this.itemtableTableAdapter = new TechViewMockup.electricutilityDataSetTableAdapters.itemtableTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techTicketsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techdailyticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricutilityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOnTixDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perticketBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.techTicketsDataGrid);
            this.groupBox1.Controls.Add(this.techLabel);
            this.groupBox1.Controls.Add(this.techDropDown);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tech Schedule";
            // 
            // techTicketsDataGrid
            // 
            this.techTicketsDataGrid.AllowUserToAddRows = false;
            this.techTicketsDataGrid.AllowUserToDeleteRows = false;
            this.techTicketsDataGrid.AllowUserToResizeColumns = false;
            this.techTicketsDataGrid.AllowUserToResizeRows = false;
            this.techTicketsDataGrid.AutoGenerateColumns = false;
            this.techTicketsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.techTicketsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIdDataGridViewTextBoxColumn,
            this.descriptions,
            this.priorityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.aMDataGridViewCheckBoxColumn,
            this.pMDataGridViewCheckBoxColumn,
            this.techIdDataGridViewTextBoxColumn,
            this.onDate});
            this.techTicketsDataGrid.DataSource = this.techdailyticketBindingSource;
            this.techTicketsDataGrid.Location = new System.Drawing.Point(6, 45);
            this.techTicketsDataGrid.Name = "techTicketsDataGrid";
            this.techTicketsDataGrid.ReadOnly = true;
            this.techTicketsDataGrid.RowHeadersVisible = false;
            this.techTicketsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.techTicketsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.techTicketsDataGrid.Size = new System.Drawing.Size(537, 69);
            this.techTicketsDataGrid.TabIndex = 3;
            this.techTicketsDataGrid.SelectionChanged += new System.EventHandler(this.techTicketsDataGrid_SelectionChanged);
            // 
            // ticketIdDataGridViewTextBoxColumn
            // 
            this.ticketIdDataGridViewTextBoxColumn.DataPropertyName = "ticketId";
            this.ticketIdDataGridViewTextBoxColumn.HeaderText = "Ticket";
            this.ticketIdDataGridViewTextBoxColumn.Name = "ticketIdDataGridViewTextBoxColumn";
            this.ticketIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIdDataGridViewTextBoxColumn.Width = 75;
            // 
            // descriptions
            // 
            this.descriptions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptions.DataPropertyName = "descriptions";
            this.descriptions.HeaderText = "Description";
            this.descriptions.Name = "descriptions";
            this.descriptions.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityDataGridViewTextBoxColumn.Width = 75;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 75;
            // 
            // aMDataGridViewCheckBoxColumn
            // 
            this.aMDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aMDataGridViewCheckBoxColumn.DataPropertyName = "AM";
            this.aMDataGridViewCheckBoxColumn.HeaderText = "AM";
            this.aMDataGridViewCheckBoxColumn.Name = "aMDataGridViewCheckBoxColumn";
            this.aMDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aMDataGridViewCheckBoxColumn.Width = 29;
            // 
            // pMDataGridViewCheckBoxColumn
            // 
            this.pMDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pMDataGridViewCheckBoxColumn.DataPropertyName = "PM";
            this.pMDataGridViewCheckBoxColumn.HeaderText = "PM";
            this.pMDataGridViewCheckBoxColumn.Name = "pMDataGridViewCheckBoxColumn";
            this.pMDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pMDataGridViewCheckBoxColumn.Width = 29;
            // 
            // techIdDataGridViewTextBoxColumn
            // 
            this.techIdDataGridViewTextBoxColumn.DataPropertyName = "techId";
            this.techIdDataGridViewTextBoxColumn.HeaderText = "techId";
            this.techIdDataGridViewTextBoxColumn.Name = "techIdDataGridViewTextBoxColumn";
            this.techIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.techIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // onDate
            // 
            this.onDate.DataPropertyName = "onDate";
            this.onDate.HeaderText = "onDate";
            this.onDate.Name = "onDate";
            this.onDate.ReadOnly = true;
            this.onDate.Visible = false;
            // 
            // techdailyticketBindingSource
            // 
            this.techdailyticketBindingSource.DataMember = "techdailyticket";
            this.techdailyticketBindingSource.DataSource = this.electricutilityDataSet;
            // 
            // electricutilityDataSet
            // 
            this.electricutilityDataSet.DataSetName = "electricutilityDataSet";
            this.electricutilityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techLabel
            // 
            this.techLabel.AutoSize = true;
            this.techLabel.Location = new System.Drawing.Point(305, 21);
            this.techLabel.Name = "techLabel";
            this.techLabel.Size = new System.Drawing.Size(32, 13);
            this.techLabel.TabIndex = 2;
            this.techLabel.Text = "Tech";
            // 
            // techDropDown
            // 
            this.techDropDown.DataSource = this.techBindingSource;
            this.techDropDown.DisplayMember = "name";
            this.techDropDown.FormattingEnabled = true;
            this.techDropDown.Location = new System.Drawing.Point(343, 18);
            this.techDropDown.Name = "techDropDown";
            this.techDropDown.Size = new System.Drawing.Size(121, 21);
            this.techDropDown.TabIndex = 1;
            this.techDropDown.ValueMember = "techId";
            this.techDropDown.SelectedIndexChanged += new System.EventHandler(this.techDropDown_SelectedIndexChanged);
            // 
            // techBindingSource
            // 
            this.techBindingSource.DataMember = "tech";
            this.techBindingSource.DataSource = this.electricutilityDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustomerIDLabel);
            this.groupBox2.Controls.Add(this.customerIdTextBox);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.custAddressTextBox);
            this.groupBox2.Controls.Add(this.CustAddress);
            this.groupBox2.Controls.Add(this.TicketIDLabel);
            this.groupBox2.Controls.Add(this.ticketIdTextBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 598);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Info";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(141, 20);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(68, 13);
            this.CustomerIDLabel.TabIndex = 11;
            this.CustomerIDLabel.Text = "Customer ID:";
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(209, 20);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.ReadOnly = true;
            this.customerIdTextBox.Size = new System.Drawing.Size(84, 20);
            this.customerIdTextBox.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.deleteButton);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.addPartBtn);
            this.groupBox5.Controls.Add(this.searchPartDisplay);
            this.groupBox5.Controls.Add(this.searchPartBtn);
            this.groupBox5.Controls.Add(this.searchPartLabel);
            this.groupBox5.Controls.Add(this.searchPartBox);
            this.groupBox5.Controls.Add(this.partsOnTixDisplay);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(10, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(543, 273);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parts";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(234, 125);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addPartBtn
            // 
            this.addPartBtn.Location = new System.Drawing.Point(232, 82);
            this.addPartBtn.Name = "addPartBtn";
            this.addPartBtn.Size = new System.Drawing.Size(75, 23);
            this.addPartBtn.TabIndex = 6;
            this.addPartBtn.Text = "Add ";
            this.addPartBtn.UseVisualStyleBackColor = true;
            this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
            // 
            // searchPartDisplay
            // 
            this.searchPartDisplay.AllowUserToAddRows = false;
            this.searchPartDisplay.AllowUserToDeleteRows = false;
            this.searchPartDisplay.AutoGenerateColumns = false;
            this.searchPartDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchPartDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.searchPartDisplay.DataSource = this.itemtableBindingSource;
            this.searchPartDisplay.Location = new System.Drawing.Point(13, 34);
            this.searchPartDisplay.MultiSelect = false;
            this.searchPartDisplay.Name = "searchPartDisplay";
            this.searchPartDisplay.ReadOnly = true;
            this.searchPartDisplay.RowHeadersVisible = false;
            this.searchPartDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchPartDisplay.Size = new System.Drawing.Size(197, 151);
            this.searchPartDisplay.TabIndex = 5;
            this.searchPartDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchPartDisplay_CellClick);
            // 
            // itemIdDataGridViewTextBoxColumn1
            // 
            this.itemIdDataGridViewTextBoxColumn1.DataPropertyName = "itemId";
            this.itemIdDataGridViewTextBoxColumn1.HeaderText = "itemId";
            this.itemIdDataGridViewTextBoxColumn1.Name = "itemIdDataGridViewTextBoxColumn1";
            this.itemIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Item";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 52;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemtableBindingSource
            // 
            this.itemtableBindingSource.DataMember = "itemtable";
            this.itemtableBindingSource.DataSource = this.electricutilityDataSet;
            // 
            // searchPartBtn
            // 
            this.searchPartBtn.Location = new System.Drawing.Point(31, 241);
            this.searchPartBtn.Name = "searchPartBtn";
            this.searchPartBtn.Size = new System.Drawing.Size(75, 23);
            this.searchPartBtn.TabIndex = 4;
            this.searchPartBtn.Text = "Search";
            this.searchPartBtn.UseVisualStyleBackColor = true;
            this.searchPartBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchPartBtn_MouseClick);
            // 
            // searchPartLabel
            // 
            this.searchPartLabel.AutoSize = true;
            this.searchPartLabel.Location = new System.Drawing.Point(50, 199);
            this.searchPartLabel.Name = "searchPartLabel";
            this.searchPartLabel.Size = new System.Drawing.Size(116, 13);
            this.searchPartLabel.TabIndex = 3;
            this.searchPartLabel.Text = "Search for Parts to add";
            // 
            // searchPartBox
            // 
            this.searchPartBox.Location = new System.Drawing.Point(26, 215);
            this.searchPartBox.Name = "searchPartBox";
            this.searchPartBox.Size = new System.Drawing.Size(165, 20);
            this.searchPartBox.TabIndex = 2;
            // 
            // partsOnTixDisplay
            // 
            this.partsOnTixDisplay.AllowUserToAddRows = false;
            this.partsOnTixDisplay.AllowUserToDeleteRows = false;
            this.partsOnTixDisplay.AutoGenerateColumns = false;
            this.partsOnTixDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsOnTixDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIdDataGridViewTextBoxColumn1,
            this.itemIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.partsOnTixDisplay.DataSource = this.perticketBindingSource;
            this.partsOnTixDisplay.Location = new System.Drawing.Point(333, 21);
            this.partsOnTixDisplay.MultiSelect = false;
            this.partsOnTixDisplay.Name = "partsOnTixDisplay";
            this.partsOnTixDisplay.ReadOnly = true;
            this.partsOnTixDisplay.RowHeadersVisible = false;
            this.partsOnTixDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsOnTixDisplay.Size = new System.Drawing.Size(204, 246);
            this.partsOnTixDisplay.TabIndex = 1;
            this.partsOnTixDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsOnTixDisplay_CellClick);
            // 
            // ticketIdDataGridViewTextBoxColumn1
            // 
            this.ticketIdDataGridViewTextBoxColumn1.DataPropertyName = "ticketId";
            this.ticketIdDataGridViewTextBoxColumn1.HeaderText = "ticketId";
            this.ticketIdDataGridViewTextBoxColumn1.Name = "ticketIdDataGridViewTextBoxColumn1";
            this.ticketIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ticketIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "itemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "itemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Item";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 71;
            // 
            // perticketBindingSource
            // 
            this.perticketBindingSource.DataMember = "perticket";
            this.perticketBindingSource.DataSource = this.electricutilityDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Parts on this ticket";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.notesTextBox);
            this.groupBox4.Location = new System.Drawing.Point(10, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(543, 217);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(13, 20);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(520, 185);
            this.notesTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ticketStatusDropDown);
            this.groupBox3.Controls.Add(this.updateTicketStatusButton);
            this.groupBox3.Controls.Add(this.ticketStatusLabel);
            this.groupBox3.Location = new System.Drawing.Point(10, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 45);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // ticketStatusDropDown
            // 
            this.ticketStatusDropDown.DataSource = this.statusBindingSource;
            this.ticketStatusDropDown.DisplayMember = "name";
            this.ticketStatusDropDown.FormattingEnabled = true;
            this.ticketStatusDropDown.Location = new System.Drawing.Point(89, 16);
            this.ticketStatusDropDown.Name = "ticketStatusDropDown";
            this.ticketStatusDropDown.Size = new System.Drawing.Size(121, 21);
            this.ticketStatusDropDown.TabIndex = 5;
            this.ticketStatusDropDown.ValueMember = "statusId";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "status";
            this.statusBindingSource.DataSource = this.electricutilityDataSet;
            // 
            // updateTicketStatusButton
            // 
            this.updateTicketStatusButton.Location = new System.Drawing.Point(221, 14);
            this.updateTicketStatusButton.Name = "updateTicketStatusButton";
            this.updateTicketStatusButton.Size = new System.Drawing.Size(75, 23);
            this.updateTicketStatusButton.TabIndex = 6;
            this.updateTicketStatusButton.Text = "Update";
            this.updateTicketStatusButton.UseVisualStyleBackColor = true;
            this.updateTicketStatusButton.Click += new System.EventHandler(this.updateTicketStatusButton_Click);
            // 
            // ticketStatusLabel
            // 
            this.ticketStatusLabel.AutoSize = true;
            this.ticketStatusLabel.Location = new System.Drawing.Point(10, 19);
            this.ticketStatusLabel.Name = "ticketStatusLabel";
            this.ticketStatusLabel.Size = new System.Drawing.Size(73, 13);
            this.ticketStatusLabel.TabIndex = 4;
            this.ticketStatusLabel.Text = "Ticket Status:";
            // 
            // custAddressTextBox
            // 
            this.custAddressTextBox.Location = new System.Drawing.Point(343, 20);
            this.custAddressTextBox.Multiline = true;
            this.custAddressTextBox.Name = "custAddressTextBox";
            this.custAddressTextBox.ReadOnly = true;
            this.custAddressTextBox.Size = new System.Drawing.Size(200, 59);
            this.custAddressTextBox.TabIndex = 3;
            // 
            // CustAddress
            // 
            this.CustAddress.AutoSize = true;
            this.CustAddress.Location = new System.Drawing.Point(293, 23);
            this.CustAddress.Name = "CustAddress";
            this.CustAddress.Size = new System.Drawing.Size(45, 13);
            this.CustAddress.TabIndex = 2;
            this.CustAddress.Text = "Address";
            // 
            // TicketIDLabel
            // 
            this.TicketIDLabel.AutoSize = true;
            this.TicketIDLabel.Location = new System.Drawing.Point(7, 20);
            this.TicketIDLabel.Name = "TicketIDLabel";
            this.TicketIDLabel.Size = new System.Drawing.Size(54, 13);
            this.TicketIDLabel.TabIndex = 1;
            this.TicketIDLabel.Text = "Ticket ID:";
            // 
            // ticketIdTextBox
            // 
            this.ticketIdTextBox.Location = new System.Drawing.Point(63, 20);
            this.ticketIdTextBox.Name = "ticketIdTextBox";
            this.ticketIdTextBox.ReadOnly = true;
            this.ticketIdTextBox.Size = new System.Drawing.Size(77, 20);
            this.ticketIdTextBox.TabIndex = 0;
            // 
            // techTableAdapter
            // 
            this.techTableAdapter.ClearBeforeFill = true;
            // 
            // techdailyticketTableAdapter
            // 
            this.techdailyticketTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // perticketTableAdapter
            // 
            this.perticketTableAdapter.ClearBeforeFill = true;
            // 
            // itemtableTableAdapter
            // 
            this.itemtableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 762);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tech App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techTicketsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techdailyticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electricutilityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPartDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOnTixDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perticketBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox techDropDown;
        private System.Windows.Forms.Label techLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateTicketStatusButton;
        private System.Windows.Forms.ComboBox ticketStatusDropDown;
        private System.Windows.Forms.Label ticketStatusLabel;
        private System.Windows.Forms.TextBox custAddressTextBox;
        private System.Windows.Forms.Label CustAddress;
        private System.Windows.Forms.Label TicketIDLabel;
        private System.Windows.Forms.TextBox ticketIdTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView searchPartDisplay;
        private System.Windows.Forms.Button searchPartBtn;
        private System.Windows.Forms.Label searchPartLabel;
        private System.Windows.Forms.TextBox searchPartBox;
        private System.Windows.Forms.DataGridView partsOnTixDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.Button addPartBtn;
        private electricutilityDataSet electricutilityDataSet;
        private System.Windows.Forms.BindingSource techBindingSource;
        private electricutilityDataSetTableAdapters.techTableAdapter techTableAdapter;
        private System.Windows.Forms.BindingSource techdailyticketBindingSource;
        private electricutilityDataSetTableAdapters.techdailyticketTableAdapter techdailyticketTableAdapter;
        private System.Windows.Forms.DataGridView techTicketsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private electricutilityDataSetTableAdapters.statusTableAdapter statusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onDate;
        private System.Windows.Forms.BindingSource perticketBindingSource;
        private electricutilityDataSetTableAdapters.perticketTableAdapter perticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemtableBindingSource;
        private electricutilityDataSetTableAdapters.itemtableTableAdapter itemtableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button1;
    }
}

