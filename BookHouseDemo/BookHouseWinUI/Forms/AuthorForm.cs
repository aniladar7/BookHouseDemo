using BookHouse.Business.Messages;
using BookHouse.Business.Repository.Abstract;
using BookHouse.Business.Repository.Concrete;
using BookHouse.DataAccess.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHouseWinUI.Forms
{
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
        }
        BaseRepository<Author> authorRepository = new BaseRepository<Author>();
        private void AuthorForm_Load(object sender, EventArgs e)
        {
            GetAuthors();
        }

        private void GetAuthors()
        {
            listView1.Items.Clear();
            foreach (Author author in authorRepository.GetList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = author.Id.ToString();
                lvi.SubItems.Add(author.FirstName);
                lvi.SubItems.Add(author.LastName);
                lvi.SubItems.Add(author.BirthDate.ToShortDateString());
                lvi.SubItems.Add(author.Biography);
                lvi.Tag = author;
                listView1.Items.Add(lvi);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.FirstName = txtFirstName.Text;
            author.LastName = txtLastName.Text;
            author.BirthDate = dtBirthday.Value;
            author.Biography = rtxBiography.Text;

            authorRepository.Add(author);
            MessageBox.Show(AuthorMessages.AddAuthorMessage());
            GetAuthors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedAuthor.FirstName = txtFirstName.Text;
            selectedAuthor.LastName = txtLastName.Text;
            selectedAuthor.BirthDate = dtBirthday.Value;
            selectedAuthor.Biography = rtxBiography.Text;

            authorRepository.Update(selectedAuthor);
            MessageBox.Show(AuthorMessages.UpdateAuthorMessage());

            GetAuthors();
        }
        Author selectedAuthor;
        private void listView1_Click(object sender, EventArgs e)
        {
            selectedAuthor = (Author)listView1.SelectedItems[0].Tag;

            txtFirstName.Text = selectedAuthor.FirstName;
            txtLastName.Text = selectedAuthor.LastName;
            dtBirthday.Value = selectedAuthor.BirthDate;
            rtxBiography.Text = selectedAuthor.Biography;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            authorRepository.Delete(selectedAuthor);
            MessageBox.Show(AuthorMessages.DeleteAuthorMessage());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var authorList = authorRepository.GetList().Where(a => a.FirstName.ToLower().StartsWith(txtSearch.Text.ToLower()));
            listView1.Items.Clear();
            foreach (Author  author in authorList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = author.Id.ToString();
                lvi.SubItems.Add(author.FirstName);
                lvi.SubItems.Add(author.LastName);
                lvi.SubItems.Add(author.BirthDate.ToShortDateString());
                lvi.SubItems.Add(author.Biography);
                lvi.Tag = author;
                listView1.Items.Add(lvi);
            }
        }
    }
}
