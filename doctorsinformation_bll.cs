using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using neparica_hms_DLL.Hospital;
using System.Data;

namespace neparica_hms_BLL.Hospital
{ 
    
    public class doctorsinformation_bll
    {
        doctorinformation doctordll = new doctorinformation();
        public void doctor_Information(dbcontainer dc)
        {
            doctordll.doctor_Information(dc);
        }
        public DataSet BindGrid()
        {
            return doctordll.BindGrid();
        }

    }
}