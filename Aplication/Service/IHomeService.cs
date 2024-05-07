using Domain.Entitys.Home;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Domain.Model;

namespace Aplication.Service
{
    public interface IHomeService
    {
        Task<Response<Home>> CreateHomeAynce(Home home);
        Task<Response<Home>> DeleteHomeAynce(int Id);
        Task<Response<Home>> UpdateHomeAynce(Home home);
        Task<Response<Home>> GetByIdHomeAynce(int Id);
        Task<Response<List<Home>>> GetAllHomeAynce();


        Task<Response<HomeRent>> CreateHomeRentAynce(HomeRent homeRent);
        Task<Response<HomeRent>> DeleteHomeRentAynce(int Id);
        Task<Response<HomeRent>> UpdateHomeRentAynce(HomeRent homeRent);
        Task<Response<HomeRent>> GetByIdHomeRentAynce(int Id);
        Task<Response<List<HomeRent>>> GetAllHomeRentAynce();


         Task<Response<Hotel>> CreateHotelAynce(Hotel hotel);
        Task<Response<Hotel>> DeleteHotelAynce(int Id);
        Task<Response<Hotel>> UpdateHotelAynce(Hotel hotel);
        Task<Response<Hotel>> GetByIdHotelAynce(int Id);
        Task<Response<List<Hotel>>> GetAllHotelAynce();
        
        
        
        
        Task<Response<HomeBuild>> CreateHomeBuildAynce(HomeBuild  homeBuild);
        Task<Response<bool>> DeleteHomeBuildAynce(int Id);
        Task<Response<HomeBuild>> UpdateHomeBuildAynce(HomeBuild  homeBuild);
        Task<Response<HomeBuild>> GetByIdHomeBuildAynce(int Id);
        Task<Response<List<HomeBuild>>> GetAllHomeBuildAynce();
               

        Task<Response<HomeRepair>> CreateHomeRepairAynce(HomeRepair homeRepair);
        Task<Response<HomeRepair>> DeleteHomeRepairAynce(int Id);
        Task<Response<HomeRepair>> UpdateHomeRepairAynce(HomeRepair homeRepair);
        Task<Response<HomeRepair>> GetByIdHomeRepairAynce(int Id);
        Task<Response<List<HomeRepair>>> GetAllHomeRepairAynce();
        

        Task<Response<TechnicalServices>> CreateTechnicalServicesAynce(TechnicalServices technicalServices);
        Task<Response<TechnicalServices>> DeleteTechnicalServicesAynce(int Id);
        Task<Response<TechnicalServices>> UpdateTechnicalServicesAynce(TechnicalServices technicalServices);
        Task<Response<TechnicalServices>> GetByIdTechnicalServicesAynce(int Id);
        Task<Response<List<TechnicalServices>>> GetAllTechnicalServicesAynce();

        
        Task<Response<ConstructionMaterials>> CreateConstructionMaterialsAynce(ConstructionMaterials  constructionMaterials);
        Task<Response<ConstructionMaterials>> DeleteConstructionMaterialsAynce(int Id);
        Task<Response<ConstructionMaterials>> UpdateConstructionMaterialsAynce(ConstructionMaterials  constructionMaterials);
        Task<Response<ConstructionMaterials>> GetByIdConstructionMaterialsAynce(int Id);
        Task<Response<List<ConstructionMaterials>>> GetAllConstructionMaterialsAynce();

            Task<Response<HomeAppliance>> CreateHomeApplianceAynce(HomeAppliance  homeAppliance);
        Task<Response<HomeAppliance>> DeleteHomeApplianceAynce(int Id);
        Task<Response<HomeAppliance>> UpdateHomeApplianceAynce(HomeAppliance homeAppliance);
        Task<Response<HomeAppliance>> GetByIdHomeApplianceAynce(int Id);
        Task<Response<List<HomeAppliance>>> GetAllHomeApplianceAynce();

        
        Task<Response<HomeEquipment>> CreateHomeEquipmentAynce(HomeEquipment homeEquipment);
        Task<Response<HomeEquipment>> DeleteHomeEquipmentAynce(int Id);
        Task<Response<HomeEquipment>> UpdateHomeEquipmentAynce(HomeEquipment  homeEquipment);
        Task<Response<HomeEquipment>> GetByIdHomeEquipmentAynce(int Id);
        Task<Response<List<HomeEquipment>>> GetAllHomeEquipmentAynce();




    }
}
