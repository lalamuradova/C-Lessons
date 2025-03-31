namespace LibraryApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_Edit_btn = new System.Windows.Forms.Button();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add_Edit_btn);
            this.groupBox1.Controls.Add(this.textBoxYear);
            this.groupBox1.Controls.Add(this.textBoxGenre);
            this.groupBox1.Controls.Add(this.textBoxAuthor);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 229);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Book";
            // 
            // Add_Edit_btn
            // 
            this.Add_Edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(161)))), ((int)(((byte)(58)))));
            this.Add_Edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Edit_btn.ForeColor = System.Drawing.Color.White;
            this.Add_Edit_btn.Location = new System.Drawing.Point(359, 165);
            this.Add_Edit_btn.Name = "Add_Edit_btn";
            this.Add_Edit_btn.Size = new System.Drawing.Size(159, 55);
            this.Add_Edit_btn.TabIndex = 9;
            this.Add_Edit_btn.Text = "Add";
            this.Add_Edit_btn.UseVisualStyleBackColor = false;
            this.Add_Edit_btn.Click += new System.EventHandler(this.Add_Edit_btn_Click);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(144, 165);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(115, 35);
            this.textBoxYear.TabIndex = 8;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenre.Location = new System.Drawing.Point(144, 124);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(311, 35);
            this.textBoxGenre.TabIndex = 7;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthor.Location = new System.Drawing.Point(144, 83);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(311, 35);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.Location = new System.Drawing.Point(144, 42);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(311, 35);
            this.textBoxTitle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label5.Location = new System.Drawing.Point(18, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label6.Location = new System.Drawing.Point(16, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label7.Location = new System.Drawing.Point(16, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label8.Location = new System.Drawing.Point(16, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Genre";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 261);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(309, 35);
            this.textBoxSearch.TabIndex = 11;
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGridView.Location = new System.Drawing.Point(12, 302);
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.Size = new System.Drawing.Size(614, 286);
            this.BooksDataGridView.TabIndex = 12;
            this.BooksDataGridView.Click += new System.EventHandler(this.BooksDataGridView_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(493, 594);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 55);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(362, 258);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(143, 41);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(638, 651);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.BooksDataGridView);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(119)))), ((int)(((byte)(97)))));
            this.Name = "Form1";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_Edit_btn;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView BooksDataGridView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
    }
}

