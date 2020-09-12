using System;
using SQLite;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsFormsApp42
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvShowNotes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddNote = new System.Windows.Forms.ToolStripButton();
            this.btnOpenNote = new System.Windows.Forms.ToolStripButton();
            this.btnEditNote = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteNote = new System.Windows.Forms.ToolStripButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbLiteDb = new System.Windows.Forms.RadioButton();
            this.rbSqliteDb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowNotes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowNotes
            // 
            this.dgvShowNotes.AllowUserToAddRows = false;
            this.dgvShowNotes.AllowUserToDeleteRows = false;
            this.dgvShowNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowNotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvShowNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Text,
            this.Date});
            this.dgvShowNotes.Location = new System.Drawing.Point(6, 20);
            this.dgvShowNotes.Name = "dgvShowNotes";
            this.dgvShowNotes.ReadOnly = true;
            this.dgvShowNotes.RowHeadersVisible = false;
            this.dgvShowNotes.Size = new System.Drawing.Size(314, 288);
            this.dgvShowNotes.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Text
            // 
            this.Text.DataPropertyName = "Text";
            this.Text.HeaderText = "متن";
            this.Text.Name = "Text";
            this.Text.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvShowNotes);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "یادداشت های اخیر";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtText);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Location = new System.Drawing.Point(335, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 363);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(6, 47);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(352, 310);
            this.txtText.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(6, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(352, 21);
            this.txtTitle.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNote,
            this.btnOpenNote,
            this.btnEditNote,
            this.btnDeleteNote});
            this.toolStrip1.Location = new System.Drawing.Point(0, 367);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(702, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddNote
            // 
            this.btnAddNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddNote.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNote.Image")));
            this.btnAddNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(68, 22);
            this.btnAddNote.Text = "اضافه کردن";
            this.btnAddNote.Click += new System.EventHandler(this.BtnAddNote_Click);
            // 
            // btnOpenNote
            // 
            this.btnOpenNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenNote.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenNote.Image")));
            this.btnOpenNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenNote.Name = "btnOpenNote";
            this.btnOpenNote.Size = new System.Drawing.Size(50, 22);
            this.btnOpenNote.Text = "باز کردن";
            // 
            // btnEditNote
            // 
            this.btnEditNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditNote.Image = ((System.Drawing.Image)(resources.GetObject("btnEditNote.Image")));
            this.btnEditNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(74, 22);
            this.btnEditNote.Text = "ویرایش کردن";
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteNote.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteNote.Image")));
            this.btnDeleteNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(63, 22);
            this.btnDeleteNote.Text = "حذف کردن";
            this.btnDeleteNote.Click += new System.EventHandler(this.BtnDeleteNote_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 379);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbLiteDb);
            this.groupBox3.Controls.Add(this.rbSqliteDb);
            this.groupBox3.Location = new System.Drawing.Point(3, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 49);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // rbLiteDb
            // 
            this.rbLiteDb.AutoSize = true;
            this.rbLiteDb.Location = new System.Drawing.Point(265, 20);
            this.rbLiteDb.Name = "rbLiteDb";
            this.rbLiteDb.Size = new System.Drawing.Size(55, 17);
            this.rbLiteDb.TabIndex = 0;
            this.rbLiteDb.TabStop = true;
            this.rbLiteDb.Text = "LiteDb";
            this.rbLiteDb.UseVisualStyleBackColor = true;
            // 
            // rbSqliteDb
            // 
            this.rbSqliteDb.AutoSize = true;
            this.rbSqliteDb.Location = new System.Drawing.Point(9, 20);
            this.rbSqliteDb.Name = "rbSqliteDb";
            this.rbSqliteDb.Size = new System.Drawing.Size(56, 17);
            this.rbSqliteDb.TabIndex = 0;
            this.rbSqliteDb.TabStop = true;
            this.rbSqliteDb.Text = "SQLite";
            this.rbSqliteDb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 392);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowNotes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddNote;
        private System.Windows.Forms.ToolStripButton btnOpenNote;
        private System.Windows.Forms.ToolStripButton btnEditNote;
        private System.Windows.Forms.ToolStripButton btnDeleteNote;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbLiteDb;
        private System.Windows.Forms.RadioButton rbSqliteDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;

       

    }
    
}

