namespace UsersProfile.Data
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Username { get; set; }

        public List<int> FriendIds { get; set; }
    }

    public class UserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}