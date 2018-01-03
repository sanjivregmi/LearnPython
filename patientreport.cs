using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using neparica_hms_DLL;
using neparica_hms_DLL.Hospital;

namespace neparica_hms_BLL.Hospital
{
    public class patientreport
    {
        patient_bill_dll patient_bill_dll = new patient_bill_dll();
        public void Bill(dbcontainer dc)
        {
            patient_bill_dll.Bill(dc);
        }
        public DataSet BindGrid()
        {
           return  patient_bill_dll.BindGrid();
        }
        public DataSet EditBill(dbcontainer dc)
        {
            return patient_bill_dll.edit_bill(dc);
        }

    }
}