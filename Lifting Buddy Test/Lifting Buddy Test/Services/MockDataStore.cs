using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lifting_Buddy_Test.Models;

namespace Lifting_Buddy_Test.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Incline Dumbbell Curl", Description="Workout Type: Arm Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Standing Barbell Curl", Description="Workout Type: Arm Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Seated Concentration Curl", Description="Workout Type: Arm Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Skull Crushers", Description="Workout Type: Arm Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Hammer Curl", Description="Workout Type: Arm Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Lateral Raise", Description="Workout Type: Shoulder Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Front Raise", Description="Workout Type: Shoulder Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Shrug", Description="Workout Type: Shoulder Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Rear Delt Raise", Description="Workout Type: Shoulder Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Barbell Military Press", Description="Workout Type: Shoulder Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "back", Description="Workout Type: Back Exercise" }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}