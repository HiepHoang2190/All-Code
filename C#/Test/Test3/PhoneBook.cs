using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
   public class PhoneBook : Phone
    {
        ArrayList PhoneList = new ArrayList();
        //public PhoneBook()
        //{
        //    PhoneList.Add(new Contact()
        //    {
        //        Name = "Duc",
        //        PhoneNumber="1234"

        //    });
        //    PhoneList.Add(new Contact()
        //    {
        //        Name = "Duc",
        //        PhoneNumber = "567"

        //    });
        //    PhoneList.Add(new Contact()
        //    {
        //        Name = "An",
        //        PhoneNumber = "789"

        //    });
        //}
        public override void InsertPhone(string name, string phone)
        {
            if (Check(name, out var index))
            {
                ((Contact)PhoneList[index]).PhoneNumber += $": {phone}";
            }
            else
            {
                PhoneList.Add(new Contact()
                {
                    PhoneNumber = phone,
                    Name = name
                });
            }
        }

        public override void RemovePhone(string name)
        {   
           if(Check(name,out int index))
            {
                PhoneList.Remove(PhoneList[index]);
                Console.WriteLine("Remove success");
            }
            else
            {
                Console.WriteLine($"{name}: {Helper.NotFound}");
            }
        }

        public override void  SearchPhone(string name)
        {
          
            foreach (Contact item in PhoneList)
            {
                if (item.Name.Equals(Helper.FormatName(name)))
                {
                    
                    Console.WriteLine(item);
                }
               
            }


            
            
        }

        public override void Sort()
        {
            PhoneList.Sort(new CustomSort());
        }

        public override void UpdatePhone(string name, string newphone)
        {
            if (Check(name, out var index))
            {
                ((Contact)PhoneList[index]).PhoneNumber = $"{newphone}";
            }
        }
        public void Display()
        {
            foreach (Contact item in PhoneList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private bool Check(string name, out int index)
        {
            index = -1;
            foreach (Contact item in PhoneList)
            {
                if (item.Name.Equals(Helper.FormatName(name)))
                {
                    index = PhoneList.IndexOf(item);
                    return true;
                }
            }
            return false;
        }
    }
}
