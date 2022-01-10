using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Back_End.DAL;
using User_Back_End.Logic;
using User_Back_End.Models;
using User_Back_End.ViewModels;
using User_Back_End.Profiles;
using TestProject.MockContexts;

namespace UserTests
{
    [TestClass]
    public class UserTests
    {
        private readonly UserLogic _logic;
        private readonly IMapper _mapper;

        public UserTests()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserViewModel>().ReverseMap();
            });

            _mapper = new Mapper(config);

            IUserRepository IUserRepo = new MockUserContext();
            _logic = new UserLogic(IUserRepo, _mapper);
        }


        [TestMethod]
        public void GetUser_Valid()
        {
            UserViewModel user = new UserViewModel();
            user.Email = "Email1";

            UserViewModel User = _logic.GetUser(user);

            Assert.AreEqual(User.Email, user.Email);
        }

        [TestMethod]
        public void GetUser_Invalid()
        {
            UserViewModel user = new UserViewModel();
            user.Email = "Email22";

            UserViewModel User = _logic.GetUser(user);

            Assert.IsNull(User);
        }




        [TestMethod]
        public void NewUser_Valid()
        {
            UserViewModel user = new UserViewModel();
            user.Username = "Username";

            UserViewModel User = _logic.NewUser(user);

            Assert.AreEqual(User.Username, user.Username);
        }

        [TestMethod]
        public void NewUser_Invalid()
        {
            UserViewModel user = new UserViewModel();
            UserViewModel User = _logic.NewUser(user);

            Assert.IsNull(User.Username);
        }
    }
}
