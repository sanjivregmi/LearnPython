using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using neparica_hms_DLL.Hospital;

namespace neparica_hms_BLL.Hospital
{
    public class healthcertificate_bll
    {
        healthcertificate_dll healthcertificate_dll = new healthcertificate_dll();
        public void healthcertificate_insert(dbcontainer dc)
        {

            healthcertificate_dll.healthcertificate_insert(dc);
        }
        public void HealthCertificate_Update(dbcontainer dc)
        {
            healthcertificate_dll.HealthCertificate_update(dc);
        }
        public void HealthCertificate_Delete(dbcontainer dc)
        {
            healthcertificate_dll.HealthCertificate_Delete(dc);
        }
          
        public DataSet BindGrid()
        {
           return healthcertificate_dll.BindGrid();
        }
        public DataSet EditGrid(dbcontainer dc)
        {
             return healthcertificate_dll.EditGrid(dc);
        }
        public DataSet SearchByBoth(dbcontainer dc)
        {
            return healthcertificate_dll.SearchByBoth(dc);
        }
        public DataSet SearchByName(dbcontainer dc)
        {
            return healthcertificate_dll.SearchByName(dc);
        }
        public DataSet SearchByID(dbcontainer dc)
        {
            return healthcertificate_dll.SearchByID(dc);
        }
       




    }
}