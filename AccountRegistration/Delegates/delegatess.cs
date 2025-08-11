using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccountRegistration.Delegates
{

    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);

    internal class delegatess
    {
        public class StudentInfoClass
        {
            public static string FirstName = " ";
            public static string LastName = " ";
            public static string MiddleName = " ";
            public static string Address = " ";
            public static string Program = " ";
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;


            public static string GetFirstName(string FirstName)
            {
                return  FirstName;
            }

            public static string GetLastName(string GetLastName)
            {
                return GetLastName;
            }

            public static string GetMiddleName(string GetMiddleName)
            {
                return GetMiddleName;
            }

            public static string GetAddress(string Address)
            {
                return Address;
            }
            
            public static string GetProgram(string Program)
            {
                return Program;
            }

            public static long GetAge(long Age)
            {
                return Age;
            }

            public static long GetContactNo(long GetContactNo)
            {
                return GetContactNo;
            }

            public static long GetStudentNo(long GetStudentNo)
            {
                return GetStudentNo;
            }
        }

    }
}
