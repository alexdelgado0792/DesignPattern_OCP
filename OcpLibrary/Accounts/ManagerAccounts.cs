﻿using System;
using OcpLibrary.Interfaces;
using OcpLibrary.Models;

namespace OcpLibrary.Accounts
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{ person.LastName }@domain-corp.com";
            output.IsManager = true;

            return output;
        }
    }
}
