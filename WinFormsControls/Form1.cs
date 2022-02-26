using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<Person> allPeople = SeedPeople.People;

            foreach (var item in allPeople)
            {
                lstAllPeople.Items.Add(item);
            };

            IEnumerable<Country> allCountries = SeedCountry.GetCountries();
            foreach (var item in allCountries)
            {
                LstAllCountries.Items.Add(item);
            };

            IEnumerable<Country> allCountriesForComboBox = SeedCountry.Countries;
            foreach (var item in allCountriesForComboBox)
            {
                cmbCountry.Items.Add(item);
            };


        }

        private void btnFilterByAge_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Person> listPerAge = SeedPeople.People.Where(x => x.Age == Convert.ToInt32(txtFilter.Text)).ToList();
                lstDemo.DataSource = listPerAge;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilterByCountry_Click(object sender, EventArgs e)
        {
            //lstDemo.Items.Clear();


            // traditional way
            //IEnumerable<Person> allPeople = SeedPeople.People;
            //foreach (var item in allPeople)
            //{
            //    if (item.Country == Convert.ToInt32(txtFilter.Text)) 
            //    {
            //        lstDemo.Items.Add(item);
            //    }
            //}

            //Lamda

            try
            {
                IEnumerable<Person> list = SeedPeople.People.Where(x => x.Country == Convert.ToInt32(txtFilter.Text)).ToList();
                lstDemo.DataSource = list;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            txtFilter.Text = string.Empty;
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            lstDemo.Items.Clear();
            int selected = cmbCountry.SelectedIndex + 1;
            //IEnumerable<Person> people = SeedPeople.People;
            IEnumerable<Person> people = SeedPeople.People;
            foreach (var person in people)
            {
                if (person.Country == selected)
                {
                    lstDemo.Items.Add(person);
                }

            }


            //with lambda
            //int selected = cmbCountry.SelectedIndex + 1;
            //IEnumerable<Person> list = SeedPeople.People.Where(x => x.Country == selected).ToList();
            //lstDemo.DataSource = list;
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            lstDemo.Items.Clear();
            var person = SeedPeople.People.Find(x => x.Id == (Convert.ToInt32(txtFilter.Text)));
            lstDemo.Items.Add(person);
        }

        private void AddNewRecord_Click(object sender, EventArgs e)
        {

            IEnumerable<Person> allPeople = SeedPeople.People;
            Person p = new Person()
            {
                Id = 6,
                FirstName = "Kenan",
                LastName = "Kurda",
                Age = 27,
                IsVIP = false,
                Country = 3
            };

            SeedPeople.AddPerson(p);

            lstAllPeople.Items.Clear();
            foreach (var item in allPeople)
            {
                lstAllPeople.Items.Add(item);
            };

        }
    }
}
