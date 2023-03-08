using AutoMapper;
using Restaurant.API.DTOs;
using Restaurant.Entity;

namespace Restaurant.API.Utils.Automapper
{
    public class AutomapperProfile: Profile
    {
       public AutomapperProfile() 
       {
            #region User
            CreateMap<UserRegisterDTO, User>().
            ForMember(
                dest => dest.IdcountryNavigation,
                opt => opt.Ignore()
            ).
            ForMember(
                dest => dest.IdrolNavigation,
                opt => opt.Ignore()
            ).
            ForMember(
                dest => dest.IdstateNavigation,
                opt => opt.Ignore()
            );
            #endregion
        }
    }
}
