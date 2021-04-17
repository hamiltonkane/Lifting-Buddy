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
                new Item { Id = Guid.NewGuid().ToString(), Text = "Incline Dumbbell Curl",  
                    Description="To do this exercise, you’ll need two items: a set of dumbbells and a workout bench. Choose a set of weights that’s challenging but doable for your fitness level. You can also go up or down in weight as needed. Before you get started, adjust the bench so that it’s at a 45 degree angle, or up to 60 degrees as needed. To do an incline dumbbell curl: Sit down against the workout bench, keeping your back straight and your abdominal muscles tight. Your weights should be at your sides to start, one in each hand. When you’ve gotten the starting position down, lift each dumbbell, palms up, toward your shoulders. It’s important to keep your upper arms tight so that you can isolate the biceps brachii muscle as you move your lower arms only. Slowly lower the dumbbells back down to your starting position. Don’t release the weights too fast or you could strain your muscles. This should be a controlled movement. Repeat the movement up to 15 times for 3 sets.", 
                    Pic="InclineDumbbellCurl.jpg" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Standing Barbell Curl", 
                    Description="The standing barbell curl is the cornerstone of many bicep building routines. Grasp a barbell or Olympic bar at around shoulder width apart using an underhand grip (palms facing up). Stand straight up, feet together (you may be more comfortable putting one foot back for stability), back straight, and with your arms fully extended. The bar should not be touching your body. Keeping your eyes facing forwards, elbows tucked in at your sides, and your body completely still, slowly curl the bar up. Squeeze your biceps hard at the top of the movement, and then slowly lower it back to the starting position. Repeat for desired reps.", 
                    Pic="StandingBarbellCurl.png" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Seated Concentration Curl", 
                    Description="Sit on a flat bench with your legs spread, knees bent and your feet flat on the floor with a dumbbell between your feet. Use either arm to pick the dumbbell up and hold it with an underhand grip. Place the back of that upper arm on the top of your inner thigh on the same side. Your palm should be facing away from your thigh. Keep your arm fully extended downwards without letting the dumbbell rest on the floor. This is the start position. Curl the dumbbell forward and up in a smooth arc, contracting your biceps and exhaling. Continue curling the dumbbell upward until your biceps are fully contracted and the dumbbell is at shoulder level. Hold for a count of one while squeezing your biceps. Return to the start position in a controlled, smooth arc inhaling as you do so. Do not swing the dumbbell down. Repeat for all the repetitions for that arm then switch and repeat the movement with your other arm.", 
                    Pic="SeatedConcentrationCurl.jfif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Hammer Curl", 
                    Description="Workout Type: Bicep Exercise", 
                    Pic="HammerCurl.jpg" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Preacher Curl", 
                    Description="Workout Type: Bicep Exercise", 
                    Pic="DumbbellPreacherCurl.png" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Skull Crushers", 
                    Description="Workout Type: Tricep Exercise",
                    Pic = "SkullCrushers.jpg" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Close-Grip Bench Press", 
                    Description="Workout Type: Tricep Exercise", },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Overhead Triceps Extension", 
                    Description="Workout Type: Tricep Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Cable Push-Down", 
                    Description="Workout Type: Tricep Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Triceps Dip", 
                    Description="Workout Type: Tricep Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Lateral Raise", 
                    Description="Workout Type: Shoulder Exercise",
                    Pic = "DumbbellLateralRaise.jpg" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Front Raise", 
                    Description="Workout Type: Shoulder Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Shrug", 
                    Description="Workout Type: Shoulder Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Rear Delt Raise", 
                    Description="Workout Type: Shoulder Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Barbell Military Press", 
                    Description="Workout Type: Shoulder Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Barbell Bent-Over Row", 
                    Description="Workout Type: Back Exercise",
                    Pic = "BarbellBentOverRow.png" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Pull-Over", 
                    Description="Workout Type: Back Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Lat Pull-Down", 
                    Description="Workout Type: Back Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Single-Arm Dumbbell Row", 
                    Description="Workout Type: Back Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Deadlift", 
                    Description="Workout Type: Back Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Barbell Bench Press", 
                    Description="Workout Type: Chest Exercise",
                    Pic = "BarbellBenchPress.jpeg" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Bench Press", 
                    Description="Workout Type: Chest Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Fly", 
                    Description="Workout Type: Chest Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Pull-Over", 
                    Description="Workout Type: Chest Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Incline Bench Press", 
                    Description="Workout Type: Chest Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Squat", 
                    Description="Workout Type: Leg Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Deadlift", 
                    Description="Workout Type: Leg Exercise",
                    Pic = "Deadlift.png" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Hack Squat", 
                    Description="Workout Type: Leg Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Leg Press", 
                    Description="Workout Type: Leg Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Lunge", 
                    Description="Workout Type: Leg Exercise" }
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