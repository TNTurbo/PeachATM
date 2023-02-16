namespace PeachATM
{
    partial class Main
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
            this.btnDepositCash = new System.Windows.Forms.Button();
            this.btnDepositCheck = new System.Windows.Forms.Button();
            this.btnMockDD = new System.Windows.Forms.Button();
            this.btnGenerateCashierCheck = new System.Windows.Forms.Button();
            this.btnWithdrawCash = new System.Windows.Forms.Button();
            this.gbQuickActions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFunds = new System.Windows.Forms.TextBox();
            this.txtDDStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDDNumber = new System.Windows.Forms.TextBox();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbQuickActions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepositCash
            // 
            this.btnDepositCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDepositCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositCash.Location = new System.Drawing.Point(6, 19);
            this.btnDepositCash.Name = "btnDepositCash";
            this.btnDepositCash.Size = new System.Drawing.Size(101, 39);
            this.btnDepositCash.TabIndex = 0;
            this.btnDepositCash.Text = "Deposit Cash";
            this.btnDepositCash.UseVisualStyleBackColor = false;
            this.btnDepositCash.Click += new System.EventHandler(this.btnDepositCash_Click);
            // 
            // btnDepositCheck
            // 
            this.btnDepositCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDepositCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositCheck.Location = new System.Drawing.Point(6, 64);
            this.btnDepositCheck.Name = "btnDepositCheck";
            this.btnDepositCheck.Size = new System.Drawing.Size(101, 39);
            this.btnDepositCheck.TabIndex = 1;
            this.btnDepositCheck.Text = "Deposit Check";
            this.btnDepositCheck.UseVisualStyleBackColor = false;
            this.btnDepositCheck.Click += new System.EventHandler(this.btnDepositCheck_Click);
            // 
            // btnMockDD
            // 
            this.btnMockDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMockDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMockDD.Location = new System.Drawing.Point(240, 138);
            this.btnMockDD.Name = "btnMockDD";
            this.btnMockDD.Size = new System.Drawing.Size(101, 39);
            this.btnMockDD.TabIndex = 2;
            this.btnMockDD.Text = "Mock Direct Deposit";
            this.btnMockDD.UseVisualStyleBackColor = false;
            this.btnMockDD.Click += new System.EventHandler(this.btnMockDD_Click);
            // 
            // btnGenerateCashierCheck
            // 
            this.btnGenerateCashierCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGenerateCashierCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateCashierCheck.Location = new System.Drawing.Point(113, 64);
            this.btnGenerateCashierCheck.Name = "btnGenerateCashierCheck";
            this.btnGenerateCashierCheck.Size = new System.Drawing.Size(101, 39);
            this.btnGenerateCashierCheck.TabIndex = 4;
            this.btnGenerateCashierCheck.Text = "Generate Cashier\'s Check";
            this.btnGenerateCashierCheck.UseVisualStyleBackColor = false;
            this.btnGenerateCashierCheck.Click += new System.EventHandler(this.btnGenerateCashierCheck_Click);
            // 
            // btnWithdrawCash
            // 
            this.btnWithdrawCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWithdrawCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdrawCash.Location = new System.Drawing.Point(113, 19);
            this.btnWithdrawCash.Name = "btnWithdrawCash";
            this.btnWithdrawCash.Size = new System.Drawing.Size(101, 39);
            this.btnWithdrawCash.TabIndex = 3;
            this.btnWithdrawCash.Text = "Withdraw Cash";
            this.btnWithdrawCash.UseVisualStyleBackColor = false;
            this.btnWithdrawCash.Click += new System.EventHandler(this.btnWithdrawCash_Click);
            // 
            // gbQuickActions
            // 
            this.gbQuickActions.Controls.Add(this.btnDepositCash);
            this.gbQuickActions.Controls.Add(this.btnGenerateCashierCheck);
            this.gbQuickActions.Controls.Add(this.btnDepositCheck);
            this.gbQuickActions.Controls.Add(this.btnWithdrawCash);
            this.gbQuickActions.Location = new System.Drawing.Point(12, 12);
            this.gbQuickActions.Name = "gbQuickActions";
            this.gbQuickActions.Size = new System.Drawing.Size(222, 112);
            this.gbQuickActions.TabIndex = 5;
            this.gbQuickActions.TabStop = false;
            this.gbQuickActions.Text = "Quick Actions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Funds:";
            // 
            // txtFunds
            // 
            this.txtFunds.Location = new System.Drawing.Point(10, 37);
            this.txtFunds.Name = "txtFunds";
            this.txtFunds.ReadOnly = true;
            this.txtFunds.Size = new System.Drawing.Size(157, 20);
            this.txtFunds.TabIndex = 7;
            this.txtFunds.Text = "100";
            // 
            // txtDDStatus
            // 
            this.txtDDStatus.Location = new System.Drawing.Point(10, 83);
            this.txtDDStatus.Name = "txtDDStatus";
            this.txtDDStatus.ReadOnly = true;
            this.txtDDStatus.Size = new System.Drawing.Size(157, 20);
            this.txtDDStatus.TabIndex = 9;
            this.txtDDStatus.Text = "Unqualified";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Direct Deposit Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDDStatus);
            this.groupBox1.Controls.Add(this.txtFunds);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(240, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDDNumber);
            this.groupBox2.Controls.Add(this.txtAccountHolder);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Holder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // txtDDNumber
            // 
            this.txtDDNumber.Location = new System.Drawing.Point(10, 83);
            this.txtDDNumber.Name = "txtDDNumber";
            this.txtDDNumber.ReadOnly = true;
            this.txtDDNumber.Size = new System.Drawing.Size(204, 20);
            this.txtDDNumber.TabIndex = 9;
            this.txtDDNumber.Text = "03131997-1337";
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Location = new System.Drawing.Point(10, 37);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.ReadOnly = true;
            this.txtAccountHolder.Size = new System.Drawing.Size(204, 20);
            this.txtAccountHolder.TabIndex = 7;
            this.txtAccountHolder.Text = "Jacob Kenneth McCarty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Direct Deposit Number:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(432, 254);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbQuickActions);
            this.Controls.Add(this.btnMockDD);
            this.Name = "Main";
            this.Text = "PeachTree ATM";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbQuickActions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepositCash;
        private System.Windows.Forms.Button btnDepositCheck;
        private System.Windows.Forms.Button btnMockDD;
        private System.Windows.Forms.Button btnGenerateCashierCheck;
        private System.Windows.Forms.Button btnWithdrawCash;
        private System.Windows.Forms.GroupBox gbQuickActions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFunds;
        private System.Windows.Forms.TextBox txtDDStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDDNumber;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.Label label4;
    }
}

