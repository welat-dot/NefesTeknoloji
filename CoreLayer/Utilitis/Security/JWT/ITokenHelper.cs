namespace CoreLayer.Utilitis.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(string username);
    }
}
