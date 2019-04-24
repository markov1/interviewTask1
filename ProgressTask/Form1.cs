<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressTask
{
    public partial class Form1 : Form
    {
        private List<Country> countries;
        private List<UndoItem> undoList;
        private int currentCountryIndex = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.countries = this.GenerateCountries();
            this.undoList = new List<UndoItem>();
            this.ChangeCountryInfo(this.currentCountryIndex);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.currentCountryIndex++;
            if (this.currentCountryIndex == this.countries.Count)
            {
                this.currentCountryIndex = 0;
            }
            this.ChangeCountryInfo(this.currentCountryIndex);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.currentCountryIndex--;
            if (this.currentCountryIndex < 0)
            {
                this.currentCountryIndex = this.countries.Count - 1;
            }
            this.ChangeCountryInfo(this.currentCountryIndex);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(this.countries.Count == 1)
            {
                MessageBox.Show("There is only one country left. Delete is disabled.");
            }
            else
            {
                DialogResult question = MessageBox.Show("Are you sure you want to delete this country?", 
                    "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (question == DialogResult.Yes)
                {
                    var countryToRemove = this.countries[this.currentCountryIndex];
                    this.countries.Remove(countryToRemove);
                    this.undoList.Add(new UndoItem() { Country = countryToRemove, Index = this.currentCountryIndex });

                    if (this.currentCountryIndex == countries.Count)
                    {
                        currentCountryIndex--;
                    }
                    this.ChangeCountryInfo(currentCountryIndex);
                }
             
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(this.undoList.Count == 0)
            {
                MessageBox.Show("No deleted items to undo!");
            }
            else
            {
                var undoItem = this.undoList.Last();
                this.undoList.Remove(undoItem);
                this.countries.Insert(undoItem.Index, undoItem.Country);
                this.currentCountryIndex = undoItem.Index;
                this.ChangeCountryInfo(currentCountryIndex);
            }
        }

        private void ChangeCountryInfo(int newCountryIndex)
        {
            var newCountry = this.countries[newCountryIndex];
            this.label3.Text = newCountry.CountryName;
            this.label4.Text = newCountry.Capital;
            this.pictureBox1.Image = Image.FromFile(@"../../Resources/" + newCountry.ImagePath);
        }

        private List<Country> GenerateCountries()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country("Australia", "Canberra", "Australia.png"));
            countries.Add(new Country("Brazil", "Brazil", "Brazil.png"));
            countries.Add(new Country("Bulgaria", "Sofia", "Bulgaria.png"));
            countries.Add(new Country("Canada", "Ottawa", "Canada.jpg"));
            countries.Add(new Country("Germany", "Berlin", "german.jpg"));
            countries.Add(new Country("Italy", "Rome", "Italy.png"));
            countries.Add(new Country("Japan", "Tokyo", "Japan.png"));
            countries.Add(new Country("Spain", "Madrid", "Spain.png"));
            return countries;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressTask
{
    public partial class Form1 : Form
    {
        private List<Country> countries;
        private List<UndoItem> undoList;
        private int currentCountryIndex = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.countries = this.GenerateCountries();
            this.undoList = new List<UndoItem>();
            this.ChangeCountryInfo(this.currentCountryIndex);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.currentCountryIndex++;
            if (this.currentCountryIndex == this.countries.Count)
            {
                this.currentCountryIndex = 0;
            }
            this.ChangeCountryInfo(this.currentCountryIndex);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.currentCountryIndex--;
            if (this.currentCountryIndex < 0)
            {
                this.currentCountryIndex = this.countries.Count - 1;
            }
            this.ChangeCountryInfo(this.currentCountryIndex);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(this.countries.Count == 1)
            {
                MessageBox.Show("There is only one country left. Delete is disabled.");
            }
            else
            {
                DialogResult question = MessageBox.Show("Are you sure you want to delete this country?", 
                    "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (question == DialogResult.Yes)
                {
                    var countryToRemove = this.countries[this.currentCountryIndex];
                    this.countries.Remove(countryToRemove);
                    this.undoList.Add(new UndoItem() { Country = countryToRemove, Index = this.currentCountryIndex });

                    if (this.currentCountryIndex == countries.Count)
                    {
                        currentCountryIndex--;
                    }
                    this.ChangeCountryInfo(currentCountryIndex);
                }
             
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(this.undoList.Count == 0)
            {
                MessageBox.Show("No deleted items to undo!");
            }
            else
            {
                var undoItem = this.undoList.Last();
                this.undoList.Remove(undoItem);
                this.countries.Insert(undoItem.Index, undoItem.Country);
                this.currentCountryIndex = undoItem.Index;
                this.ChangeCountryInfo(currentCountryIndex);
            }
        }

        private void ChangeCountryInfo(int newCountryIndex)
        {
            var newCountry = this.countries[newCountryIndex];
            this.label3.Text = newCountry.CountryName;
            this.label4.Text = newCountry.Capital;
            this.pictureBox1.Image = Image.FromFile(@"../../Resources/" + newCountry.ImagePath);
        }

        private List<Country> GenerateCountries()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country("Australia", "Canberra", "Australia.png"));
            countries.Add(new Country("Brazil", "Brazil", "Brazil.png"));
            countries.Add(new Country("Bulgaria", "Sofia", "Bulgaria.png"));
            countries.Add(new Country("Canada", "Ottawa", "Canada.jpg"));
            countries.Add(new Country("Germany", "Berlin", "german.jpg"));
            countries.Add(new Country("Italy", "Rome", "Italy.png"));
            countries.Add(new Country("Japan", "Tokyo", "Japan.png"));
            countries.Add(new Country("Spain", "Madrid", "Spain.png"));
            return countries;
        }
    }
}
>>>>>>> 27f170e43584041498d307102645c12c6ffe9d35
