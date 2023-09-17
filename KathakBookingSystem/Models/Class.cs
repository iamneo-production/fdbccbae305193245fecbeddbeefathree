using System;
using System.Collections.Generic;

namespace KathakBookingSystem.Models
{
    // Write your Class table class here...
    public class Class{
        public int ClassID {get;set;}
        public date StartTime{get;set;}
        public date EndTime{get;set;}
        public int Capacity{get;set;}
        public ICollection<Student> Student{get set;} 

    }
}