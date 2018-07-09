namespace Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BookPage = new System.Windows.Forms.TabPage();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.EditBook = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.dataBookView = new System.Windows.Forms.DataGridView();
            this.AuthorPage = new System.Windows.Forms.TabPage();
            this.dataAuthorView = new System.Windows.Forms.DataGridView();
            this.DeleteAuthor = new System.Windows.Forms.Button();
            this.EditAuthor = new System.Windows.Forms.Button();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.PersonPage = new System.Windows.Forms.TabPage();
            this.LoanBook = new System.Windows.Forms.Button();
            this.DeletePerson = new System.Windows.Forms.Button();
            this.EditPerson = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.dataPersonView = new System.Windows.Forms.DataGridView();
            this.UniqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealeseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentedFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.BookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBookView)).BeginInit();
            this.AuthorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAuthorView)).BeginInit();
            this.PersonPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BookPage);
            this.tabControl1.Controls.Add(this.AuthorPage);
            this.tabControl1.Controls.Add(this.PersonPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 25);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1242, 471);
            this.tabControl1.TabIndex = 5;
            // 
            // BookPage
            // 
            this.BookPage.Controls.Add(this.DeleteBook);
            this.BookPage.Controls.Add(this.EditBook);
            this.BookPage.Controls.Add(this.AddBook);
            this.BookPage.Controls.Add(this.dataBookView);
            this.BookPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookPage.Location = new System.Drawing.Point(4, 29);
            this.BookPage.Name = "BookPage";
            this.BookPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookPage.Size = new System.Drawing.Size(1234, 438);
            this.BookPage.TabIndex = 0;
            this.BookPage.Text = "Книги";
            this.BookPage.UseVisualStyleBackColor = true;
            // 
            // DeleteBook
            // 
            this.DeleteBook.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.DeleteBook.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.DeleteBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.DeleteBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.DeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBook.Location = new System.Drawing.Point(446, 398);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(183, 33);
            this.DeleteBook.TabIndex = 3;
            this.DeleteBook.Text = "Изтрии";
            this.DeleteBook.UseVisualStyleBackColor = true;
            this.DeleteBook.Click += new System.EventHandler(this.DeleteBook_Click);
            // 
            // EditBook
            // 
            this.EditBook.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.EditBook.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.EditBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.EditBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.EditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBook.Location = new System.Drawing.Point(226, 398);
            this.EditBook.Name = "EditBook";
            this.EditBook.Size = new System.Drawing.Size(197, 33);
            this.EditBook.TabIndex = 2;
            this.EditBook.Text = "Промени";
            this.EditBook.UseVisualStyleBackColor = true;
            this.EditBook.Click += new System.EventHandler(this.EditBook_Click);
            // 
            // AddBook
            // 
            this.AddBook.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.AddBook.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.AddBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.AddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBook.Location = new System.Drawing.Point(6, 398);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(198, 33);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "Добави";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // dataBookView
            // 
            this.dataBookView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataBookView.AllowUserToAddRows = false;
            this.dataBookView.AllowUserToDeleteRows = false;
            this.dataBookView.AllowUserToResizeColumns = false;
            this.dataBookView.AllowUserToResizeRows = false;
            this.dataBookView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataBookView.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBookView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataBookView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBookView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UniqueID,
            this.Book,
            this.Author,
            this.Pages,
            this.RealeseDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBookView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataBookView.Location = new System.Drawing.Point(-3, 0);
            this.dataBookView.MultiSelect = false;
            this.dataBookView.Name = "dataBookView";
            this.dataBookView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBookView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataBookView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataBookView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBookView.Size = new System.Drawing.Size(1234, 385);
            this.dataBookView.StandardTab = true;
            this.dataBookView.TabIndex = 0;
            // 
            // AuthorPage
            // 
            this.AuthorPage.Controls.Add(this.dataAuthorView);
            this.AuthorPage.Controls.Add(this.DeleteAuthor);
            this.AuthorPage.Controls.Add(this.EditAuthor);
            this.AuthorPage.Controls.Add(this.AddAuthor);
            this.AuthorPage.Location = new System.Drawing.Point(4, 29);
            this.AuthorPage.Name = "AuthorPage";
            this.AuthorPage.Padding = new System.Windows.Forms.Padding(3);
            this.AuthorPage.Size = new System.Drawing.Size(1234, 438);
            this.AuthorPage.TabIndex = 1;
            this.AuthorPage.Text = "Автори";
            this.AuthorPage.UseVisualStyleBackColor = true;
            this.AuthorPage.Click += new System.EventHandler(this.AuthorPage_Click);
            // 
            // dataAuthorView
            // 
            this.dataAuthorView.AllowUserToAddRows = false;
            this.dataAuthorView.AllowUserToDeleteRows = false;
            this.dataAuthorView.AllowUserToResizeColumns = false;
            this.dataAuthorView.AllowUserToResizeRows = false;
            this.dataAuthorView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataAuthorView.BackgroundColor = System.Drawing.Color.Linen;
            this.dataAuthorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAuthorView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.AuthorBook,
            this.Books,
            this.AuthorA,
            this.Gender,
            this.YearOfBirth});
            this.dataAuthorView.Location = new System.Drawing.Point(-4, 0);
            this.dataAuthorView.MultiSelect = false;
            this.dataAuthorView.Name = "dataAuthorView";
            this.dataAuthorView.ReadOnly = true;
            this.dataAuthorView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataAuthorView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAuthorView.Size = new System.Drawing.Size(1238, 384);
            this.dataAuthorView.TabIndex = 6;
            this.dataAuthorView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAuthorView_CellContentClick);
            // 
            // DeleteAuthor
            // 
            this.DeleteAuthor.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.DeleteAuthor.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.DeleteAuthor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.DeleteAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.DeleteAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAuthor.Location = new System.Drawing.Point(447, 397);
            this.DeleteAuthor.Name = "DeleteAuthor";
            this.DeleteAuthor.Size = new System.Drawing.Size(183, 33);
            this.DeleteAuthor.TabIndex = 5;
            this.DeleteAuthor.Text = "Изтрии";
            this.DeleteAuthor.UseVisualStyleBackColor = true;
            this.DeleteAuthor.Click += new System.EventHandler(this.DeleteAuthor_Click);
            // 
            // EditAuthor
            // 
            this.EditAuthor.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.EditAuthor.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.EditAuthor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.EditAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.EditAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditAuthor.Location = new System.Drawing.Point(227, 397);
            this.EditAuthor.Name = "EditAuthor";
            this.EditAuthor.Size = new System.Drawing.Size(197, 33);
            this.EditAuthor.TabIndex = 4;
            this.EditAuthor.Text = "Промени";
            this.EditAuthor.UseVisualStyleBackColor = true;
            this.EditAuthor.Click += new System.EventHandler(this.EditAuthor_Click);
            // 
            // AddAuthor
            // 
            this.AddAuthor.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.AddAuthor.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.AddAuthor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.AddAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.AddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAuthor.Location = new System.Drawing.Point(6, 397);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(198, 33);
            this.AddAuthor.TabIndex = 2;
            this.AddAuthor.Text = "Добави";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // PersonPage
            // 
            this.PersonPage.Controls.Add(this.LoanBook);
            this.PersonPage.Controls.Add(this.DeletePerson);
            this.PersonPage.Controls.Add(this.EditPerson);
            this.PersonPage.Controls.Add(this.AddPerson);
            this.PersonPage.Controls.Add(this.dataPersonView);
            this.PersonPage.Location = new System.Drawing.Point(4, 29);
            this.PersonPage.Name = "PersonPage";
            this.PersonPage.Padding = new System.Windows.Forms.Padding(3);
            this.PersonPage.Size = new System.Drawing.Size(1234, 438);
            this.PersonPage.TabIndex = 2;
            this.PersonPage.Text = "Наематели";
            this.PersonPage.UseVisualStyleBackColor = true;
            // 
            // LoanBook
            // 
            this.LoanBook.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.LoanBook.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.LoanBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.LoanBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.LoanBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LoanBook.Location = new System.Drawing.Point(620, 399);
            this.LoanBook.Name = "LoanBook";
            this.LoanBook.Size = new System.Drawing.Size(247, 32);
            this.LoanBook.TabIndex = 9;
            this.LoanBook.Text = "Наемане на книга ";
            this.LoanBook.UseVisualStyleBackColor = true;
            this.LoanBook.Click += new System.EventHandler(this.LoanBook_Click);
            // 
            // DeletePerson
            // 
            this.DeletePerson.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.DeletePerson.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.DeletePerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.DeletePerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.DeletePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePerson.Location = new System.Drawing.Point(431, 398);
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Size = new System.Drawing.Size(183, 33);
            this.DeletePerson.TabIndex = 8;
            this.DeletePerson.Text = "Изтрии";
            this.DeletePerson.UseVisualStyleBackColor = true;
            this.DeletePerson.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // EditPerson
            // 
            this.EditPerson.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.EditPerson.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.EditPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.EditPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.EditPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPerson.Location = new System.Drawing.Point(228, 398);
            this.EditPerson.Name = "EditPerson";
            this.EditPerson.Size = new System.Drawing.Size(197, 33);
            this.EditPerson.TabIndex = 7;
            this.EditPerson.Text = "Промени";
            this.EditPerson.UseVisualStyleBackColor = true;
            this.EditPerson.Click += new System.EventHandler(this.EditPerson_Click);
            // 
            // AddPerson
            // 
            this.AddPerson.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.AddPerson.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightYellow;
            this.AddPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.AddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPerson.Location = new System.Drawing.Point(7, 398);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(198, 33);
            this.AddPerson.TabIndex = 6;
            this.AddPerson.Text = "Добави";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // dataPersonView
            // 
            this.dataPersonView.AllowUserToAddRows = false;
            this.dataPersonView.AllowUserToDeleteRows = false;
            this.dataPersonView.AllowUserToResizeColumns = false;
            this.dataPersonView.AllowUserToResizeRows = false;
            this.dataPersonView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataPersonView.BackgroundColor = System.Drawing.Color.Linen;
            this.dataPersonView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.PersonBook,
            this.RentedFrom,
            this.RentedTo,
            this.PersonName,
            this.IDNumber,
            this.EGN,
            this.Adress,
            this.PersonGender,
            this.PhoneNumber,
            this.Email,
            this.BooksP});
            this.dataPersonView.Location = new System.Drawing.Point(-4, 0);
            this.dataPersonView.MultiSelect = false;
            this.dataPersonView.Name = "dataPersonView";
            this.dataPersonView.ReadOnly = true;
            this.dataPersonView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataPersonView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPersonView.Size = new System.Drawing.Size(1238, 385);
            this.dataPersonView.TabIndex = 0;
            this.dataPersonView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPersonView_CellContentClick);
            // 
            // UniqueID
            // 
            this.UniqueID.DataPropertyName = "UniqueID";
            this.UniqueID.HeaderText = "Индикация";
            this.UniqueID.Name = "UniqueID";
            this.UniqueID.ReadOnly = true;
            this.UniqueID.Visible = false;
            // 
            // Book
            // 
            this.Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Book.DataPropertyName = "Book";
            this.Book.HeaderText = "Книга";
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 81;
            // 
            // Pages
            // 
            this.Pages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pages.DataPropertyName = "Pages";
            this.Pages.HeaderText = "Страници";
            this.Pages.Name = "Pages";
            this.Pages.ReadOnly = true;
            this.Pages.Width = 108;
            // 
            // RealeseDate
            // 
            this.RealeseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RealeseDate.DataPropertyName = "RealeseDate";
            this.RealeseDate.HeaderText = "Издание";
            this.RealeseDate.Name = "RealeseDate";
            this.RealeseDate.ReadOnly = true;
            // 
            // PersonID
            // 
            this.PersonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonID.DataPropertyName = "id";
            this.PersonID.HeaderText = "Индикация";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Visible = false;
            // 
            // PersonBook
            // 
            this.PersonBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonBook.DataPropertyName = "BookName";
            this.PersonBook.HeaderText = "Книга";
            this.PersonBook.Name = "PersonBook";
            this.PersonBook.ReadOnly = true;
            // 
            // RentedFrom
            // 
            this.RentedFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RentedFrom.DataPropertyName = "RentedFrom";
            this.RentedFrom.HeaderText = "Наета от";
            this.RentedFrom.Name = "RentedFrom";
            this.RentedFrom.ReadOnly = true;
            // 
            // RentedTo
            // 
            this.RentedTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RentedTo.DataPropertyName = "RentedTo";
            this.RentedTo.HeaderText = "Наета до";
            this.RentedTo.Name = "RentedTo";
            this.RentedTo.ReadOnly = true;
            // 
            // PersonName
            // 
            this.PersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PersonName.DataPropertyName = "Name";
            this.PersonName.HeaderText = "Наемател";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 112;
            // 
            // IDNumber
            // 
            this.IDNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDNumber.DataPropertyName = "IDNumber";
            this.IDNumber.HeaderText = "Лична карта";
            this.IDNumber.Name = "IDNumber";
            this.IDNumber.ReadOnly = true;
            this.IDNumber.Width = 119;
            // 
            // EGN
            // 
            this.EGN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EGN.DataPropertyName = "EGN";
            this.EGN.HeaderText = "ЕГН";
            this.EGN.Name = "EGN";
            this.EGN.ReadOnly = true;
            this.EGN.Width = 66;
            // 
            // Adress
            // 
            this.Adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "Адрес";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 82;
            // 
            // PersonGender
            // 
            this.PersonGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PersonGender.DataPropertyName = "Gender";
            this.PersonGender.HeaderText = "Пол";
            this.PersonGender.Name = "PersonGender";
            this.PersonGender.ReadOnly = true;
            this.PersonGender.Width = 65;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhoneNumber.DataPropertyName = "Phone";
            this.PhoneNumber.HeaderText = "Телефон";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 104;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Емайл";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 84;
            // 
            // BooksP
            // 
            this.BooksP.DataPropertyName = "BookLibrary";
            this.BooksP.HeaderText = "Книги";
            this.BooksP.Name = "BooksP";
            this.BooksP.ReadOnly = true;
            this.BooksP.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Индикация";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 118;
            // 
            // AuthorBook
            // 
            this.AuthorBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AuthorBook.DataPropertyName = "BookName";
            this.AuthorBook.HeaderText = "Книга";
            this.AuthorBook.Name = "AuthorBook";
            this.AuthorBook.ReadOnly = true;
            // 
            // Books
            // 
            this.Books.DataPropertyName = "BookLibrary";
            this.Books.HeaderText = "Книги";
            this.Books.Name = "Books";
            this.Books.ReadOnly = true;
            this.Books.Visible = false;
            this.Books.Width = 78;
            // 
            // AuthorA
            // 
            this.AuthorA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AuthorA.DataPropertyName = "Name";
            this.AuthorA.HeaderText = "Автор";
            this.AuthorA.Name = "AuthorA";
            this.AuthorA.ReadOnly = true;
            this.AuthorA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.AuthorA.Width = 81;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Пол";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 65;
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.YearOfBirth.DataPropertyName = "YearOfBirth";
            this.YearOfBirth.HeaderText = "Година на раждане";
            this.YearOfBirth.Name = "YearOfBirth";
            this.YearOfBirth.ReadOnly = true;
            this.YearOfBirth.Width = 106;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 482);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.tabControl1.ResumeLayout(false);
            this.BookPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBookView)).EndInit();
            this.AuthorPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAuthorView)).EndInit();
            this.PersonPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BookPage;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.Button EditBook;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.DataGridView dataBookView;
        private System.Windows.Forms.TabPage AuthorPage;
        private System.Windows.Forms.DataGridView dataAuthorView;
        private System.Windows.Forms.Button DeleteAuthor;
        private System.Windows.Forms.Button EditAuthor;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.TabPage PersonPage;
        private System.Windows.Forms.Button LoanBook;
        private System.Windows.Forms.Button DeletePerson;
        private System.Windows.Forms.Button EditPerson;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.DataGridView dataPersonView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealeseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentedFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksP;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Books;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfBirth;
    }
}

