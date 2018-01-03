using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using neparica_hms_DLL;
using neparica_hms_DLL.Hospital;
using System.Data;
using System.Data.SqlClient;

namespace neparica_hms_BLL.Hospital
{
    public class patient_registration_bll
    {
        patient_registration_dll patient_register_dll = new patient_registration_dll();
        public void insertdata(dbcontainer dc)
        {
           
            patient_register_dll.insertdatasp(dc);
        }
        public DataSet GetGridData()
        {
            return patient_register_dll.GetAllGridData();
        }
        public DataSet EditGrid(dbcontainer dc)
        {
            return patient_register_dll.EditGrid(dc);
        }
        public void updatedata(dbcontainer dc)
        {
            patient_register_dll.updatedate(dc);
        }
        public void deletedata(dbcontainer dc)
        {
            patient_register_dll.deletedata(dc);
        }
        public DataSet SearchGvById(dbcontainer dc)
        {
            return patient_register_dll.SearchGridById(dc);
        }
        public DataSet SearchGvByName(dbcontainer dc)
        {
            return patient_register_dll.SearchGridByName(dc);
        }
        public DataSet SearchGvByIdAndName(dbcontainer dc)
        {
            return patient_register_dll.SearchGridByByNameAndId(dc);
        }
        public void insertdisease(dbcontainer dc)
        {
             patient_register_dll.insertdisease(dc);
        }
        public DataSet BindDisease(dbcontainer dc)
        {
            return patient_register_dll.BindDisease(dc);
        }
        //public DataSet disease(dbcontainer dc)
        //{
        //   return patient_register_dll.adddisease(dc);
        //}
   
    
    
    
            
        }
    }
