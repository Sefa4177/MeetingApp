namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() {MeetingId = 1,Id = 1, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 1,Id = 2, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 2,Id = 3, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="121413422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 2,Id = 4, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 3,Id = 5, Name = "Ali", Email = "ahsh@gmail.com", Phone ="121413443", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 3,Id = 6, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 3,Id = 7, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="12143422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 4,Id = 8, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 4,Id = 9, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="121413424", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 4,Id = 10, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 5,Id = 11, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="121413422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 5,Id = 12, Name = "mert", Email = "ahwqedh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 5,Id = 13, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 1,Id = 14, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 2,Id = 15, Name = "ayşe", Email = "ahsasdh@gmail.com", Phone ="12141342343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 1,Id = 16, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 2,Id = 17, Name = "ayşe", Email = "ahsaddh@gmail.com", Phone ="12143422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 2,Id = 18, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 3,Id = 19, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 3,Id = 20, Name = "mehmet", Email = "asd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 3,Id = 21, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="12143422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 4,Id = 22, Name = "mert", Email = "ahwesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 4,Id = 23, Name = "Ali", Email = "ahsh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 5,Id = 24, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 5,Id = 25, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 5,Id = 26, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="121413422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 5,Id = 27, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 5,Id = 28, Name = "Ali", Email = "ahsh@gmail.com", Phone ="121413443", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 6,Id = 29, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 6,Id = 30, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="12143422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 6,Id = 31, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 6,Id = 32, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="121413424", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 6,Id = 33, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 6,Id = 34, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="121413422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 7,Id = 35, Name = "mert", Email = "ahwqedh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 7,Id = 36, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 7,Id = 37, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 7,Id = 38, Name = "ayşe", Email = "ahsasdh@gmail.com", Phone ="12141342343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 8,Id = 39, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 8,Id = 40, Name = "ayşe", Email = "ahsaddh@gmail.com", Phone ="12143422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 9,Id = 41, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 9,Id = 42, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 9,Id = 43, Name = "mehmet", Email = "asd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 9,Id = 44, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="12143422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 10,Id = 45, Name = "mert", Email = "ahwesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 10,Id = 46, Name = "Ali", Email = "ahsh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 10,Id = 47, Name = "mehmet", Email = "asd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 10,Id = 48, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="12143422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 11,Id = 49, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 11,Id = 50, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 11,Id = 51, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="121413422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 11,Id = 52, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 11,Id = 53, Name = "Ali", Email = "ahsh@gmail.com", Phone ="121413443", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 11,Id = 54, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 55, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="12143422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 56, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 57, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="121413424", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 58, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 59, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="121413422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 60, Name = "mert", Email = "ahwqedh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 61, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 62, Name = "mehmet", Email = "ahsd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 63, Name = "ayşe", Email = "ahsasdh@gmail.com", Phone ="12141342343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 64, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 12,Id = 65, Name = "ayşe", Email = "ahsaddh@gmail.com", Phone ="12143422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 14,Id = 66, Name = "mert", Email = "ahwqesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 13,Id = 67, Name = "Ali", Email = "ahsdh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 13,Id = 68, Name = "mehmet", Email = "asd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 13,Id = 69, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="12143422343", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 14,Id = 70, Name = "mert", Email = "ahwesdh@gmail.com", Phone ="1214134243", WillAttend = false});
            _users.Add(new UserInfo() {MeetingId = 14,Id = 71, Name = "Ali", Email = "ahsh@gmail.com", Phone ="1214134243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 13,Id = 72, Name = "mehmet", Email = "asd232h@gmail.com", Phone ="12144243", WillAttend = true});
            _users.Add(new UserInfo() {MeetingId = 14,Id = 73, Name = "ayşe", Email = "ahsasddh@gmail.com", Phone ="12143422343", WillAttend = true});
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
            user.Id = Users.Count +1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}