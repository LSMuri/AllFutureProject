namespace Client
{
    partial class CreateBook
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
            System.Windows.Forms.Label Pages;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBook));
            this.CreateButton = new System.Windows.Forms.Button();
            this.RealeseDatetextBox = new System.Windows.Forms.TextBox();
            this.PagesBox = new System.Windows.Forms.TextBox();
            this.AuthortextBox = new System.Windows.Forms.TextBox();
            this.BooktextBox = new System.Windows.Forms.TextBox();
            this.RealeseDate = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Label();
            Pages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pages
            // 
            Pages.AutoSize = true;
            Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Pages.Location = new System.Drawing.Point(40, 209);
            Pages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Pages.Name = "Pages";
            Pages.Size = new System.Drawing.Size(83, 20);
            Pages.TabIndex = 8;
            Pages.Text = "Страници";
            // 
            // CreateButton
            // 
            this.CreateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CreateButton.FlatAppearance.BorderSize = 5;
            this.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateButton.Location = new System.Drawing.Point(129, 357);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(256, 54);
            this.CreateButton.TabIndex = 14;
            this.CreateButton.Text = "Добави";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // RealeseDatetextBox
            // 
            this.RealeseDatetextBox.Location = new System.Drawing.Point(182, 303);
            this.RealeseDatetextBox.Name = "RealeseDatetextBox";
            this.RealeseDatetextBox.Size = new System.Drawing.Size(292, 20);
            this.RealeseDatetextBox.TabIndex = 10;
            // 
            // PagesBox
            // 
            this.PagesBox.Location = new System.Drawing.Point(182, 203);
            this.PagesBox.Name = "PagesBox";
            this.PagesBox.Size = new System.Drawing.Size(292, 20);
            this.PagesBox.TabIndex = 11;
            // 
            // AuthortextBox
            // 
            this.AuthortextBox.Location = new System.Drawing.Point(182, 118);
            this.AuthortextBox.Name = "AuthortextBox";
            this.AuthortextBox.Size = new System.Drawing.Size(292, 20);
            this.AuthortextBox.TabIndex = 12;
            // 
            // BooktextBox
            // 
            this.BooktextBox.Location = new System.Drawing.Point(182, 43);
            this.BooktextBox.Name = "BooktextBox";
            this.BooktextBox.Size = new System.Drawing.Size(292, 20);
            this.BooktextBox.TabIndex = 13;
            // 
            // RealeseDate
            // 
            this.RealeseDate.AutoSize = true;
            this.RealeseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RealeseDate.Location = new System.Drawing.Point(40, 309);
            this.RealeseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RealeseDate.Name = "RealeseDate";
            this.RealeseDate.Size = new System.Drawing.Size(75, 20);
            this.RealeseDate.TabIndex = 9;
            this.RealeseDate.Text = "Издание";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(40, 124);
            this.Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(56, 20);
            this.Author.TabIndex = 7;
            this.Author.Text = "Автор";
            // 
            // Book
            // 
            this.Book.AutoSize = true;
            this.Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Book.Location = new System.Drawing.Point(40, 44);
            this.Book.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(53, 20);
            this.Book.TabIndex = 6;
            this.Book.Text = "Книга";
            // 
            // CreateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 455);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.RealeseDatetextBox);
            this.Controls.Add(this.PagesBox);
            this.Controls.Add(this.AuthortextBox);
            this.Controls.Add(this.BooktextBox);
            this.Controls.Add(this.RealeseDate);
            this.Controls.Add(Pages);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateBook";
            this.Text = "Създаване на книга";
            this.Load += new System.EventHandler(this.CreateBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox RealeseDatetextBox;
        private System.Windows.Forms.TextBox PagesBox;
        private System.Windows.Forms.TextBox AuthortextBox;
        private System.Windows.Forms.TextBox BooktextBox;
        private System.Windows.Forms.Label RealeseDate;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Book;
    }
}