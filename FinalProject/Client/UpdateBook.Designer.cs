namespace Client
{
    partial class UpdateBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBook));
            this.RealeseDateTextBox = new System.Windows.Forms.TextBox();
            this.PagesTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.BookTextBox = new System.Windows.Forms.TextBox();
            this.RealeseDate = new System.Windows.Forms.Label();
            this.Pages = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RealeseDateTextBox
            // 
            this.RealeseDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RealeseDateTextBox.Location = new System.Drawing.Point(153, 187);
            this.RealeseDateTextBox.Name = "RealeseDateTextBox";
            this.RealeseDateTextBox.Size = new System.Drawing.Size(294, 26);
            this.RealeseDateTextBox.TabIndex = 8;
            // 
            // PagesTextBox
            // 
            this.PagesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PagesTextBox.Location = new System.Drawing.Point(153, 132);
            this.PagesTextBox.Name = "PagesTextBox";
            this.PagesTextBox.Size = new System.Drawing.Size(294, 26);
            this.PagesTextBox.TabIndex = 9;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AuthorTextBox.Location = new System.Drawing.Point(153, 76);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(294, 26);
            this.AuthorTextBox.TabIndex = 10;
            // 
            // BookTextBox
            // 
            this.BookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BookTextBox.Location = new System.Drawing.Point(153, 27);
            this.BookTextBox.Name = "BookTextBox";
            this.BookTextBox.Size = new System.Drawing.Size(294, 26);
            this.BookTextBox.TabIndex = 11;
            // 
            // RealeseDate
            // 
            this.RealeseDate.AutoSize = true;
            this.RealeseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RealeseDate.Location = new System.Drawing.Point(26, 193);
            this.RealeseDate.Name = "RealeseDate";
            this.RealeseDate.Size = new System.Drawing.Size(75, 20);
            this.RealeseDate.TabIndex = 4;
            this.RealeseDate.Text = "Издание";
            // 
            // Pages
            // 
            this.Pages.AutoSize = true;
            this.Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Pages.Location = new System.Drawing.Point(25, 138);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(83, 20);
            this.Pages.TabIndex = 5;
            this.Pages.Text = "Страници";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Author.Location = new System.Drawing.Point(26, 82);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(56, 20);
            this.Author.TabIndex = 6;
            this.Author.Text = "Автор";
            // 
            // Book
            // 
            this.Book.AutoSize = true;
            this.Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Book.Location = new System.Drawing.Point(26, 33);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(53, 20);
            this.Book.TabIndex = 7;
            this.Book.Text = "Книга";
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpdateButton.FlatAppearance.BorderSize = 5;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.UpdateButton.Location = new System.Drawing.Point(79, 242);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(320, 43);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Обнови";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 311);
            this.Controls.Add(this.RealeseDateTextBox);
            this.Controls.Add(this.PagesTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.BookTextBox);
            this.Controls.Add(this.RealeseDate);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.UpdateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateBook";
            this.Text = "Обновете информацията";
            this.Load += new System.EventHandler(this.UpdateBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RealeseDateTextBox;
        private System.Windows.Forms.TextBox PagesTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox BookTextBox;
        private System.Windows.Forms.Label RealeseDate;
        private System.Windows.Forms.Label Pages;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Book;
        private System.Windows.Forms.Button UpdateButton;
    }
}