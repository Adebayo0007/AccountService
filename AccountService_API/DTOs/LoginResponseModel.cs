namespace AccountService_API.DTOs
{
    public class LoginResponseModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }
        public ApplicationUserDto? ApplicationUserDto { get; set; }
    }
}
