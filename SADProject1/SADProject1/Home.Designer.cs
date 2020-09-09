namespace SADProject1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bclose1 = new System.Windows.Forms.Button();
            this.Bclose = new System.Windows.Forms.Button();
            this.Blogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.working = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.rentToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Visible = false;
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.RegisterToolStripMenuItem_Click);
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.carRentToolStripMenuItem});
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.rentToolStripMenuItem.Text = "Rent";
            this.rentToolStripMenuItem.Visible = false;
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.NewCustomerToolStripMenuItem_Click_1);
            // 
            // carRentToolStripMenuItem
            // 
            this.carRentToolStripMenuItem.Name = "carRentToolStripMenuItem";
            this.carRentToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.carRentToolStripMenuItem.Text = "Car Rent";
            this.carRentToolStripMenuItem.Click += new System.EventHandler(this.CarRentToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCarToolStripMenuItem,
            this.backCarToolStripMenuItem});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Visible = false;
            // 
            // newCarToolStripMenuItem
            // 
            this.newCarToolStripMenuItem.Name = "newCarToolStripMenuItem";
            this.newCarToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.newCarToolStripMenuItem.Text = "New Car";
            this.newCarToolStripMenuItem.Click += new System.EventHandler(this.NewCarToolStripMenuItem_Click);
            // 
            // backCarToolStripMenuItem
            // 
            this.backCarToolStripMenuItem.Name = "backCarToolStripMenuItem";
            this.backCarToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.backCarToolStripMenuItem.Text = "Back Car";
            this.backCarToolStripMenuItem.Click += new System.EventHandler(this.BackCarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Bclose1);
            this.groupBox1.Controls.Add(this.Bclose);
            this.groupBox1.Controls.Add(this.Blogin);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(729, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 771);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 319);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name";
            // 
            // Bclose1
            // 
            this.Bclose1.BackColor = System.Drawing.Color.Gray;
            this.Bclose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclose1.ForeColor = System.Drawing.Color.White;
            this.Bclose1.Location = new System.Drawing.Point(6, 553);
            this.Bclose1.Name = "Bclose1";
            this.Bclose1.Size = new System.Drawing.Size(335, 46);
            this.Bclose1.TabIndex = 5;
            this.Bclose1.Text = "Close";
            this.Bclose1.UseVisualStyleBackColor = false;
            this.Bclose1.Visible = false;
            this.Bclose1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Bclose
            // 
            this.Bclose.BackColor = System.Drawing.Color.Gray;
            this.Bclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclose.ForeColor = System.Drawing.Color.White;
            this.Bclose.Location = new System.Drawing.Point(6, 429);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(335, 46);
            this.Bclose.TabIndex = 3;
            this.Bclose.Text = "Close";
            this.Bclose.UseVisualStyleBackColor = false;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // Blogin
            // 
            this.Blogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Blogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blogin.Location = new System.Drawing.Point(6, 344);
            this.Blogin.Name = "Blogin";
            this.Blogin.Size = new System.Drawing.Size(335, 79);
            this.Blogin.TabIndex = 2;
            this.Blogin.Text = "Log in";
            this.Blogin.UseVisualStyleBackColor = false;
            this.Blogin.Click += new System.EventHandler(this.Blogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(95, 261);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(246, 36);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(95, 208);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(246, 36);
            this.txtUser.TabIndex = 0;
            // 
            // working
            // 
            this.working.AutoSize = true;
            this.working.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.working.Location = new System.Drawing.Point(1017, 5);
            this.working.Name = "working";
            this.working.Size = new System.Drawing.Size(60, 17);
            this.working.TabIndex = 3;
            this.working.Text = "Working";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(989, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Not";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1082, 803);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.working);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Car Rent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.Button Blogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carRentToolStripMenuItem;
        private System.Windows.Forms.Label working;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Bclose1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backCarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}