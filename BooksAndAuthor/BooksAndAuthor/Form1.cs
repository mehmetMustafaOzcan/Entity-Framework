using BLL;
using Models;
using System.Security.Authentication.ExtendedProtection;

namespace BooksAndAuthor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbAutorAdd.Items.AddRange(Bussiness.context.Autors.ToArray());
            cbAutorSearch.DataSource= Bussiness.context.Autors.ToList(); 
            cbAuthorBookAd.DataSource= Bussiness.context.Autors.ToList();
            cbAutorSearch.SelectedIndex = -1;
            cbAuthorBookAd.SelectedIndex = -1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new();
                book.Name = txtAd.Text;
                book.Autor = (Autor)cbAuthorBookAd.SelectedItem;
                book.Description = txtDesc.Text;
                book.AutorID = book.Autor.AutorID;
                Bussiness.BookAdd(book);
            }
            catch (Exception)
            {

                MessageBox.Show("Test");
            }
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Autor autor = new();
            autor.Name = txtYazarAd.Text;
            autor.Surname = txtSoyad.Text;
            Bussiness.AuthorAdd(autor);
            cbAuthorBookAd.DataSource = Bussiness.context.Autors.ToList();
        }

        private void btnYAzsil_Click(object sender, EventArgs e)
        {
            Bussiness.AutorRemove((Autor)cbAutorAdd.SelectedItem);
           
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (cbAutorSearch.SelectedIndex!=-1)
            {
                dataGridView1.DataSource = Bussiness.context.Books.Where(b => b.Autor == ((Autor)cbAutorSearch.SelectedItem)).ToList();
                cbAutorSearch.SelectedIndex = -1;
            }
            else 
            {
                dataGridView1.DataSource = Bussiness.context.Books.ToList();
            }
        } 

        private void btnyzGunc_Click(object sender, EventArgs e)
        {


            if (cbAutorAdd.SelectedItem!=null)
            {
                ((Autor)cbAutorAdd.SelectedItem).Name = txtYazarAd.Text;
                ((Autor)cbAutorAdd.SelectedItem).Surname = txtSoyad.Text;

                Bussiness.Update();

            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapýnýz");
            }
            
        }

        private void cbAutorAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtYazarAd.Text = ((Autor)cbAutorAdd.SelectedItem).Name;
            txtSoyad.Text = ((Autor)cbAutorAdd.SelectedItem).Surname;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var selectedbook = (Book)dataGridView1.CurrentRow.DataBoundItem;
            Bussiness.BookRemove(selectedbook);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bussiness.context.Books.Where(x=>x.Name.Contains(textBox1.Text)||x.Autor.Name.Contains(textBox1.Text)||x.Description.Contains(textBox1.Text)||x.Autor.Surname.Contains(textBox1.Text)).ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Book selectedbook = (Book)dataGridView1.CurrentRow.DataBoundItem;
            selectedbook.Autor = (Autor) cbAuthorBookAd.SelectedItem;
            Bussiness.context.SaveChanges();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Book selectedbook = (Book)dataGridView1.CurrentRow.DataBoundItem;
            cbAuthorBookAd.SelectedItem = selectedbook.Autor;
        }
    }
}