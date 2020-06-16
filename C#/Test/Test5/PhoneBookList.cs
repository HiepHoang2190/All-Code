using System;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
   public class PhoneBookList : Phone
    {
       public List<Contact> contacts = new List<Contact>();

        public override void InsertPhone(string name, string phone)
        {
            var result = Check(name,out int index);
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
                contacts[index].PhoneNumber += $":{phone}";
            }

        }

        public override void RemovePhone(string name)
        {
            var result = Check(name, out int index);
            if (result != null)
            {
                contacts.Remove(result);
            }
        }

        public override void SearchPhone(string name)
        {
            var result = Check(name, out int index);
            if (result != null)
            {
                Console.WriteLine(result.ToString());
            }
        }
        
        public override void Sort()
        {
            contacts.Sort(new ListSort());
        }

        public override void UpdatePhone(string name, string newphone)
        {
            var result = Check(name, out int index);
            if (result != null)
            {
                //contacts[index].PhoneNumber = newphone;
                result.PhoneNumber = newphone;
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        public void Display()
        {
            foreach (Contact item in contacts)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public Contact Check(string name,out int index)
        {
            index = -1;
            foreach(var item in contacts)
            {
                if (item.Name.Equals(name))
                {
                    index = contacts.IndexOf(item);
                    return item;
                }
            }
            return null;
        }
    }
}
