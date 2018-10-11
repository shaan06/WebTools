using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class MobileDetailsManager
    {
        readonly List<MobileDetails> mobileDetails = new List<MobileDetails>()
        {
            new MobileDetails {ID = 1, mobileName= "Apple" , Price= 200, color= "White", model="Iphone 7",SimType="GSM", Url= "https://drop.ndtv.com/TECH/product_database/images/982016124826AM_635_iphone_7.jpeg" },
            new MobileDetails {ID = 2, mobileName= "Apple" , Price= 400, color= "Black", model="Iphone 7s",SimType="GSM", Url= "https://drop.ndtv.com/TECH/product_database/images/982016124826AM_635_iphone_7.jpeg" },
            new MobileDetails {ID = 3, mobileName= "Samsung" , Price= 500, color= "Blue", model="Note 8",SimType="GSM", Url= "https://s7d2.scene7.com/is/image/SamsungUS/Major_Front_Pen_Orchidgray_RFP_RGB_20170820?$product-details-jpg$" },
            new MobileDetails {ID = 4, mobileName= "Samsung" , Price= 500, color= "Blue", model="Note 8",SimType="GSM", Url= "https://s7d2.scene7.com/is/image/SamsungUS/Major_Front_Pen_Orchidgray_RFP_RGB_20170820?$product-details-jpg$" },

        };
        public IEnumerable<MobileDetails> GetAll { get
            { return mobileDetails; } 
    }
    }
}
