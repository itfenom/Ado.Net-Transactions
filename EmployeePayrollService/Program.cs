﻿using System;

namespace EmployeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service!");
            //Arrange
            Employee employee = new Employee();
            employee.employeeID = 7;
            employee.employeeName = "Kathy";
            employee.gender = "F";
            employee.address = "NYC";
            employee.startDate = Convert.ToDateTime("2018-10-21");
            employee.departmentID = 7;
            employee.departmentName = "Acting";
            employee.BasicPay = 55000;
            //Act
            DBOperations.AddEmployee(employee);
            double actual = DBOperations.GetSalary("Kathy");
            double expected = 55000;
        }
    }
}
