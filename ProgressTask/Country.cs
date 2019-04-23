using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTask
{
    public class Country
    {
        private string countryName;
        private string capital;
        private string imagePath;

        public Country(string countryName, string capital, string imagePath)
        {
            this.countryName = countryName;
            this.capital = capital;
            this.imagePath = imagePath;
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                countryName = value;
            }
        }

        public string Capital
        {
            get
            {
                return capital;
            }
            set
            {
                capital = value;
            }

        }

        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                imagePath = value;
            }

        }
    
    }
}
