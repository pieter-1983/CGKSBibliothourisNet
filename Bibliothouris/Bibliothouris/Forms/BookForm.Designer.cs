﻿namespace Bibliothouris.Forms
{
    partial class BookForm
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
            this.bookView = new System.Windows.Forms.ListView();
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthorFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthorLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookView
            // 
            this.bookView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.Title,
            this.AuthorFirstName,
            this.AuthorLastName});
            this.bookView.Location = new System.Drawing.Point(12, 12);
            this.bookView.Name = "bookView";
            this.bookView.Size = new System.Drawing.Size(391, 216);
            this.bookView.TabIndex = 0;
            this.bookView.UseCompatibleStateImageBehavior = false;
            this.bookView.View = System.Windows.Forms.View.Details;
            this.bookView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            // 
            // AuthorFirstName
            // 
            this.AuthorFirstName.Text = "Author First Name";
            this.AuthorFirstName.Width = 105;
            // 
            // AuthorLastName
            // 
            this.AuthorLastName.Text = "Author last name";
            this.AuthorLastName.Width = 101;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(125, 245);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(127, 23);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Search book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 376);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookView);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView bookView;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader AuthorFirstName;
        private System.Windows.Forms.ColumnHeader AuthorLastName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearchBook;
    }
}