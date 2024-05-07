using Domain.Entitys.Home.SpareParts.SparePartBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home.SpareParts
{
    public  class ConstructionMaterials : HomeSparePartBase
    {
        [Key] 
        public int Id { get; set; }
        public string  ProductType { get; set; }
        public string  MaterialType { get; set; }
        public string SizeType { get; set; }
        public string Thickness {  get; set; }
    }
}
