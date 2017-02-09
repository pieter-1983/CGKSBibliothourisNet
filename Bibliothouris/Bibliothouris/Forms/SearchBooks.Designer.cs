namespace Bibliothouris.Forms {
    partial class SearchBooks {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.AuthorFirstName = new System.Windows.Forms.TextBox();
            this.AuthorLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author Last Name";
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(142, 26);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(144, 20);
            this.ISBN.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(142, 58);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(144, 20);
            this.Title.TabIndex = 5;
            // 
            // AuthorFirstName
            // 
            this.AuthorFirstName.Location = new System.Drawing.Point(142, 89);
            this.AuthorFirstName.Name = "AuthorFirstName";
            this.AuthorFirstName.Size = new System.Drawing.Size(144, 20);
            this.AuthorFirstName.TabIndex = 6;
            // 
            // AuthorLastName
            // 
            this.AuthorLastName.Location = new System.Drawing.Point(142, 128);
            this.AuthorLastName.Name = "AuthorLastName";
            this.AuthorLastName.Size = new System.Drawing.Size(144, 20);
            this.AuthorLastName.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(24, 229);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 27);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search Book";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 268);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.AuthorLastName);
            this.Controls.Add(this.AuthorFirstName);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchBooks";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox AuthorFirstName;
        private System.Windows.Forms.TextBox AuthorLastName;
        private System.Windows.Forms.Button btnSearch;
    }
}