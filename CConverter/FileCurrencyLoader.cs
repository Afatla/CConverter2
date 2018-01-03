﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CConverter
{
    class FileCurrencyLoader:ICurrencyLoader
    {
        public string Filepath { get; set; }
        private string[] _data;
        private string p;
        public FileCurrencyLoader()
        {
            this._data = new string[3];
        }

        public FileCurrencyLoader(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        public double GetConverter()
        {
            return double.Parse(_data[2]);
        }
        public void LoadFromFile(string firstname, string secondname)
        {
            var source = File.ReadAllLines(this.Filepath);
            foreach (var line in source)
            {
                if (line.StartsWith(firstname + ";" + secondname))
                {
                    _data=line.Split(';');
                    
                }
            }
            
        }
    }
}
