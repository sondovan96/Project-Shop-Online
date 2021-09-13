using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Enum
{
    public class ALL_ENUM
    {
        public enum Language
        {
            EN,
            VN
        }

        public enum ViewType
        {
            //menu for management & employee
            HOME,
            ORDER,
            PRODUCT,
            SUPPORT,
            CUSTOMER,

            //menu for management
            CATEGORY,
            PROMOTION,
            ACCOUNT,
            SETTING,
            STATISTIC,
            PARAMETER
            //menu for admin


            //UNIT,
            //SUPPLIER,
            //CATEGORY,
            //ACCOUNT,
            //STATISTICS,
            //SETTING
        }
    }
}
