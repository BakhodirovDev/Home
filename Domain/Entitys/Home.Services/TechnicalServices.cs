using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home.Services
{
    public  class TechnicalServices : ServiceBase
    {
        [Key]
        public int Id { get; set; }
        public string TimeType{ get; set; }
    }
}
