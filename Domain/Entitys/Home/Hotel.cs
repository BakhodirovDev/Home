using Domain.Entitys.Home.BaseEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home
{
    public  class Hotel : HomeBase
    {
        [Key]
        public int Id { get; set; }
        public string DayMonth { get; set; }         /// Day or month time 
        public string RoomType { get; set; }
        /// <summary>       
        ///  Bissnes
        ///  Comfortable
        ///  Cheap
        /// </summary>
        public string UserType { get; set; }
        /// <summary>
        ///  user type  :   Male     
        ///  user type  :   Woman      
        ///  user type  :   Family       
        /// </summary>
    }
}
