using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;
using neparica_hms_DLL.Hospital;
namespace neparica_hms_BLL.Hospital
{
    public class BusinessCompany
    {
        DL_Connection dc = null;
        public BusinessCompany()
        {
            dc = new DL_Connection();
        }
        Company_DLL ap = new Company_DLL();
        public void insert(Hashtable ht)
        {
            ap.CompanyInsert(ht);
        }
        public DataTable getCompany()
        {
            DataTable dt = ap.all();
            return dt;

        }
        public void updatecompany(dbcontainer dc)
        {
            ap.update(dc);
        }
        public void deletecompany(dbcontainer dc)
        {
            ap.delete(dc);
        }




    }
}