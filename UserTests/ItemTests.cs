using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskService.DAL;
using TaskService.Logic;
using TaskService.Models;
using TaskService.ViewModels;
using TestProject.MockContexts;

namespace ItemTests
{
    [TestClass]
    public class ItemTests
    {
        private readonly ItemLogic _logic;
        private readonly IMapper _mapper;

        public ItemTests()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Item, ItemViewModel>().ReverseMap();
            });

            _mapper = new Mapper(config);

            IItemRepo IItemRepo = new MockItemContext();
            _logic = new ItemLogic(IItemRepo, _mapper);
        }

        [TestMethod]
        public void GetAllItems_Valid()
        {
           ICollection<ItemViewModel> items = new List<ItemViewModel>();
           items = _logic.GetAllItems();

           Assert.AreEqual(items.Count, _logic.GetAllItems().Count);
        }

        [TestMethod]
        public void GetAllItems_Invalid()
        {
            ICollection<ItemViewModel> items = new List<ItemViewModel>();
            items = _logic.GetAllItems();
            ItemViewModel item = new ItemViewModel();
            item.Price = 60;
            items.Add(item);

            Assert.AreNotEqual(items.Count, _logic.GetAllItems().Count);
        }

        [TestMethod]
        public void NewItem_Valid()
        {
            ItemViewModel item = new ItemViewModel();
            item.Title = "TITLE";

            ItemViewModel Item = _logic.NewItem(item);

            Assert.AreEqual(Item.Title, item.Title);
        }

        [TestMethod]
        public void NewItem_Invalid()
        {
            ItemViewModel item = new ItemViewModel();
            ItemViewModel Item = _logic.NewItem(item);

            Assert.IsNull(Item.Title);
        }
    }
}
