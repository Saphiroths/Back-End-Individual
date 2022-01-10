using System;
using System.Collections.Generic;
using System.Text;
using TaskService.Models;
using TaskService.DAL;

namespace TestProject.MockContexts
{
    class MockItemContext : IItemRepo
    {
        private ICollection<Item> items = new List<Item>();

        public MockItemContext()
        {
            PopulateItems();
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Item> GetAllItems()
        {
            return items;
        }

        public List<Item> getItemsByUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item NewItem(Item item)
        {
            return item;
        }

        public Item UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }

        private void PopulateItems()
        {
            for (int i = 0; i < 4; i++)
            {
                Item item = new Item();
                item.ID = i;
                item.Title = "Title" + i;
                item.UserID = new Guid();
                item.Price = 50 + i;
                item.Picture = "Picture" + i;
                items.Add(item);
            }
        }
    }
}
