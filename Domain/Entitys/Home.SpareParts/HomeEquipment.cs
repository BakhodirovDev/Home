using Domain.Entitys.Home.SpareParts.SparePartBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home.SpareParts
{
    public  class HomeEquipment : HomeSparePartBase
    {
        [Key]
         public int Id { get; set; }
        public string Equipments { get; set; }
        public string EquipmentType { get; set; }
        public string NumberOfProduct { get; set; }
        public string RawMaterialType { get; set; }


    }
}
