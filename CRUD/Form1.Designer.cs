﻿namespace CRUD
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtNIM = new System.Windows.Forms.MaskedTextBox();
            this.txtTelepon = new System.Windows.Forms.MaskedTextBox();
            this.txtNama = new System.Windows.Forms.MaskedTextBox();
            this.txtAlamat = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "Tambah";
            this.button1.Location = new System.Drawing.Point(607, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Hapus";
            this.button2.Location = new System.Drawing.Point(607, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "Ubah";
            this.button3.Location = new System.Drawing.Point(607, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ubah";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "Refresh";
            this.button4.Location = new System.Drawing.Point(607, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(176, 59);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(386, 26);
            this.txtNIM.TabIndex = 4;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(176, 241);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(386, 26);
            this.txtTelepon.TabIndex = 5;
            this.txtTelepon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(176, 122);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(386, 26);
            this.txtNama.TabIndex = 6;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(176, 182);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(386, 26);
            this.txtAlamat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AccessibleName = "NIM";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "NIM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "Nama";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AccessibleName = "Alamat";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alamat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AccessibleName = "Telepon";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telepon";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(71, 380);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.RowHeadersWidth = 62;
            this.dgvMahasiswa.RowTemplate.Height = 28;
            this.dgvMahasiswa.Size = new System.Drawing.Size(611, 178);
            this.dgvMahasiswa.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AccessibleName = "Email";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 303);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(386, 26);
            this.txtEmail.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox txtNIM;
        private System.Windows.Forms.MaskedTextBox txtTelepon;
        private System.Windows.Forms.MaskedTextBox txtNama;
        private System.Windows.Forms.MaskedTextBox txtAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtEmail;
    }
}

