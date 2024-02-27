

namespace practic
{
    internal class UserService
    {
        public User[] GetAll()
        {
            User user1 = new User()
            {
                id = 1,
                fullname = "Elmir Qafarzade",
                age = 21,
                email = "Qafarzade@gmail.com",
                password = "Elmir123"
            };


            User user2 = new User()
            {
                id = 2,
                fullname = "Nurlan Umudov",
                age = 22,
                email = "Umudov@gmail.com",
                password = "Nurlan123"
            };


            User user3 = new User()
            {
                id = 3,
                fullname = "Sirac Mamedov",
                age = 23,
                email = "Mamedov@gmail.com",
                password = "Sirac123"


            };


            User[] users = { user1, user2, user3 };
            return users;
        }
        public User GetById(User[] users, int id)
        {
            return users.FirstOrDefault(m => m.id == id);

        }

    }
   


    
        

    
}
