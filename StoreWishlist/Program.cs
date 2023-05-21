using System;

namespace StoreWishlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Store.Store_proxy _storeProxy = new Store.Store_proxy();
            User.User user1 = new User.User("TestUser1");
            User.User user2 = new User.User("FaultyTestUser1");
            User.User user3 = new User.User("TestUser2");

            _storeProxy.GetInstance();

            _storeProxy.WishlistItem(user1, "CS:GO");
            _storeProxy.WishlistItem(user3, "CS:GO");

            _storeProxy.WishlistItem(user2, "CS:GO");

            _storeProxy.ModifyPrice("CS:GO", 19);
        }
    }
}
