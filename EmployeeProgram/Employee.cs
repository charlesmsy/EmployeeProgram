using System;
namespace EmployeeProgram
{
    public class Employee
    {
        private string name;
        private int idNumber;

        public Employee(string _name, int _idNumber)
        {
            setName(_name);
            setIdNumber(_idNumber);
        }

        public void setName(string _name)
        {
            name = _name;
        }

        public string getName()
        {
            return name;
        }

        public void setIdNumber(int _idnumber)
        {
            idNumber = _idnumber;
        }

        public double getIdNumber()
        {
            return idNumber;
        }
    }
}
