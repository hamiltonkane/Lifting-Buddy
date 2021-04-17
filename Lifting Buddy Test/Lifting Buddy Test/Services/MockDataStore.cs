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
                    Description="There are a few important keys to doing the movement: Keep your upper arms perpendicular to the floor, not necessarily perpendicular to your body. This ensures you're working against gravity. Your arms should automatically be perpendicular to your body when you're on a flat bench, but won't necessarily be when you're doing the movement on an incline or decline bench. Only extend your elbows. Avoid allowing your upper arms to move back and forth from their position as you raise and lower the weight. If you move your arms, you put some of the load on your shoulders. Lower the weight under control, which means using a weight you can safely handle. Use a very deliberate rep speed on the negative. As you power the weight back up, stop just short of full extension so that you're unable to rest in the top position, which keeps tension on the muscle throughout the range of motion. Use a spotter when training to failure. A spotter can also assist you with a few additional forced reps, hand you the weight to begin, or grab the weight when you're done. Keep your elbows in tight as much as possible and avoid elbow flare to ensure the triceps do the bulk of the work. Allowing your elbows to flare out reduces the triceps' workload.",
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
                    Description="Stand with a dumbbell in each hand with arms by your sides, palms facing down and inward. Without bending your arms, raise them up and straight out to your sides until they're shoulder-level. Lower the dumbbells back to starting position. That's one rep. When you raise your arms, keep them at shoulder-level—and no higher. Do not lift them up to your ears. Make sure to keep your head above your tailbone, too, with no movement in your upper torso.",
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
                    Description="Hold a barbell with a palms facing down. Your feet should be shoulder-width apart. Bend your knees and bring your torso forward slightly. Your back should be straight and almost parallel to the floor. This is your starting position. Lift the barbell up towards your sternum, keeping your elbows tucked in and close to the body. Pause and hold at the top of the movement, squeezing your back muscles. Slowly lower the barbell back to the starting position. Repeat for the desired amount of reps. Pushing your hips back will help you to keep your back straight throughout the exercise pulling your elbows behind you, rather than pulling the bar up will help activate your lats and keep everything tight. Pausing at the top of the exercise and squeezing your shoulder blades together is a great way of building your back and developing posture.",
                    Pic = "BarbellBentOverRow.png" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dumbbell Pull-Over", 
                    Description="Workout Type: Back Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Lat Pull-Down", 
                    Description="Workout Type: Back Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Single-Arm Dumbbell Row", 
                    Description="Workout Type: Back Exercise" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Barbell Bench Press", 
                    Description="Lie flat on a bench and set your hands just outside of shoulder width. Set your shoulder blades by pinching them together and driving them into the bench. Take a deep breath and allow your spotter to help you with the lift off in order to maintain tightness through your upper back. Let the weight settle and ensure your upper back remains tight after lift off. Inhale and allow the bar to descend slowly by unlocking the elbows. Lower the bar in a straight line to the base of the sternum (breastbone) and touch the chest. Push the bar back up in a straight line by pressing yourself into the bench, driving your feet into the floor for leg drive, and extending the elbows. Repeat for the desired number of repetitions.",
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
                    Description="Your feet should be spaced hip-width apart with your grip just outside your legs. Use an overhand grip. Your back should be flat—neutral spine—from start to finish. Your shoulders should be back and down. The bar should remain in contact with your legs for the entire range of motion. Your hips and knees should move together to transfer the bar from the ground to an upper - thigh, locked position.",
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