using Domain.Entitys.Regions.District;
using Domain.Entitys.Regions.Province;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home.Services
{
    public  class ServiceBase
    {
        public decimal Price { get; set; }
        public string MoneyType { get; set; }

        public string PhotoPath { get; set; }
        public string TheEmployerAndEmployee { get; set; }
        public string ServiceType { get; set; }
        public ToshkentEnum AddressDistrict { get; set; }
        public ProvinceEnum AddressProvince { get; set; }
        public string InformationUniversal { get; set; }
        public string PhoneNumbers { get; set; }   /// 998900220407   
    }
}
