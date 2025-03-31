using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        List<Book> bookList = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "Novel", "1925");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "Novel", "1960");
            Book book3 = new Book("Moby Dick", "Herman Melville", "Adventure", "1851");

            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);

            BooksDataGridView.DataSource = bookList;
            BooksDataGridView.DefaultCellStyle.Font = new Font("", 14);
            //BooksDataGridView.RowTemplate.Height = 50;           
            BooksDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            BooksDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            BooksDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);

            BooksDataGridView.Columns["ID"].Width = 40;
            BooksDataGridView.Columns["Title"].Width = 170;
            BooksDataGridView.Columns["Author"].Width = 180;
            BooksDataGridView.Columns["Genre"].Width = 120;
            BooksDataGridView.Columns["Year"].Width = 80;
        }

        private void Add_Edit_btn_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            bool isFind = false;

            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].Title.ToLower() == title.ToLower())
                {
                    if (Add_Edit_btn.Text == "Edit")
                    {
                        try
                        {
                            bookList[i].Author = textBoxAuthor.Text;
                            bookList[i].Genre = textBoxGenre.Text;
                            bookList[i].Year = textBoxYear.Text;
                            MessageBox.Show("This book succesfully updated...");
                            textBoxTitle.Text = "";
                            textBoxAuthor.Text = "";
                            textBoxGenre.Text = "";
                            textBoxYear.Text = "";
                            BooksDataGridView.DataSource = null;
                            BooksDataGridView.DataSource = bookList;
                            Add_Edit_btn.Text = "Add";
                        }
                        catch (ArgumentException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("This book title already exist...");
                    }

                    isFind = true;
                    break;
                }
            }
            if (!isFind)
            {
                try
                {
                    Book book = new Book()
                    {
                        Title = title,
                        Author = textBoxAuthor.Text,
                        Genre = textBoxGenre.Text,
                        Year = textBoxYear.Text
                    };
                    bookList.Add(book);
                    MessageBox.Show("This book succesfully added...");
                    textBoxTitle.Text = "";
                    textBoxAuthor.Text = "";
                    textBoxGenre.Text = "";
                    textBoxYear.Text = "";
                    BooksDataGridView.DataSource = null;
                    BooksDataGridView.DataSource = bookList;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void BooksDataGridView_Click(object sender, EventArgs e)
        {
            if (BooksDataGridView.SelectedRows.Count > 0)
            {
                Book book = (Book)BooksDataGridView.SelectedRows[0].DataBoundItem;
                textBoxTitle.Text = book.Title;
                textBoxAuthor.Text = book.Author;
                textBoxGenre.Text = book.Genre;
                textBoxYear.Text = book.Year;
                Add_Edit_btn.Text = "Edit";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (BooksDataGridView.SelectedRows.Count > 0)
            {
                Book book = (Book)BooksDataGridView.SelectedRows[0].DataBoundItem;
                bool isFind = false;

                for (int i = 0; i < bookList.Count; i++)
                {
                    if (bookList[i].Title.ToLower() == book.Title.ToLower())
                    {
                        bookList.RemoveAt(i);
                        MessageBox.Show("Book Deleted...");
                
                        textBoxTitle.Text = "";
                        textBoxAuthor.Text = "";
                        textBoxGenre.Text = "";
                        textBoxYear.Text = "";
                        BooksDataGridView.DataSource = null;
                        BooksDataGridView.DataSource = bookList;
                        isFind = true; break;
                    }
                }
                if (!isFind)
                {
                    MessageBox.Show("This book not found...");
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();
            int length=searchText.Length;
            var searchResults = bookList.Where(book => book.Title.Length >= length &&
                                                   book.Title.Substring(0, length).ToLower() == searchText.ToLower())
                                   .ToList();

            if (searchResults.Count > 0)
            {
                BooksDataGridView.DataSource = null;
                BooksDataGridView.DataSource = searchResults;
            }
            else
            {
                MessageBox.Show("Book not found...");
            }
        }
    }
}
