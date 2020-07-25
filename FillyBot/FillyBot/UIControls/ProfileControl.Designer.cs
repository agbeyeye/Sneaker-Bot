namespace FillyBot.UIControls
{
    partial class ProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.ckbShipping = new System.Windows.Forms.CheckBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.txtExpYear = new System.Windows.Forms.TextBox();
            this.txtExpMonth = new System.Windows.Forms.TextBox();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtShippingState = new System.Windows.Forms.TextBox();
            this.txtShippingCode = new System.Windows.Forms.TextBox();
            this.txtShippingCity = new System.Windows.Forms.TextBox();
            this.txtShippingStAddress = new System.Windows.Forms.TextBox();
            this.txtShippingLName = new System.Windows.Forms.TextBox();
            this.txtShippingFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 350);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.ckbShipping);
            this.tabPage1.Controls.Add(this.txtCVC);
            this.tabPage1.Controls.Add(this.txtExpYear);
            this.tabPage1.Controls.Add(this.txtExpMonth);
            this.tabPage1.Controls.Add(this.cboCardType);
            this.tabPage1.Controls.Add(this.txtCardNumber);
            this.tabPage1.Controls.Add(this.txtShippingState);
            this.tabPage1.Controls.Add(this.txtShippingCode);
            this.tabPage1.Controls.Add(this.txtShippingCity);
            this.tabPage1.Controls.Add(this.txtShippingStAddress);
            this.tabPage1.Controls.Add(this.txtShippingLName);
            this.tabPage1.Controls.Add(this.txtShippingFName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtState);
            this.tabPage1.Controls.Add(this.txtCode);
            this.tabPage1.Controls.Add(this.txtCity);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Profile";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(655, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ckbShipping
            // 
            this.ckbShipping.AutoSize = true;
            this.ckbShipping.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShipping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckbShipping.Location = new System.Drawing.Point(229, 145);
            this.ckbShipping.Name = "ckbShipping";
            this.ckbShipping.Size = new System.Drawing.Size(169, 18);
            this.ckbShipping.TabIndex = 43;
            this.ckbShipping.Text = "Use this Info for shipping";
            this.ckbShipping.UseVisualStyleBackColor = true;
            this.ckbShipping.CheckedChanged += new System.EventHandler(this.ckbShipping_CheckedChanged);
            // 
            // txtCVC
            // 
            this.txtCVC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCVC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCVC.Location = new System.Drawing.Point(622, 110);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(73, 21);
            this.txtCVC.TabIndex = 42;
            this.txtCVC.Text = "CVC";
            this.txtCVC.Click += new System.EventHandler(this.txtCVC_Click);
            this.txtCVC.Leave += new System.EventHandler(this.txtCVC_Leave);
            // 
            // txtExpYear
            // 
            this.txtExpYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExpYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtExpYear.Location = new System.Drawing.Point(527, 110);
            this.txtExpYear.Name = "txtExpYear";
            this.txtExpYear.Size = new System.Drawing.Size(80, 21);
            this.txtExpYear.TabIndex = 41;
            this.txtExpYear.Text = "Year";
            this.txtExpYear.Click += new System.EventHandler(this.txtExpYear_Click);
            this.txtExpYear.Leave += new System.EventHandler(this.txtExpYear_Leave);
            // 
            // txtExpMonth
            // 
            this.txtExpMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExpMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtExpMonth.Location = new System.Drawing.Point(441, 109);
            this.txtExpMonth.Name = "txtExpMonth";
            this.txtExpMonth.Size = new System.Drawing.Size(73, 21);
            this.txtExpMonth.TabIndex = 40;
            this.txtExpMonth.Text = "MM";
            this.txtExpMonth.Click += new System.EventHandler(this.txtExpMonth_Click);
            this.txtExpMonth.Leave += new System.EventHandler(this.txtExpMonth_Leave);
            // 
            // cboCardType
            // 
            this.cboCardType.BackColor = System.Drawing.SystemColors.WindowText;
            this.cboCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCardType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCardType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboCardType.FormattingEnabled = true;
            this.cboCardType.Items.AddRange(new object[] {
            "Visa",
            "MasterCard"});
            this.cboCardType.Location = new System.Drawing.Point(16, 109);
            this.cboCardType.Name = "cboCardType";
            this.cboCardType.Size = new System.Drawing.Size(200, 21);
            this.cboCardType.TabIndex = 39;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCardNumber.Location = new System.Drawing.Point(229, 108);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(200, 21);
            this.txtCardNumber.TabIndex = 38;
            this.txtCardNumber.Text = "Card Number";
            this.txtCardNumber.Click += new System.EventHandler(this.txtCardNumber_Click);
            this.txtCardNumber.Leave += new System.EventHandler(this.txtCardNumber_Leave);
            // 
            // txtShippingState
            // 
            this.txtShippingState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtShippingState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShippingState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippingState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtShippingState.Location = new System.Drawing.Point(441, 260);
            this.txtShippingState.Name = "txtShippingState";
            this.txtShippingState.Size = new System.Drawing.Size(200, 21);
            this.txtShippingState.TabIndex = 37;
            this.txtShippingState.Text = "State";
            this.txtShippingState.Click += new System.EventHandler(this.txtShippingState_Click);
            this.txtShippingState.Leave += new System.EventHandler(this.txtShippingState_Leave);
            // 
            // txtShippingCode
            // 
            this.txtShippingCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtShippingCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShippingCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippingCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtShippingCode.Location = new System.Drawing.Point(16, 260);
            this.txtShippingCode.Name = "txtShippingCode";
            this.txtShippingCode.Size = new System.Drawing.Size(200, 21);
            this.txtShippingCode.TabIndex = 36;
            this.txtShippingCode.Text = "Zip Code";
            this.txtShippingCode.Click += new System.EventHandler(this.txtShippingCode_Click);
            this.txtShippingCode.Leave += new System.EventHandler(this.txtShippingCode_Leave);
            // 
            // txtShippingCity
            // 
            this.txtShippingCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtShippingCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShippingCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippingCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtShippingCity.Location = new System.Drawing.Point(229, 260);
            this.txtShippingCity.Name = "txtShippingCity";
            this.txtShippingCity.Size = new System.Drawing.Size(200, 21);
            this.txtShippingCity.TabIndex = 35;
            this.txtShippingCity.Text = "City";
            this.txtShippingCity.Click += new System.EventHandler(this.txtShippingCity_Click);
            this.txtShippingCity.Leave += new System.EventHandler(this.txtShippingCity_Leave);
            // 
            // txtShippingStAddress
            // 
            this.txtShippingStAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtShippingStAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShippingStAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippingStAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtShippingStAddress.Location = new System.Drawing.Point(441, 210);
            this.txtShippingStAddress.Name = "txtShippingStAddress";
            this.txtShippingStAddress.Size = new System.Drawing.Size(200, 21);
            this.txtShippingStAddress.TabIndex = 34;
            this.txtShippingStAddress.Text = "Street Address";
            this.txtShippingStAddress.Click += new System.EventHandler(this.txtShippingStAddress_Click);
            this.txtShippingStAddress.Leave += new System.EventHandler(this.txtShippingStAddress_Leave);
            // 
            // txtShippingLName
            // 
            this.txtShippingLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtShippingLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShippingLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippingLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtShippingLName.Location = new System.Drawing.Point(229, 210);
            this.txtShippingLName.Name = "txtShippingLName";
            this.txtShippingLName.Size = new System.Drawing.Size(200, 21);
            this.txtShippingLName.TabIndex = 33;
            this.txtShippingLName.Text = "LastName";
            this.txtShippingLName.Click += new System.EventHandler(this.txtShippingLName_Click);
            this.txtShippingLName.Leave += new System.EventHandler(this.txtShippingLName_Leave);
            // 
            // txtShippingFName
            // 
            this.txtShippingFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtShippingFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShippingFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShippingFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtShippingFName.Location = new System.Drawing.Point(16, 210);
            this.txtShippingFName.Name = "txtShippingFName";
            this.txtShippingFName.Size = new System.Drawing.Size(200, 21);
            this.txtShippingFName.TabIndex = 32;
            this.txtShippingFName.Text = "FirstName";
            this.txtShippingFName.Click += new System.EventHandler(this.txtShippingFName_Click);
            this.txtShippingFName.Leave += new System.EventHandler(this.txtShippingFName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Shipping Information";
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtState.Location = new System.Drawing.Point(441, 68);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(200, 21);
            this.txtState.TabIndex = 30;
            this.txtState.Text = "State";
            this.txtState.Click += new System.EventHandler(this.txtState_Click);
            this.txtState.Leave += new System.EventHandler(this.txtState_Leave);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCode.Location = new System.Drawing.Point(16, 68);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 21);
            this.txtCode.TabIndex = 29;
            this.txtCode.Text = "Zip Code";
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCity.Location = new System.Drawing.Point(229, 68);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 21);
            this.txtCity.TabIndex = 28;
            this.txtCity.Text = "City";
            this.txtCity.Click += new System.EventHandler(this.txtCity_Click);
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAddress.Location = new System.Drawing.Point(441, 24);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 21);
            this.txtAddress.TabIndex = 27;
            this.txtAddress.Text = "Street Address";
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_Click);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLastName.Location = new System.Drawing.Point(229, 24);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 21);
            this.txtLastName.TabIndex = 26;
            this.txtLastName.Text = "LastName";
            this.txtLastName.Click += new System.EventHandler(this.txtLastName_Click);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFirstName.Location = new System.Drawing.Point(16, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 21);
            this.txtFirstName.TabIndex = 25;
            this.txtFirstName.Text = "FirstName";
            this.txtFirstName.Click += new System.EventHandler(this.txtFirstName_Click);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Billing Information";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Profiles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cardType,
            this.cardNumber,
            this.address,
            this.CITY,
            this.state,
            this.code,
            this.shippingName,
            this.shippingAddress,
            this.Id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(736, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 283);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 35);
            this.panel2.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(693, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(653, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(38, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // cardType
            // 
            this.cardType.HeaderText = "CARD TYPE";
            this.cardType.Name = "cardType";
            this.cardType.ReadOnly = true;
            // 
            // cardNumber
            // 
            this.cardNumber.HeaderText = "CARD NUMBER";
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "ADDRESS";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // CITY
            // 
            this.CITY.HeaderText = "CITY";
            this.CITY.Name = "CITY";
            this.CITY.ReadOnly = true;
            // 
            // state
            // 
            this.state.HeaderText = "STATE";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 50;
            // 
            // code
            // 
            this.code.HeaderText = "ZIP CODE";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 50;
            // 
            // shippingName
            // 
            this.shippingName.HeaderText = "SHIPPING NAME";
            this.shippingName.Name = "shippingName";
            this.shippingName.ReadOnly = true;
            this.shippingName.Width = 200;
            // 
            // shippingAddress
            // 
            this.shippingAddress.HeaderText = "SHIPPING ADDRESS";
            this.shippingAddress.Name = "shippingAddress";
            this.shippingAddress.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tabControl1);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(750, 350);
            this.Load += new System.EventHandler(this.ProfileControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ckbShipping;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.TextBox txtExpYear;
        private System.Windows.Forms.TextBox txtExpMonth;
        private System.Windows.Forms.ComboBox cboCardType;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtShippingState;
        private System.Windows.Forms.TextBox txtShippingCode;
        private System.Windows.Forms.TextBox txtShippingCity;
        private System.Windows.Forms.TextBox txtShippingStAddress;
        private System.Windows.Forms.TextBox txtShippingLName;
        private System.Windows.Forms.TextBox txtShippingFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn CITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}
