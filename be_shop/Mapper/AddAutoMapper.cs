using AutoMapper;
using be_shop.Entites;
using be_shop.Models.User;

namespace be_shop.Mapper
{
    public class AddAutoMapper: Profile
    {
        public AddAutoMapper()
        {
            CreateMap<Admin_User, UserCreateModel>();
            CreateMap<UserCreateModel, Admin_User>();

            CreateMap<Admin_User, UserModifyModel>();
            CreateMap<UserModifyModel, Admin_User>();

            CreateMap<Admin_User,  UserModel>();
        }
    }
}
