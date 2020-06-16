using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ManagaPhoneBook
{
    public class PhoneBook : Phone
    {
        ArrayList PhoneList = new ArrayList();

     
        public PhoneBook(string name, string phone)
        {
            Name = name;
            _Phone = phone;
        }

        public override void insertPhone(string Name, string _Phone)
        {
            PhoneList.Add(new PhoneBook($"{Name},{_Phone}"));
      
          
        }

        public override void removePhone(string Name)
        {
            if (PhoneList.Contains(Name))
            {
                PhoneList.Remove(Name);
            }
        }

        public override void searchPhone(string name)
        {
            if (PhoneList.Contains(Name))
            {
                Console.WriteLine($"Name: {Name}, Phone:{_Phone}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public override void sort()
        {
            throw new NotImplementedException();
        }

        public override void updatePhone(string name, string newphone)
        {
            if (PhoneList.Contains(Name))
            {
                PhoneList[]
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
