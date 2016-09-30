using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project9_28.Models
{
    public class Course
    {
        public string coursename;
        public string course_number;
        public string student_access_id;
    }
    public class Question
    {
        public string question_statement;
     //   List<TestCase> testcases = new List<TestCase>();
    }
    public class TestCase
    {
        public string input;
        public string output;
        public string description;
    }
    public class Professor
    {
        public string name;
        public string email;
        public string password;
    }
}