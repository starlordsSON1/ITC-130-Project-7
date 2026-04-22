namespace Aiden_Tschebykin_7
{
    partial class Project7Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtFirstInitial = new System.Windows.Forms.TextBox();
            this.txtLastInitial = new System.Windows.Forms.TextBox();
            this.lblFirstInitial = new System.Windows.Forms.Label();
            this.lblLastInitial = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 15);
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(100, 16);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 15);
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(100, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 23);
            this.txtLastName.TabIndex = 1;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(20, 100);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(36, 15);
            this.lblState.Text = "State:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(100, 96);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 23);
            this.txtState.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.Text = "Save";
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 15;
            this.lstCustomers.Location = new System.Drawing.Point(320, 16);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(240, 199);
            this.lstCustomers.Sorted = true;
            this.lstCustomers.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(340, 225);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.Text = "Search";
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFirstInitial
            // 
            this.lblFirstInitial.AutoSize = true;
            this.lblFirstInitial.Location = new System.Drawing.Point(20, 180);
            this.lblFirstInitial.Name = "lblFirstInitial";
            this.lblFirstInitial.Size = new System.Drawing.Size(61, 15);
            this.lblFirstInitial.Text = "First Initial:";
            // 
            // txtFirstInitial
            // 
            this.txtFirstInitial.Location = new System.Drawing.Point(100, 176);
            this.txtFirstInitial.Name = "txtFirstInitial";
            this.txtFirstInitial.Size = new System.Drawing.Size(50, 23);
            this.txtFirstInitial.TabIndex = 6;
            // 
            // lblLastInitial
            // 
            this.lblLastInitial.AutoSize = true;
            this.lblLastInitial.Location = new System.Drawing.Point(160, 180);
            this.lblLastInitial.Name = "lblLastInitial";
            this.lblLastInitial.Size = new System.Drawing.Size(60, 15);
            this.lblLastInitial.Text = "Last Initial:";
            // 
            // txtLastInitial
            // 
            this.txtLastInitial.Location = new System.Drawing.Point(230, 176);
            this.txtLastInitial.Name = "txtLastInitial";
            this.txtLastInitial.Size = new System.Drawing.Size(50, 23);
            this.txtLastInitial.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(485, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.Text = "Exit";
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Project7Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 270);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblFirstInitial);
            this.Controls.Add(this.txtFirstInitial);
            this.Controls.Add(this.lblLastInitial);
            this.Controls.Add(this.txtLastInitial);
            this.Controls.Add(this.btnExit);
            this.Name = "Project7Form";
            this.Text = "Aiden Tschebykin";
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnExit;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtFirstInitial;
        private System.Windows.Forms.TextBox txtLastInitial;
        private System.Windows.Forms.Label lblFirstInitial;
        private System.Windows.Forms.Label lblLastInitial;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;

        #endregion
    }
}
