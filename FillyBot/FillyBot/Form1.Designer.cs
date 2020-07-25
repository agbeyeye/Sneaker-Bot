namespace FillyBot
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnNewStore = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnProxies = new System.Windows.Forms.Button();
            this.pnlProxies = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnViewTask = new System.Windows.Forms.Button();
            this.pnlView = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileControl1 = new FillyBot.UIControls.ProfileControl();
            this.createTaskControl1 = new FillyBot.UIControls.CreateTaskControl();
            this.viewTasksControl1 = new FillyBot.UIControls.ViewTasksControl();
            this.proxyControl1 = new FillyBot.UIControls.ProxyControl();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenu.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.btnNewStore);
            this.pnlMenu.Controls.Add(this.panel8);
            this.pnlMenu.Controls.Add(this.panel6);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(784, 40);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnNewStore
            // 
            this.btnNewStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewStore.FlatAppearance.BorderSize = 0;
            this.btnNewStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewStore.ForeColor = System.Drawing.Color.White;
            this.btnNewStore.Image = ((System.Drawing.Image)(resources.GetObject("btnNewStore.Image")));
            this.btnNewStore.Location = new System.Drawing.Point(742, 10);
            this.btnNewStore.Name = "btnNewStore";
            this.btnNewStore.Size = new System.Drawing.Size(37, 23);
            this.btnNewStore.TabIndex = 4;
            this.btnNewStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNewStore, "New Store");
            this.btnNewStore.UseMnemonic = false;
            this.btnNewStore.UseVisualStyleBackColor = true;
            this.btnNewStore.Click += new System.EventHandler(this.btnNewStore_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnProxies);
            this.panel8.Controls.Add(this.pnlProxies);
            this.panel8.Location = new System.Drawing.Point(480, 7);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 30);
            this.panel8.TabIndex = 3;
            // 
            // btnProxies
            // 
            this.btnProxies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProxies.FlatAppearance.BorderSize = 0;
            this.btnProxies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxies.ForeColor = System.Drawing.Color.White;
            this.btnProxies.Image = ((System.Drawing.Image)(resources.GetObject("btnProxies.Image")));
            this.btnProxies.Location = new System.Drawing.Point(0, 0);
            this.btnProxies.Name = "btnProxies";
            this.btnProxies.Size = new System.Drawing.Size(150, 27);
            this.btnProxies.TabIndex = 2;
            this.btnProxies.Text = "Proxies";
            this.btnProxies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProxies.UseVisualStyleBackColor = true;
            this.btnProxies.Click += new System.EventHandler(this.btnProxies_Click);
            // 
            // pnlProxies
            // 
            this.pnlProxies.BackColor = System.Drawing.Color.Red;
            this.pnlProxies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProxies.Location = new System.Drawing.Point(0, 27);
            this.pnlProxies.Name = "pnlProxies";
            this.pnlProxies.Size = new System.Drawing.Size(150, 3);
            this.pnlProxies.TabIndex = 1;
            this.pnlProxies.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnProfiles);
            this.panel6.Controls.Add(this.pnlProfile);
            this.panel6.Location = new System.Drawing.Point(324, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 30);
            this.panel6.TabIndex = 2;
            // 
            // btnProfiles
            // 
            this.btnProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProfiles.FlatAppearance.BorderSize = 0;
            this.btnProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfiles.ForeColor = System.Drawing.Color.White;
            this.btnProfiles.Image = global::FillyBot.Properties.Resources.open_menu;
            this.btnProfiles.Location = new System.Drawing.Point(0, 0);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Size = new System.Drawing.Size(150, 27);
            this.btnProfiles.TabIndex = 2;
            this.btnProfiles.Text = "Profiles";
            this.btnProfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfiles.UseVisualStyleBackColor = true;
            this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.Red;
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProfile.Location = new System.Drawing.Point(0, 27);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(150, 3);
            this.pnlProfile.TabIndex = 1;
            this.pnlProfile.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnViewTask);
            this.panel4.Controls.Add(this.pnlView);
            this.panel4.Location = new System.Drawing.Point(168, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 30);
            this.panel4.TabIndex = 2;
            // 
            // btnViewTask
            // 
            this.btnViewTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewTask.FlatAppearance.BorderSize = 0;
            this.btnViewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTask.ForeColor = System.Drawing.Color.White;
            this.btnViewTask.Image = global::FillyBot.Properties.Resources.open_menu;
            this.btnViewTask.Location = new System.Drawing.Point(0, 0);
            this.btnViewTask.Name = "btnViewTask";
            this.btnViewTask.Size = new System.Drawing.Size(150, 27);
            this.btnViewTask.TabIndex = 2;
            this.btnViewTask.Text = "View Task";
            this.btnViewTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewTask.UseVisualStyleBackColor = true;
            this.btnViewTask.Click += new System.EventHandler(this.btnViewTask_Click);
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.Red;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlView.Location = new System.Drawing.Point(0, 27);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(150, 3);
            this.pnlView.TabIndex = 1;
            this.pnlView.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCreateTask);
            this.panel2.Controls.Add(this.pnlCreate);
            this.panel2.Location = new System.Drawing.Point(12, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 30);
            this.panel2.TabIndex = 0;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateTask.FlatAppearance.BorderSize = 0;
            this.btnCreateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTask.ForeColor = System.Drawing.Color.White;
            this.btnCreateTask.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateTask.Image")));
            this.btnCreateTask.Location = new System.Drawing.Point(0, 0);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(150, 27);
            this.btnCreateTask.TabIndex = 1;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // pnlCreate
            // 
            this.pnlCreate.BackColor = System.Drawing.Color.Red;
            this.pnlCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCreate.Location = new System.Drawing.Point(0, 27);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(150, 3);
            this.pnlCreate.TabIndex = 1;
            this.pnlCreate.Visible = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(784, 380);
            this.pnlMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.profileControl1);
            this.panel1.Controls.Add(this.createTaskControl1);
            this.panel1.Controls.Add(this.viewTasksControl1);
            this.panel1.Controls.Add(this.proxyControl1);
            this.panel1.Location = new System.Drawing.Point(18, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 350);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // profileControl1
            // 
            this.profileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.profileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileControl1.Location = new System.Drawing.Point(0, 0);
            this.profileControl1.Name = "profileControl1";
            this.profileControl1.Size = new System.Drawing.Size(750, 350);
            this.profileControl1.TabIndex = 1;
            this.profileControl1.Visible = false;
            // 
            // createTaskControl1
            // 
            this.createTaskControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.createTaskControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createTaskControl1.Location = new System.Drawing.Point(0, 0);
            this.createTaskControl1.Name = "createTaskControl1";
            this.createTaskControl1.Size = new System.Drawing.Size(750, 350);
            this.createTaskControl1.TabIndex = 0;
            this.createTaskControl1.Visible = false;
            // 
            // viewTasksControl1
            // 
            this.viewTasksControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.viewTasksControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTasksControl1.Location = new System.Drawing.Point(0, 0);
            this.viewTasksControl1.Name = "viewTasksControl1";
            this.viewTasksControl1.Size = new System.Drawing.Size(750, 350);
            this.viewTasksControl1.TabIndex = 3;
            // 
            // proxyControl1
            // 
            this.proxyControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.proxyControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyControl1.Location = new System.Drawing.Point(0, 0);
            this.proxyControl1.Name = "proxyControl1";
            this.proxyControl1.Size = new System.Drawing.Size(750, 350);
            this.proxyControl1.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Gray;
            this.pnlFooter.Controls.Add(this.label1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 420);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(784, 41);
            this.pnlFooter.TabIndex = 2;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(655, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Powered by Filly Coder";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMain";
            this.Text = "Sneaker Bot";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnlProxies;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.Button btnProxies;
        private System.Windows.Forms.Button btnProfiles;
        private System.Windows.Forms.Button btnViewTask;
        private System.Windows.Forms.Button btnCreateTask;
        private UIControls.CreateTaskControl createTaskControl1;
        private UIControls.ViewTasksControl viewTasksControl1;
        private UIControls.ProxyControl proxyControl1;
        private UIControls.ProfileControl profileControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewStore;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

