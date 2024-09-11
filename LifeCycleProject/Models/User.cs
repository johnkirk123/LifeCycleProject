namespace LifeCycleProject.Models
{
    public class User
    {
     
        private int userID;
        private int roleID;
        private string userPassword;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string profileImage;

        public int UserID 
        { 
            get { return userID; } 
            set { userID = value; } 
        }
        public int RoleID 
        { 
            get { return roleID; } 
            set {  roleID = value; } 
        }
        //
        public string UserPassword 
        { 
            get {  return userPassword; } 
            set { userPassword = value; } 
        }

        public string FirstName 
        { 
            get { return firstName; } 
            set { firstName = value; } 
        }
        public string LastName 
        { 
            get { return lastName; } 
            set { lastName = value; } 
        }
        public string Email 
        { 
            get { return email; } 
            set { email = value; } 
        }
        public string Phone 
        { 
            get { return phone; } 
            set { phone = value; } 
        }
        public string ProfileImage 
        { get {  return profileImage; } 
          set {  profileImage = value; } 
        }

        public User()
        {

        }

        public User(int userID, int roleID, string userPassword, string firstName, string lastName, string email, string phone, string profileImage)
        {
            UserID = userID;
            RoleID = roleID;
            UserPassword = userPassword;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            ProfileImage = profileImage;
            
        }
    }
}
