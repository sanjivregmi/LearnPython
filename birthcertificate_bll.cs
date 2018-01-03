using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using neparica_hms_DLL.Public;
using neparica_hms_DLL.Hospital;
using System.Data;
using neparica_hms_DLL;

namespace neparica_hms_BLL.Hospital
{
    public class birthcertificate_bll
    {
        birhcertificate_dll birthcertificate_dll= new birhcertificate_dll();
        public void birthcertificate_insert(dbcontainer dc)
        {

            
            birthcertificate_dll.birthcertificate_insert(dc);
        }
        public void BirthCertificate_Update(dbcontainer dc)
        {
            birthcertificate_dll.BirthCertificate_Update(dc);
        }
        public void Delete_BirthCertificate(dbcontainer dc)
        {
            birthcertificate_dll.Delete_BirthCertificate(dc);
        }
        public DataSet Edit_BirthCertificate(dbcontainer dc)
        {
            return birthcertificate_dll.Edit_BirthCertificate(dc);
        }
        public DataSet SearchByBoth(dbcontainer dc)
        {
            return birthcertificate_dll.SearchByBoth(dc);

        }
        public DataSet SearchByName(dbcontainer dc)
        {
            return birthcertificate_dll.SearchByName(dc);
        }

        public DataSet SearchByID(dbcontainer dc)
        {
            return birthcertificate_dll.SearchByID(dc);
        }



        public DataSet BindGrid()
        {
            return birthcertificate_dll.BindGrid();
        }
        
        
    }
}