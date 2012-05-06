using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Massive.SQLite;

namespace RateCalculator.Models
{
    public class Person : DynamicModel
    {
        public Person()
            : base("RateCalculator")
        {
            TableName = "Person";
            PrimaryKeyField = "UID";
        }


        string FirstName { get; set; }
        string MiddleName { get; set; }
        string MiddleInitial
        {
            get
            {
                return MiddleName.Substring(1, 1);
            }
        }
        string LastName { get; set; }
        string FirstLastName
        {
            get
            {
                return FirstName.Trim() + " " + LastName.Trim();
            }
        }
        string LastFirstName
        {
            get
            {
                return LastName.Trim() + ", " + FirstName.Trim();
            }
        }
        DateTime BirthDate { get; set; }
        int Gender { get; set; }
    }
}
