using AutoMapper;
using CF_Web_Api.Data;
using CF_Web_Api.Dto;

namespace CF_Web_Api.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Blocks, BlocksDto>();
            CreateMap<Campus, CampusDto>();
            CreateMap<Account, AccountDto>();
            CreateMap<Ca, CasDto>();
            CreateMap<Floors, FloorsDto>();
            CreateMap<Rooms, RoomsDto>();
            CreateMap<FormDanhGia, FormDanhGiasDto>();
            CreateMap<RoomsCategory, RoomsCategoryDto>();
            CreateMap<DanhGia, DanhGiaDto>();
            CreateMap<ReportDanhGia, ReportDanhGiaDto>();
            CreateMap<ReportAuthorize, ReportAuthorizesDto>();
        }
    }
}
