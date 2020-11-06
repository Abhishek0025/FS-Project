namespace student
{
    partial class Pan_Display
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
            this.display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pan_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IFSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FathernName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(208, 320);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(135, 43);
            this.display.TabIndex = 24;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pan_No,
            this.Name1,
            this.AccNo,
            this.IFSC,
            this.FathernName,
            this.DOB,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 293);
            this.dataGridView1.TabIndex = 23;
            // 
            // Pan_No
            // 
            this.Pan_No.HeaderText = "PAN Number";
            this.Pan_No.Name = "Pan_No";
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            // 
            // AccNo
            // 
            this.AccNo.HeaderText = "Account No";
            this.AccNo.Name = "AccNo";
            // 
            // IFSC
            // 
            this.IFSC.HeaderText = "IFSC Code";
            this.IFSC.Name = "IFSC";
            // 
            // FathernName
            // 
            this.FathernName.HeaderText = "Father Name";
            this.FathernName.Name = "FathernName";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Date Of Birth";
            this.DOB.Name = "DOB";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 38;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pan_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pan_Display";
            this.Text = "View All PAN Records";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pan_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IFSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FathernName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}