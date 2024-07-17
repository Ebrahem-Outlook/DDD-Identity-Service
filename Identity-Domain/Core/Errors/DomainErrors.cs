using Identity_Domain.Core.BaseType;

namespace Identity_Domain.Core.Errors;

public static class DomainErrors 
{
    public static class User
    {
        public static Error NullOrEmpty => new Error("User.NullOrEmpty", "User Can not be null.");
        public static Error NotFound => new Error("User.NotFound", "User with specifid Id does not exsit.");
        public static Error DoblecateEmail => new Error("User.NullOrEmpty", "User with specified email already exsit.");
    }
}
