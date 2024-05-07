using Domain.Entitys.Home.BaseEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home
{
    public  class HomeRent : HomeBase
    {
        [Key]
        public int Id { get; set; }
        public bool HomeOwner { get; set; }           ///  With or without a landlord 
        public string DayMonth { get; set; }
        /// <summary>
        ///  Day or month type 
        /// </summary>
        public string UserType { get; set; }
        /// <summary>
        ///  user type  :   Male     
        ///  user type  :   Woman      
        ///  user type  :   Family       
        /// </summar
    }
}
