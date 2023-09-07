namespace SimpaTravllingSocial.BL.Repo
{
    public class UserRep:IUserRepo
    {
        #region field
        private readonly ApplicationDbContext db;
        #endregion
        #region constractor
        public UserRep(ApplicationDbContext db)
        {
            this.db = db;
        }
        #endregion

        #region handel function
        public void CreateUser(User user)
        {
            try
            {
                db.users.Add(user);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void DeleteUser(int userId)
        {
            if (userId != null && userId != 0)
            {
                var user = db.users.Where(a => a.Id == userId).FirstOrDefault();
                if (user != null)
                {
                    user.IsDeleted = true;
                    db.SaveChanges();
                }
            }
        }

        public List<User> GetAllUser()
        {
            var users = db.users.Where(a => a.IsDeleted != true).ToList();
            return users;
        }

        public User GetUserId(int userId)
        {
            if (userId != null && userId != 0)
            {
                var user = db.users.Where(a => a.Id == userId).FirstOrDefault();
                return user;
            }
            return null;
        }

        public void UpdateUser(UserVM  user)
        {
            if (user.Id != null && user.Id != 0)
            {
                var Old = db.users.Where(a => a.Id == user.Id).FirstOrDefault();
                if (user != null)
                {
                    user.IsDeleted = true;
                    Old.FName = user.FName;
                    Old.LName = user.LName;
                    Old.UserName = user.UserName;
                    Old.Password = user.Password;
                    Old.Email = user.Email;

                    db.SaveChanges();
                }
            }
        }
        #endregion
    }
}
