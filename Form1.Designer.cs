
namespace test_sqlite_net
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPassword = new System.Windows.Forms.Button();
            this.edtStmt = new System.Windows.Forms.TextBox();
            this.edtPwd = new System.Windows.Forms.TextBox();
            this.edtDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(532, 142);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(57, 58);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(79, 22);
            this.btnPassword.TabIndex = 20;
            this.btnPassword.Text = "+ password";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // edtStmt
            // 
            this.edtStmt.Location = new System.Drawing.Point(57, 95);
            this.edtStmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtStmt.Multiline = true;
            this.edtStmt.Name = "edtStmt";
            this.edtStmt.Size = new System.Drawing.Size(533, 60);
            this.edtStmt.TabIndex = 19;
            this.edtStmt.Text = "INSERT INTO [factoryCar]([sn], [name], [acronym]) VALUES(1, \'齐齐哈尔铁路车辆厂\', \'qqhr\');" +
    "";
            // 
            // edtPwd
            // 
            this.edtPwd.Location = new System.Drawing.Point(406, 22);
            this.edtPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtPwd.Name = "edtPwd";
            this.edtPwd.Size = new System.Drawing.Size(183, 21);
            this.edtPwd.TabIndex = 18;
            this.edtPwd.Text = "20130321";
            // 
            // edtDB
            // 
            this.edtDB.Location = new System.Drawing.Point(57, 20);
            this.edtDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edtDB.Name = "edtDB";
            this.edtDB.Size = new System.Drawing.Size(282, 21);
            this.edtDB.TabIndex = 17;
            this.edtDB.Text = "tdtc_scale.db";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "sql:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "DB:";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(594, 133);
            this.btnExec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(64, 23);
            this.btnExec.TabIndex = 13;
            this.btnExec.Text = "exec";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(596, 95);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 22);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(264, 57);
            this.btnGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 24);
            this.btnGen.TabIndex = 11;
            this.btnGen.Text = "Gen Table";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 318);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.edtStmt);
            this.Controls.Add(this.edtPwd);
            this.Controls.Add(this.edtDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test SQLite - v1.0.112";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.TextBox edtStmt;
        private System.Windows.Forms.TextBox edtPwd;
        private System.Windows.Forms.TextBox edtDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGen;
    }
}

