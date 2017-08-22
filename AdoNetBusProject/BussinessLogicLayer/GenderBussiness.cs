using BusCompanyClassLibrary;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class GenderBussiness
    {
        Employee emp;
        GenderDataMapper genderData;
        int affectedRows = 0;

        public GenderBussiness()
        {
            genderData = new GenderDataMapper();
            //TODO:employee atanacak.
        }
        public List<Gender> GetAllBLL()
        {
            List<Gender> genderList = genderData.GetAll();
            return genderList;
        }

        public Gender GetBLL(int key)
        {
            Gender gender = genderData.Get(key);
            return gender;
        }

    }
}
