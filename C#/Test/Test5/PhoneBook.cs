using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test5
{
    class PhoneBook : Phone
    {
        ArrayList PhoneList = new ArrayList();
        public override void InsertPhone(string name, string phone)
        {
           if(check(name,out int index))
            {
                ((Contact)PhoneList[index]).PhoneNumber += $":{phone}";
            }
            else
            {
                PhoneList.Add(new Contact()
                {
                    Name=name,
                    PhoneNumber=phone
                });
            }
        }

        public override void RemovePhone(string name)
        {
            if (check(name, out int index))
            {
                PhoneList.Remove(PhoneList[index]);
                Console.WriteLine("Remove success");
            }
            else
            {
                Console.WriteLine($"{name}: Not Found");
            }
        }

        public override void SearchPhone(string name)
        {
            if (check(name, out int index))
            {
                Console.WriteLine(((Contact)PhoneList[index]).ToString());
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        public override void Sort()
        {
            PhoneList.Sort(new CustomSort());
        }

        public override void UpdatePhone(string name, string newphone)
        {
            if(check(name,out int index))
            {
                ((Contact)PhoneList[index]).PhoneNumber = newphone;
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
        public void Display()
        {
            foreach(Contact item in PhoneList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private bool check(string name,out int index)
        {
            index = -1;
            foreach(Contact item in PhoneList)
            {
                if (item.Name.Equals(name))
                {
                    index = PhoneList.IndexOf(item);
                    return true;
                }
            }
            return false;
        }
    }
}
