﻿namespace AlisPark.WebFormsUI
{
    partial class AdminPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.gbxSearchByMemberName = new System.Windows.Forms.GroupBox();
            this.tbxMemberNameSearchLog = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnRemoveLogs = new System.Windows.Forms.Button();
            this.gbxAddWorker = new System.Windows.Forms.GroupBox();
            this.btnWorkerAdd = new System.Windows.Forms.Button();
            this.tbxWorkerPhoneAdd = new System.Windows.Forms.TextBox();
            this.tbxWorkerPasswordAdd = new System.Windows.Forms.TextBox();
            this.tbxWorkerUserNameAdd = new System.Windows.Forms.TextBox();
            this.lblMemberPhoneAdd = new System.Windows.Forms.Label();
            this.lblSurnameAdd = new System.Windows.Forms.Label();
            this.lblMemberNameAdd = new System.Windows.Forms.Label();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWorkerUpdate = new System.Windows.Forms.Button();
            this.tbxWorkerPhoneUpdate = new System.Windows.Forms.TextBox();
            this.tbxWorkerPasswordUpdate = new System.Windows.Forms.TextBox();
            this.tbxWorkerUserNameUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWorkerDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.gbxSearchByMemberName.SuspendLayout();
            this.gbxAddWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogs
            // 
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Location = new System.Drawing.Point(10, 82);
            this.dgvLogs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogs.RowTemplate.Height = 24;
            this.dgvLogs.Size = new System.Drawing.Size(791, 149);
            this.dgvLogs.TabIndex = 0;
            this.dgvLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogs_CellContentClick);
            // 
            // gbxSearchByMemberName
            // 
            this.gbxSearchByMemberName.Controls.Add(this.tbxMemberNameSearchLog);
            this.gbxSearchByMemberName.Controls.Add(this.lblMemberName);
            this.gbxSearchByMemberName.Location = new System.Drawing.Point(10, 11);
            this.gbxSearchByMemberName.Name = "gbxSearchByMemberName";
            this.gbxSearchByMemberName.Padding = new System.Windows.Forms.Padding(10);
            this.gbxSearchByMemberName.Size = new System.Drawing.Size(400, 60);
            this.gbxSearchByMemberName.TabIndex = 3;
            this.gbxSearchByMemberName.TabStop = false;
            this.gbxSearchByMemberName.Text = "Kayıtlarda Ara";
            // 
            // tbxMemberNameSearchLog
            // 
            this.tbxMemberNameSearchLog.Location = new System.Drawing.Point(130, 30);
            this.tbxMemberNameSearchLog.Name = "tbxMemberNameSearchLog";
            this.tbxMemberNameSearchLog.Size = new System.Drawing.Size(200, 20);
            this.tbxMemberNameSearchLog.TabIndex = 1;
            this.tbxMemberNameSearchLog.TextChanged += new System.EventHandler(this.tbxMemberNameSearchLog_TextChanged);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(15, 30);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(93, 13);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Aranacak Kelime :";
            // 
            // btnRemoveLogs
            // 
            this.btnRemoveLogs.Location = new System.Drawing.Point(661, 10);
            this.btnRemoveLogs.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveLogs.Name = "btnRemoveLogs";
            this.btnRemoveLogs.Size = new System.Drawing.Size(131, 23);
            this.btnRemoveLogs.TabIndex = 4;
            this.btnRemoveLogs.Text = "Kayıt Sil";
            this.btnRemoveLogs.UseVisualStyleBackColor = true;
            this.btnRemoveLogs.Click += new System.EventHandler(this.btnRemoveLogs_Click);
            // 
            // gbxAddWorker
            // 
            this.gbxAddWorker.Controls.Add(this.btnWorkerAdd);
            this.gbxAddWorker.Controls.Add(this.tbxWorkerPhoneAdd);
            this.gbxAddWorker.Controls.Add(this.tbxWorkerPasswordAdd);
            this.gbxAddWorker.Controls.Add(this.tbxWorkerUserNameAdd);
            this.gbxAddWorker.Controls.Add(this.lblMemberPhoneAdd);
            this.gbxAddWorker.Controls.Add(this.lblSurnameAdd);
            this.gbxAddWorker.Controls.Add(this.lblMemberNameAdd);
            this.gbxAddWorker.Location = new System.Drawing.Point(10, 390);
            this.gbxAddWorker.Name = "gbxAddWorker";
            this.gbxAddWorker.Size = new System.Drawing.Size(796, 114);
            this.gbxAddWorker.TabIndex = 5;
            this.gbxAddWorker.TabStop = false;
            this.gbxAddWorker.Text = "Çalışan Ekle";
            // 
            // btnWorkerAdd
            // 
            this.btnWorkerAdd.Location = new System.Drawing.Point(639, 77);
            this.btnWorkerAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnWorkerAdd.Name = "btnWorkerAdd";
            this.btnWorkerAdd.Size = new System.Drawing.Size(56, 19);
            this.btnWorkerAdd.TabIndex = 21;
            this.btnWorkerAdd.Text = "Ekle";
            this.btnWorkerAdd.UseVisualStyleBackColor = true;
            this.btnWorkerAdd.Click += new System.EventHandler(this.btnWorkerAdd_Click);
            // 
            // tbxWorkerPhoneAdd
            // 
            this.tbxWorkerPhoneAdd.Location = new System.Drawing.Point(134, 78);
            this.tbxWorkerPhoneAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tbxWorkerPhoneAdd.Name = "tbxWorkerPhoneAdd";
            this.tbxWorkerPhoneAdd.Size = new System.Drawing.Size(186, 20);
            this.tbxWorkerPhoneAdd.TabIndex = 18;
            // 
            // tbxWorkerPasswordAdd
            // 
            this.tbxWorkerPasswordAdd.Location = new System.Drawing.Point(510, 30);
            this.tbxWorkerPasswordAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tbxWorkerPasswordAdd.Name = "tbxWorkerPasswordAdd";
            this.tbxWorkerPasswordAdd.Size = new System.Drawing.Size(186, 20);
            this.tbxWorkerPasswordAdd.TabIndex = 17;
            // 
            // tbxWorkerUserNameAdd
            // 
            this.tbxWorkerUserNameAdd.Location = new System.Drawing.Point(134, 30);
            this.tbxWorkerUserNameAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tbxWorkerUserNameAdd.Name = "tbxWorkerUserNameAdd";
            this.tbxWorkerUserNameAdd.Size = new System.Drawing.Size(186, 20);
            this.tbxWorkerUserNameAdd.TabIndex = 16;
            // 
            // lblMemberPhoneAdd
            // 
            this.lblMemberPhoneAdd.AutoSize = true;
            this.lblMemberPhoneAdd.Location = new System.Drawing.Point(30, 83);
            this.lblMemberPhoneAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberPhoneAdd.Name = "lblMemberPhoneAdd";
            this.lblMemberPhoneAdd.Size = new System.Drawing.Size(49, 13);
            this.lblMemberPhoneAdd.TabIndex = 13;
            this.lblMemberPhoneAdd.Text = "Telefon :";
            // 
            // lblSurnameAdd
            // 
            this.lblSurnameAdd.AutoSize = true;
            this.lblSurnameAdd.Location = new System.Drawing.Point(430, 35);
            this.lblSurnameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurnameAdd.Name = "lblSurnameAdd";
            this.lblSurnameAdd.Size = new System.Drawing.Size(80, 13);
            this.lblSurnameAdd.TabIndex = 12;
            this.lblSurnameAdd.Text = "Çalışan Parola :";
            // 
            // lblMemberNameAdd
            // 
            this.lblMemberNameAdd.AutoSize = true;
            this.lblMemberNameAdd.Location = new System.Drawing.Point(30, 35);
            this.lblMemberNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberNameAdd.Name = "lblMemberNameAdd";
            this.lblMemberNameAdd.Size = new System.Drawing.Size(107, 13);
            this.lblMemberNameAdd.TabIndex = 11;
            this.lblMemberNameAdd.Text = "Çalışan Kullanıcı Adı :";
            // 
            // dgvWorkers
            // 
            this.dgvWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(10, 236);
            this.dgvWorkers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorkers.RowTemplate.Height = 24;
            this.dgvWorkers.Size = new System.Drawing.Size(791, 149);
            this.dgvWorkers.TabIndex = 6;
            this.dgvWorkers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkers_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWorkerUpdate);
            this.groupBox1.Controls.Add(this.tbxWorkerPhoneUpdate);
            this.groupBox1.Controls.Add(this.tbxWorkerPasswordUpdate);
            this.groupBox1.Controls.Add(this.tbxWorkerUserNameUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 510);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 114);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çalışan Bilgisi Güncelle";
            // 
            // btnWorkerUpdate
            // 
            this.btnWorkerUpdate.Location = new System.Drawing.Point(627, 79);
            this.btnWorkerUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnWorkerUpdate.Name = "btnWorkerUpdate";
            this.btnWorkerUpdate.Size = new System.Drawing.Size(68, 19);
            this.btnWorkerUpdate.TabIndex = 21;
            this.btnWorkerUpdate.Text = "Güncelle";
            this.btnWorkerUpdate.UseVisualStyleBackColor = true;
            this.btnWorkerUpdate.Click += new System.EventHandler(this.btnWorkerUpdate_Click);
            // 
            // tbxWorkerPhoneUpdate
            // 
            this.tbxWorkerPhoneUpdate.Location = new System.Drawing.Point(134, 78);
            this.tbxWorkerPhoneUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.tbxWorkerPhoneUpdate.Name = "tbxWorkerPhoneUpdate";
            this.tbxWorkerPhoneUpdate.Size = new System.Drawing.Size(186, 20);
            this.tbxWorkerPhoneUpdate.TabIndex = 18;
            // 
            // tbxWorkerPasswordUpdate
            // 
            this.tbxWorkerPasswordUpdate.Location = new System.Drawing.Point(510, 30);
            this.tbxWorkerPasswordUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.tbxWorkerPasswordUpdate.Name = "tbxWorkerPasswordUpdate";
            this.tbxWorkerPasswordUpdate.Size = new System.Drawing.Size(186, 20);
            this.tbxWorkerPasswordUpdate.TabIndex = 17;
            // 
            // tbxWorkerUserNameUpdate
            // 
            this.tbxWorkerUserNameUpdate.Location = new System.Drawing.Point(134, 30);
            this.tbxWorkerUserNameUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.tbxWorkerUserNameUpdate.Name = "tbxWorkerUserNameUpdate";
            this.tbxWorkerUserNameUpdate.Size = new System.Drawing.Size(186, 20);
            this.tbxWorkerUserNameUpdate.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Çalışan Parola :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Çalışan Kullanıcı Adı :";
            // 
            // btnWorkerDelete
            // 
            this.btnWorkerDelete.Location = new System.Drawing.Point(661, 41);
            this.btnWorkerDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnWorkerDelete.Name = "btnWorkerDelete";
            this.btnWorkerDelete.Size = new System.Drawing.Size(131, 24);
            this.btnWorkerDelete.TabIndex = 23;
            this.btnWorkerDelete.Text = "Çalışan Sil";
            this.btnWorkerDelete.UseVisualStyleBackColor = true;
            this.btnWorkerDelete.Click += new System.EventHandler(this.btnWorkerDelete_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 645);
            this.Controls.Add(this.btnWorkerDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvWorkers);
            this.Controls.Add(this.gbxAddWorker);
            this.Controls.Add(this.btnRemoveLogs);
            this.Controls.Add(this.gbxSearchByMemberName);
            this.Controls.Add(this.dgvLogs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPage";
            this.Text = "Kayıt İşlemleri";
            this.Load += new System.EventHandler(this.Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.gbxSearchByMemberName.ResumeLayout(false);
            this.gbxSearchByMemberName.PerformLayout();
            this.gbxAddWorker.ResumeLayout(false);
            this.gbxAddWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.GroupBox gbxSearchByMemberName;
        private System.Windows.Forms.TextBox tbxMemberNameSearchLog;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnRemoveLogs;
        private System.Windows.Forms.GroupBox gbxAddWorker;
        private System.Windows.Forms.Button btnWorkerAdd;
        private System.Windows.Forms.TextBox tbxWorkerPhoneAdd;
        private System.Windows.Forms.TextBox tbxWorkerPasswordAdd;
        private System.Windows.Forms.TextBox tbxWorkerUserNameAdd;
        private System.Windows.Forms.Label lblMemberPhoneAdd;
        private System.Windows.Forms.Label lblSurnameAdd;
        private System.Windows.Forms.Label lblMemberNameAdd;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWorkerUpdate;
        private System.Windows.Forms.TextBox tbxWorkerPhoneUpdate;
        private System.Windows.Forms.TextBox tbxWorkerPasswordUpdate;
        private System.Windows.Forms.TextBox tbxWorkerUserNameUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWorkerDelete;
    }
}