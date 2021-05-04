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
                new Item { Id = Guid.NewGuid().ToString(), Text = "Biceps ----- Incline Dumbbell Curl",  
                    Description="To do this exercise, you’ll need two items: a set of dumbbells and a workout bench. Choose a set of weights that’s challenging but doable for your fitness level. You can also go up or down in weight as needed. Before you get started, adjust the bench so that it’s at a 45 degree angle, or up to 60 degrees as needed. To do an incline dumbbell curl: Sit down against the workout bench, keeping your back straight and your abdominal muscles tight. Your weights should be at your sides to start, one in each hand. When you’ve gotten the starting position down, lift each dumbbell, palms up, toward your shoulders. It’s important to keep your upper arms tight so that you can isolate the biceps brachii muscle as you move your lower arms only. Slowly lower the dumbbells back down to your starting position. Don’t release the weights too fast or you could strain your muscles. This should be a controlled movement. Repeat the movement up to 15 times for 3 sets.", 
                    Pic="InclineDumbbellCurlGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Biceps ----- Standing Barbell Curl", 
                    Description="The standing barbell curl is the cornerstone of many bicep building routines. Grasp a barbell or Olympic bar at around shoulder width apart using an underhand grip (palms facing up). Stand straight up, feet together (you may be more comfortable putting one foot back for stability), back straight, and with your arms fully extended. The bar should not be touching your body. Keeping your eyes facing forwards, elbows tucked in at your sides, and your body completely still, slowly curl the bar up. Squeeze your biceps hard at the top of the movement, and then slowly lower it back to the starting position. Repeat for desired reps.", 
                    Pic="StandingBarbellCurlGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Biceps ----- Seated Concentration Curl", 
                    Description="Sit on a flat bench with your legs spread, knees bent and your feet flat on the floor with a dumbbell between your feet. Use either arm to pick the dumbbell up and hold it with an underhand grip. Place the back of that upper arm on the top of your inner thigh on the same side. Your palm should be facing away from your thigh. Keep your arm fully extended downwards without letting the dumbbell rest on the floor. This is the start position. Curl the dumbbell forward and up in a smooth arc, contracting your biceps and exhaling. Continue curling the dumbbell upward until your biceps are fully contracted and the dumbbell is at shoulder level. Hold for a count of one while squeezing your biceps. Return to the start position in a controlled, smooth arc inhaling as you do so. Do not swing the dumbbell down. Repeat for all the repetitions for that arm then switch and repeat the movement with your other arm.", 
                    Pic="SeatedConcentrationCurlGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Biceps ----- Hammer Curl", 
                    Description="To prepare for the exercise, stand with your shoulders relaxed and arms at your sides. Practice good posture by keeping the feet parallel with ankles and knees aligned under the hips. Your legs should be straight but not stiff or locked. Engage the abdominal muscles throughout the exercise to prevent movement through the lower back as you lift and lower your weights. Place one dumbbell in each hand. Rotate the hands so that the palms face the thighs. By doing so, you'll notice that the thumbs face forward. Keeping the elbows in a fixed position, bend at the elbow so the lower arms lift up and toward the shoulders. Keep the shoulders relaxed as you work. Keep your grip firms and wrists in line with the forearm. At the top of the movement, thumbs will be close to the shoulders, palms facing in toward the midline of the body. Lower the weights to the starting position.", 
                    Pic="HammerCurlGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Biceps ----- Dumbbell Preacher Curl", 
                    Description="Workout Type: Bicep Exercise -----", 
                    Pic="DumbbellPreacherCurlGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Triceps ----- Skull Crushers", 
                    Description="There are a few important keys to doing the movement: Keep your upper arms perpendicular to the floor, not necessarily perpendicular to your body. This ensures you're working against gravity. Your arms should automatically be perpendicular to your body when you're on a flat bench, but won't necessarily be when you're doing the movement on an incline or decline bench. Only extend your elbows. Avoid allowing your upper arms to move back and forth from their position as you raise and lower the weight. If you move your arms, you put some of the load on your shoulders. Lower the weight under control, which means using a weight you can safely handle. Use a very deliberate rep speed on the negative. As you power the weight back up, stop just short of full extension so that you're unable to rest in the top position, which keeps tension on the muscle throughout the range of motion. Use a spotter when training to failure. A spotter can also assist you with a few additional forced reps, hand you the weight to begin, or grab the weight when you're done. Keep your elbows in tight as much as possible and avoid elbow flare to ensure the triceps do the bulk of the work. Allowing your elbows to flare out reduces the triceps' workload.",
                    Pic = "SkullCrushersGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Triceps ----- Close-Grip Bench Press", 
                    Description="Workout Type: Tricep Exercise -----",
                    Pic="CloseGripBenchPressGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Triceps ----- Dumbbell Overhead Triceps Extension", 
                    Description="Workout Type: Tricep Exercise -----",
                    Pic="DumbbellOverheadTricepsExtensionGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Triceps ----- Cable Push-Down", 
                    Description="Workout Type: Tricep Exercise -----",
                    Pic="CablePushDownGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Triceps ----- Triceps Dip", 
                    Description="Workout Type: Tricep Exercise -----",
                    Pic="TricepsDipGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Shoulders ----- Dumbbell Lateral Raise", 
                    Description="Stand with a dumbbell in each hand with arms by your sides, palms facing down and inward. Without bending your arms, raise them up and straight out to your sides until they're shoulder-level. Lower the dumbbells back to starting position. That's one rep. When you raise your arms, keep them at shoulder-level—and no higher. Do not lift them up to your ears. Make sure to keep your head above your tailbone, too, with no movement in your upper torso.",
                    Pic = "DumbbellLateralRaiseGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Shoulders ----- Dumbbell Front Raise", 
                    Description="Workout Type: Shoulders Exercise -----",
                    Pic="DumbbellFrontRaiseGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Shoulders ----- Dumbbell Shrug", 
                    Description="Workout Type: Shoulders Exercise -----",
                    Pic="DumbbellShrugGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Shoulders ----- Dumbbell Rear Delt Raise", 
                    Description="Workout Type: Shoulders Exercise -----",
                    Pic="DumbbellRearDeltRaiseGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Shoulders ----- Barbell Military Press", 
                    Description="Workout Type: Shoulders Exercise -----",
                    Pic="BarbellMilitaryPressGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Back ----- Barbell Bent-Over Row", 
                    Description="Hold a barbell with a palms facing down. Your feet should be shoulder-width apart. Bend your knees and bring your torso forward slightly. Your back should be straight and almost parallel to the floor. This is your starting position. Lift the barbell up towards your sternum, keeping your elbows tucked in and close to the body. Pause and hold at the top of the movement, squeezing your back muscles. Slowly lower the barbell back to the starting position. Repeat for the desired amount of reps. Pushing your hips back will help you to keep your back straight throughout the exercise pulling your elbows behind you, rather than pulling the bar up will help activate your lats and keep everything tight. Pausing at the top of the exercise and squeezing your shoulder blades together is a great way of building your back and developing posture.",
                    Pic = "BarbellBentOverRowGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Back ----- Dumbbell Pull-Over", 
                    Description="Start the exercise by placing a dumbbell on a flat bench. Securing the dumbbell, lie on the bench with your torso across it so that only your shoulders make contact with the surface and your upper body forms a cross. Keep your head off the bench and hips below it, with the feet flat on the floor. Hold the dumbbell using both hands so that the palms are pressing against the underside of the dumbbell. Keeping the arms straight, bring the weight down behind your head until your chest muscles are stretched. Move the dumbbell back to the initial position and hold for a second before performing the reps.",
                    Pic="DumbbellPullOverGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Back ----- Lat Pull-Down", 
                    Description="Sit comfortably on the pulldown seat, feet flat on the floor. Check the height of the bar. You may need to adjust the bar height by shortening or lengthening the chain or cable that supports the bar, or your seat height. The bar should be at a height that your outstretched arms can comfortably grasp the bar without having to fully stand up, but you should also be able to still extend your arms to achieve full range of motion. Adjust the knee pad so that the upper thighs are tucked firmly under the pad. This will assist you when you apply effort to the bar. Grasp the bar with a wide grip with an overhand, knuckles up grip. Other positions and grips are possible but start with this standard position. Pull the bar down until it's approximately level with the chin. Exhale on down motion. While shifting just slightly backward is OK, aim to keep your upper torso stationary. Keep your feet flat on the floor and engage your abs as you pull. The bottom of the motion should be where your elbows can't move downward any more without moving backward. Be sure to stop at that point and do not go lower. Squeeze the shoulder blades together while maintaining square shoulders. From the bottom position with the bar close to your chin, slowly return the bar to the starting position while controlling its gradual ascent. Don't let it crash into the weight plates. Continue until you complete eight to 12 repetitions in a set. Rest, then continue to complete your program of sets.",
                    Pic="LatPullDownGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Back ----- Single-Arm Dumbbell Row", 
                    Description="Begin with feet hip-distance apart, holding the dumbbell in one hand. Take one step back into a lunge position. Keep a soft bend in your front leg with the knee in line with your ankle and back leg straight. Lean slightly forward, and rest your free hand on your front thigh. Tighten your core by squeezing your belly button in towards your spine. This will give you a good base of support. Lower the dumbbell toward the floor until you have a full extension at the elbow. Maintain proper posture through your shoulders, hips, and lower back. Avoid rounding or arching the lumbar spine. Begin the upward motion of the dumbbell by first sliding your shoulder blade toward your spine and then lifting the weight up toward your torso by driving your elbow to the ceiling. Keep your elbow close to your body as it passes the ribs. Squeeze your shoulder blade in toward the center of back. At the end of the movement, the dumbbell should be in line with your chest and your elbow should be pointing up toward the ceiling. Be sure to maintain good posture through your spine, shoulders, and hips. Repeat for the appropriate number of repetitions. Switch sides and repeat the same number of repetitions with the opposite arm.",
                    Pic="SingleArmDumbbellRowGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chest ----- Barbell Bench Press", 
                    Description="Lie flat on a bench and set your hands just outside of shoulder width. Set your shoulder blades by pinching them together and driving them into the bench. Take a deep breath and allow your spotter to help you with the lift off in order to maintain tightness through your upper back. Let the weight settle and ensure your upper back remains tight after lift off. Inhale and allow the bar to descend slowly by unlocking the elbows. Lower the bar in a straight line to the base of the breastbone and touch the chest. Push the bar back up in a straight line by pressing yourself into the bench, driving your feet into the floor for leg drive, and extending the elbows. Repeat for the desired number of repetitions.",
                    Pic="BarbellBenchPressGif2.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chest ----- Dumbbell Bench Press", 
                    Description="Sit on the end of an exercise bench with a dumbbell in each hand. Rest the weights on their ends on your thighs. Lie back and use your legs to help you lift the weights. Position yourself, so your back is flat on the bench, your arms are bent, and the dumbbells are in front of your shoulders. Your feet should be flat on the floor. Brace your abs and arch your lower back slightly. Think about lifting your chest up toward the ceiling. Press the weights up to arm’s length above your chest. The dumbbells should come together at the top of each rep. Straighten your arms, but don’t lock your elbows. Locking your arms means your joints are supporting the weight rather than your muscles. Bend your arms and lower the weights back down. Lower them as far as your flexibility allows. A good stretch at the bottom of each rep makes this exercise harder and more productive. However, do not bounce out of the bottom of each rep. That’s a recipe for injury. At the of your set, either lower the weights to the floor or, with your arms bent, just sit back up and return to your starting position. Alternatively, if you have spotters nearby, allow them to take the weights from you.",
                    Pic="DumbbellBenchPressGif2.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chest ----- Dumbbell Fly", 
                    Description="Workout Type: Chest Exercise -----",
                    Pic="DumbbellFlyGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Chest ----- Dumbbell Incline Bench Press", 
                    Description="Workout Type: Chest Exercise -----",
                    Pic="DumbbellInclineBenchPressGif3.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Legs ----- Squat", 
                    Description="Workout Type: Legs Exercise -----",
                    Pic="SquatGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Legs ----- Deadlift", 
                    Description="Your feet should be spaced hip-width apart with your grip just outside your legs. Use an overhand grip. Your back should be flat—neutral spine—from start to finish. Your shoulders should be back and down. The bar should remain in contact with your legs for the entire range of motion. Your hips and knees should move together to transfer the bar from the ground to an upper - thigh, locked position.",
                    Pic="DeadliftGif2.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Legs ----- Hack Squat", 
                    Description="Workout Type: Legs Exercise -----",
                    Pic="HackSquatGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Legs ----- Leg Press", 
                    Description="Workout Type: Legs Exercise -----",
                    Pic="LegPressGif.gif" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Legs ----- Dumbbell Lunge", 
                    Description="Workout Type: Legs Exercise -----",
                    Pic="DumbbellLungeGif2.gif" }
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