using WebAppDETAug2022MCV.Models;

namespace WebAppDETAug2022MCV.FriendServices
{
    public class FriendServices
    {
        static List<Friend> Friends { get; }
        static int nextId = 3;
        static FriendServices()
        {
            Friends = new List<Friend>
                {
                    new Friend { FriendID = 123, FName = "vinay ", FPlace = "  " },
                    new Friend { FriendID = 246, FName = " abhi" , FPlace = " "  }

                };
        }

        public static List<Friend> GetAll() => Friends;

        public static Friend? Get(int id) => Friends.FirstOrDefault(f => f.FriendID == id);

        public static void Add(Friend friends)
        {
            friends.FriendID = nextId++;
            Friends.Add(friends);
        }

        public static void Delete(int id)
        {
            var friends = Get(id);
            if (friends is null)
                return;

            Friends.Remove(friends);
        }

        public static void Edit(Friend friends)
        {
            var index = Friends.FindIndex(f => f.FriendID == friends.FriendID);
            if (index == -1)
                return;

            Friends[index] = friends;
        }

        internal static void update(Friend friends)
        {
            throw new NotImplementedException();
        }

        internal static void Update(Friend f)
        {
            throw new NotImplementedException();
        }

        //internal static void Update(Friend f)
        //{
        //    throw new NotImplementedException();
        //}

        //internal static void Update(Friend friends)
        //{
        //    throw new NotImplementedException();
        //}
    }
}


