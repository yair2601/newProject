// File:    Worker.cs
// Author:  ranalm
// Created: יום שני 12 מאי 2014 21:00:31
// Purpose: Definition of Class Worker

using System;
using System.Data.SqlClient;

namespace Project
{
    public class Employee
    {
        private int EmployeeId;
        private string EmployeeName;
        private int Seniority;
        private int Salary;
        private EmployeesTypes Type;
        private EmployeesStatuses Status;
        private int CreatedBy;
        private Employee host;





        //private Title workerTitle;
        //public System.Collections.Generic.List<Order> orders;


        public Employee(int id, string name,int Seniority, int Salary, EmployeesTypes Type, EmployeesStatuses status , int CreatedBy, bool is_new)
        {
            this.EmployeeId = id;
            this.EmployeeName = name;
            this.Type = Type;
            this.Seniority = Seniority;
            this.Salary = Salary;
            this.Type = Type;
            this.Status = status;
            this.CreatedBy = CreatedBy;
            if (is_new)
            {
                this.create_Employee();
                Program.Employee.Add(this);

            }
        }

        public static Employee seekWorker(int id)
        {
            foreach (Employee w in Program.Employee)
            {
                if (w.GetEmployeeId() == id)
                    return w;
            }
            return null;
        }


        public int GetEmployeeId()
        {
            return this.EmployeeId;
        }

        public void SetEmployeeId(int employeeId)
        {
            this.EmployeeId = employeeId;
        }

        public string GetEmployeeName()
        {
            return this.EmployeeName;
        }

        public void SetEmployeeName(string employeeName)
        {
            this.EmployeeName = employeeName;
        }

        public int GetSeniority()
        {
            return this.Seniority;
        }

        public void SetSeniority(int seniority)
        {
            this.Seniority = seniority;
        }

        public int GetSalary()
        {
            return this.Salary;
        }

        public void SetSalary(int salary)
        {
            this.Salary = salary;
        }

        public EmployeesTypes GetType()
        {
            return this.Type;
        }

        public void SetType(EmployeesTypes type)
        {
            this.Type = type;
        }

        public EmployeesStatuses GetStatus()
        {
            return this.Status;
        }

        public void SetStatus(EmployeesStatuses status)
        {
            this.Status = status;
        }

        public Employee GetCreatedBy()
        {
            return this.host;
        }

        public void SetCreatedBy(int createdBy)
        {
            this.CreatedBy = createdBy;
        }
        public void create_Employee()
        {
            Console.WriteLine(this.Status);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.insertEmployee @ID , @Name, @Seniority , @Salary , @Type , @Status , @CreatedBy";
            c.Parameters.AddWithValue("@ID", this.EmployeeId);
            c.Parameters.AddWithValue("@Name", this.EmployeeName.ToString());
            c.Parameters.AddWithValue("@Seniority", this.Seniority);
            c.Parameters.AddWithValue("@Salary", this.Salary);
            c.Parameters.AddWithValue("@Type", this.Type.ToString());
            c.Parameters.AddWithValue("@Status", this.Status.ToString());
            c.Parameters.AddWithValue("@CreatedBy", this.CreatedBy);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_Employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.updateEmployee @ID , @Name , @Seniority , @Salary , @Type , @Status , @CreatedBy";
            c.Parameters.AddWithValue("@ID", this.EmployeeId);
            c.Parameters.AddWithValue("@Name", this.EmployeeName.ToString());
            c.Parameters.AddWithValue("@Seniority", this.Seniority);
            c.Parameters.AddWithValue("@Salary", this.Salary);
            c.Parameters.AddWithValue("@Type", this.Type.ToString());
            c.Parameters.AddWithValue("@Status", this.Status.ToString());
            c.Parameters.AddWithValue("@CreatedBy", this.CreatedBy.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }






    }
}