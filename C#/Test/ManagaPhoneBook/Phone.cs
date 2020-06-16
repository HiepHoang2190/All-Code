using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ManagaPhoneBook
{
    public abstract class Phone
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string _Phone
        {
            get => phone;
            set => phone= value;
        }
        public Phone(string name,string phone)
        {
           Name = name;
           _Phone = phone;
        }
        public abstract void insertPhone(string name,string phone);
        public abstract void removePhone(string name);
        public abstract void updatePhone(string name, string newphone);
        public abstract void searchPhone(string name);
        public abstract void sort();

        public override string ToString()
        {
            return $"Name:{Name}, Phone:{_Phone}";
        }
    }
}
