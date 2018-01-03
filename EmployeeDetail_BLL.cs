using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using neparica_hms_DLL.Hospital;
namespace neparica_hms_BLL.Hospital
{
    public class EmployeeDetail_BLL
    {
        EmployeeDetail_DAL employeeDetail = new EmployeeDetail_DAL();
        DataTable dt = new DataTable();

        public void InsertEmployeeDetail(dbcontainer dc)
        {
            employeeDetail.InsertEmployeeDetail(dc);

        }

        public DataSet GridData()
        {
            return employeeDetail.GridData();

        }
        //to edit the edit menu in grid view
        public DataSet EditGrid(dbcontainer dc)
        {
            return employeeDetail.EditGrid(dc);
        }


        public DataTable SelectLastEmployeeId(dbcontainer dc)
        {
            dt = employeeDetail.SelectLastEmployeeId(dc);
            return dt;

        }

        public DataTable SelectEmployeeDetail(dbcontainer dc)
        {
            dt = employeeDetail.SelectEmployeeDetail(dc);
            return dt;
        }

        public void UpdateEmployeeDetails(dbcontainer dc)
        {
            employeeDetail.UpdateEmployeeDetails(dc);
        }
        public void DeleteEmployeeDetails(dbcontainer dc)
        {
            employeeDetail.DeleteEmployeeDetails(dc);

        }
      

        public DataSet SearchByID(dbcontainer dc)
        {

            return employeeDetail.SearchByID(dc);
        }
        public DataSet SearchByName(dbcontainer dc)
        {
            return employeeDetail.SearchByName(dc);
        }
        public DataSet SearchByIDName(dbcontainer dc)
        {
            return employeeDetail.SearchByIDName(dc);
                        
        }

        public DataSet Select_EmployeeLevel()
        {
            return employeeDetail.Select_EmployeeLevel();
        }
        public DataTable SelectSearchByCodeEmployeeDetail(dbcontainer dc)
        {
            dt = employeeDetail.SelectSearchByCodeEmployeeDetail(dc);
            return dt;
        }
        public DataSet select_Employee_Name(dbcontainer dc)
        {
            return employeeDetail.select_Employee_Name(dc);
        }
        public DataTable Select_EmployeeInformation(dbcontainer dc)
        {
            return employeeDetail.Select_EmployeeInformation(dc);
        }

        public DataTable Select_paymentPaidInformation(dbcontainer dc)
        {
            return employeeDetail.Select_paymentPaidInformation(dc);
        }
        public DataTable Select_paymentPaidInformationForDeposite(dbcontainer dc)
        {
            return employeeDetail.Select_paymentPaidInformationForDeposite(dc);
        }
        public void Insert_paymentPaidInfo(dbcontainer dc)
        {
            employeeDetail.Insert_paymentPaidInfo(dc);
        }
        public DataTable Select_ALLPaymentSalaryMonthlyInfo(dbcontainer dc)
        {
            return employeeDetail.Select_ALLPaymentSalaryMonthlyInfo(dc);
        }
        public void insert_PaymentSalaryMonthlyInfo(dbcontainer dc)
        {
            employeeDetail.insert_PaymentSalaryMonthlyInfo(dc);
        }
        public DataTable Select_ALLPaymentPaidInfo(dbcontainer dc)
        {
            return employeeDetail.Select_ALLPaymentPaidInfo(dc);
        }

        public DataTable Select_AllPaidInfo(dbcontainer dc)
        {
            return employeeDetail.Select_AllPaidInfo(dc);
        }
        public void updateEmployeeDetailAllowance(dbcontainer dc)
        {
            employeeDetail.updateEmployeeDetailAllowance(dc);
        }
    }
}
