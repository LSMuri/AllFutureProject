namespace Client
{
    partial class CreateAuthor
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
            System.Windows.Forms.Label Gender;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAuthor));
            this.CreateButton = new System.Windows.Forms.Button();
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.YeartextBox = new System.Windows.Forms.TextBox();
            this.GendertextBox = new System.Windows.Forms.TextBox();
            this.AuthortextBox = new System.Windows.Forms.TextBox();
            this.YearOfBirth = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Label();
            Gender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Gender.Location = new System.Drawing.Point(10, 216);
            Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Gender.Name = "Gender";
            Gender.Size = new System.Drawing.Size(40, 20);
            Gender.TabIndex = 25;
            Gender.Text = "Пол";
            // 
            // CreateButton
            // 
            this.CreateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CreateButton.FlatAppearance.BorderSize = 5;
            this.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateButton.Location = new System.Drawing.Point(130, 356);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(263, 55);
            this.CreateButton.TabIndex = 31;
            this.CreateButton.Text = "Добави";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // BookComboBox
            // 
            this.BookComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(191, 42);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(292, 24);
            this.BookComboBox.TabIndex = 30;
            // 
            // YeartextBox
            // 
            this.YeartextBox.Location = new System.Drawing.Point(191, 305);
            this.YeartextBox.Name = "YeartextBox";
            this.YeartextBox.Size = new System.Drawing.Size(292, 20);
            this.YeartextBox.TabIndex = 27;
            // 
            // GendertextBox
            // 
            this.GendertextBox.Location = new System.Drawing.Point(191, 216);
            this.GendertextBox.Name = "GendertextBox";
            this.GendertextBox.Size = new System.Drawing.Size(292, 20);
            this.GendertextBox.TabIndex = 28;
            // 
            // AuthortextBox
            // 
            this.AuthortextBox.Location = new System.Drawing.Point(191, 128);
            this.AuthortextBox.Name = "AuthortextBox";
            this.AuthortextBox.Size = new System.Drawing.Size(292, 20);
            this.AuthortextBox.TabIndex = 29;
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.AutoSize = true;
            this.YearOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearOfBirth.Location = new System.Drawing.Point(10, 305);
            this.YearOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearOfBirth.Name = "YearOfBirth";
            this.YearOfBirth.Size = new System.Drawing.Size(158, 20);
            this.YearOfBirth.TabIndex = 26;
            this.YearOfBirth.Text = "Година на раждане";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(10, 128);
            this.Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(56, 20);
            this.Author.TabIndex = 24;
            this.Author.Text = "Автор";
            // 
            // Book
            // 
            this.Book.AutoSize = true;
            this.Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Book.Location = new System.Drawing.Point(13, 42);
            this.Book.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(53, 20);
            this.Book.TabIndex = 23;
            this.Book.Text = "Книга";
            // 
            // CreateAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 443);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.BookComboBox);
            this.Controls.Add(this.YeartextBox);
            this.Controls.Add(this.GendertextBox);
            this.Controls.Add(this.AuthortextBox);
            this.Controls.Add(this.YearOfBirth);
            this.Controls.Add(Gender);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAuthor";
            this.Text = "Създаване на автор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.TextBox YeartextBox;
        private System.Windows.Forms.TextBox GendertextBox;
        private System.Windows.Forms.TextBox AuthortextBox;
        private System.Windows.Forms.Label YearOfBirth;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Book;
    }
}