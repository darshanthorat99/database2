namespace database2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.txtnames = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpercentages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.btnshowall = new System.Windows.Forms.Button();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "roll no";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtrollno
            // 
            this.txtrollno.Location = new System.Drawing.Point(163, 35);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.Size = new System.Drawing.Size(100, 22);
            this.txtrollno.TabIndex = 1;
            // 
            // txtnames
            // 
            this.txtnames.Location = new System.Drawing.Point(163, 72);
            this.txtnames.Name = "txtnames";
            this.txtnames.Size = new System.Drawing.Size(100, 22);
            this.txtnames.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "names";
            // 
            // txtpercentages
            // 
            this.txtpercentages.Location = new System.Drawing.Point(163, 164);
            this.txtpercentages.Name = "txtpercentages";
            this.txtpercentages.Size = new System.Drawing.Size(100, 22);
            this.txtpercentages.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "percentages";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(1, 219);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(104, 23);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(163, 219);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 23);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(293, 219);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 23);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(293, 35);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(109, 23);
            this.btncreate.TabIndex = 9;
            this.btncreate.Text = "create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(444, 35);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(493, 207);
            this.data.TabIndex = 10;
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(591, 267);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(179, 23);
            this.btnshowall.TabIndex = 11;
            this.btnshowall.Text = "show all";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(163, 118);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 22);
            this.txtcity.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "city";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtpercentages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrollno);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrollno;
        private System.Windows.Forms.TextBox txtnames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpercentages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label label4;
    }
}

