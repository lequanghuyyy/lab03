﻿namespace Lab03
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTimKiem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDSSV = new System.Windows.Forms.Label();
            this.comboBoxQueQuan = new System.Windows.Forms.ComboBox();
            this.buttonTatca = new System.Windows.Forms.Button();
            this.buttonXemIn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXemIn);
            this.panel1.Controls.Add(this.buttonTatca);
            this.panel1.Controls.Add(this.comboBoxQueQuan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelTimKiem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 101);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.labelDSSV);
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 342);
            this.panel2.TabIndex = 1;
            // 
            // labelTimKiem
            // 
            this.labelTimKiem.AutoSize = true;
            this.labelTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimKiem.Location = new System.Drawing.Point(12, 19);
            this.labelTimKiem.Name = "labelTimKiem";
            this.labelTimKiem.Size = new System.Drawing.Size(73, 20);
            this.labelTimKiem.TabIndex = 0;
            this.labelTimKiem.Text = "Tìm Kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quên Quán";
            // 
            // labelDSSV
            // 
            this.labelDSSV.AutoSize = true;
            this.labelDSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSSV.Location = new System.Drawing.Point(13, 9);
            this.labelDSSV.Name = "labelDSSV";
            this.labelDSSV.Size = new System.Drawing.Size(151, 20);
            this.labelDSSV.TabIndex = 2;
            this.labelDSSV.Text = "Danh sách sinh viên";
            // 
            // comboBoxQueQuan
            // 
            this.comboBoxQueQuan.FormattingEnabled = true;
            this.comboBoxQueQuan.Location = new System.Drawing.Point(109, 64);
            this.comboBoxQueQuan.Name = "comboBoxQueQuan";
            this.comboBoxQueQuan.Size = new System.Drawing.Size(439, 21);
            this.comboBoxQueQuan.TabIndex = 2;
            this.comboBoxQueQuan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxQueQuan.SelectedValueChanged += new System.EventHandler(this.comboBoxQueQuan_SelectedValueChanged);
            // 
            // buttonTatca
            // 
            this.buttonTatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTatca.Location = new System.Drawing.Point(576, 64);
            this.buttonTatca.Name = "buttonTatca";
            this.buttonTatca.Size = new System.Drawing.Size(75, 23);
            this.buttonTatca.TabIndex = 3;
            this.buttonTatca.Text = "Tất cả";
            this.buttonTatca.UseVisualStyleBackColor = true;
            this.buttonTatca.Click += new System.EventHandler(this.buttonTatca_Click);
            // 
            // buttonXemIn
            // 
            this.buttonXemIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemIn.Location = new System.Drawing.Point(681, 64);
            this.buttonXemIn.Name = "buttonXemIn";
            this.buttonXemIn.Size = new System.Drawing.Size(75, 23);
            this.buttonXemIn.TabIndex = 4;
            this.buttonXemIn.Text = "Xem in";
            this.buttonXemIn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 307);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tìm kiếm sinh viên theo quê quán";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxQueQuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDSSV;
        private System.Windows.Forms.Button buttonXemIn;
        private System.Windows.Forms.Button buttonTatca;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

