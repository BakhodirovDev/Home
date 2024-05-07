using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home.Services
{
    public class HomeBuild  : ServiceBase

    {
        [Key]
        public int Id { get; set; }
 
        public string FormatType { get; set; }




    }
}
