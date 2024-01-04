namespace Meeting.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() {Id=1, Name = "Eda", EMail = "Omercan@gmail.com", Phone = "5522254134", WillAttend = true });
            _users.Add(new UserInfo() {Id=2, Name = "Seda", EMail = "Omercan@gmail.com", Phone = "5522254134", WillAttend = true });
            _users.Add(new UserInfo() {Id=3, Name = "Ceyda", EMail = "Omercan@gmail.com", Phone = "5522254134", WillAttend = false });
            _users.Add(new UserInfo() {Id=4, Name = "Buse", EMail = "Omercan@gmail.com", Phone = "5522254134", WillAttend = true });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int Id)
        {
            return _users.FirstOrDefault(user => user.Id == Id);

        }

       
    }
}
