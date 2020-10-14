using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }



        public Student()
        {
            FirstName = "";
            LastName = "";
            Major = "";
            GPA = 0;
            Address = new Address();
        }


        public Student(string firstname, string lastname, string major, double gpa )
        {
            Address = new Address();
            FirstName = firstname;
            LastName = lastname;
            Major = major;
            GPA = gpa;
        }

        public string CalculateDistinction()
        {
            string specialdistinction = "";

            if (3.40 > GPA && GPA < 3.59)
            {
                specialdistinction = "cum laude";
            }
            else if (3.60 > GPA && GPA < 3.79)
            {
                specialdistinction = "magna cum laude";
            }
            else if (4.0 > GPA && GPA <= 3.80)
            {
                specialdistinction = "summa cum laude";
            }
          

            return specialdistinction;
        }


        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            
            Address.State = state;
            Address.City = city;
            Address.StreetName = streetName;
            Address.ZipCode = zipcode;
            Address.StreetNumber = streetNumber;
        }

        public override string ToString()
        {
            string showinlistbox = ($"{FirstName} {LastName}, {Major} {CalculateDistinction()}");
            return showinlistbox;
        }




    }





}
