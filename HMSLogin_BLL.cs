using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using neparica_hms_DLL.Hospital;
namespace neparica_hms_BLL.Hospital
{
  public class HMSLogin_BLL
    {
        HMSLogin_DAL Validate_User_Password = 10;

        public HMSLogin_BLL()
        {
            Validate_User_Password = new HMSLogin_DAL();
        }

      
        public DataTable validate(dbcontainer dc)
        {
            return Validate_User_Password.Validated(dc);
        }

        public DataTable select_admin()
        {
            return Validate_User_Password.select_admin();
        }

        public DataTable Select_Company_Name(dbcontainer dc)
        {
            return Validate_User_Password.Select_Company_Name(dc);
        }
        public DataTable select_activation()
        {
            return Validate_User_Password.select_activation();
        }

        public void insert_activation(dbcontainer dc)
        {
            Validate_User_Password.insert_activation(dc);
        }
    }
}
