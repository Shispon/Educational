namespace ApiForAuth.Models
{
    public class UserResponse
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public UserData Data { get; set; }
        

        public static UserResponse Success(string message, UserData data, string token = null)
        {
            return new UserResponse
            {
                Id = 1,
                Code = 0,
                Message = message,
                Data = data,
                
            };
        }

        public static UserResponse Error(string message)
        {
            return new UserResponse
            {
                Id = 1,
                Code = 1,
                Message = "Error: " + message,
                Data = null
               
            };
        }
    }

    public class UserData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }

    public class UserAuth
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
    public class UserModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string NumberPhone { get; set; }
    }

}




