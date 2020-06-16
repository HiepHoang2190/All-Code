using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
  public  class PhoneBookList : Phone
    {
        public List<Contact> contacts = new List<Contact>();
        public override void InsertPhone(string name, string phone)
        {
            var result = Check(name);
            if (result == null)
            {
                contacts.Add(new Contact()
                {
                    PhoneNumber = phone,
                    Name = name
                });
            }
            else
            {
                new Contact();
            }
        }

        public override void RemovePhone(string name)
        {
            var result = Check(name);
            if(result!= null)
            {
                contacts.Remove(result);
            }
        }

        public override void SearchPhone(string name)
        {
            var result = Check(name);
            if (result != null)
            {
                Console.WriteLine(result.ToString());
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public override void Sort()
        {
            contacts.Sort(new ListSort());
        }

        public override void UpdatePhone(string name, string newphone)
        {
            var result = Check(name);
            if (result != null)
            {
                result.PhoneNumber = newphone;
            }
            else
            {
                Console.WriteLine("Not found");
            }


        }


        public Contact Check(string name)
        {
           
            foreach (var item in contacts)
            {
                if (item.Name.Equals((name)))
                {
                 
                    return item;
                };
            }
            return null;
        }
       
    }
}
