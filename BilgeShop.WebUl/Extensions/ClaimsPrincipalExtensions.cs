using BilgeShop.Data.Enums;
using System.Security.Claims;

namespace BilgeShop.WebUI.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
      //todo:cookiede tutulan verilerin kontrollerini yapmak için metotlar yazılacak.
      public static int GetUserId(this ClaimsPrincipal user)
        {
            return Convert.ToInt32(user.Claims.FirstOrDefault(x=>x.Type=="id")?.Value);
        }

        public static string GetUserFirstName(this ClaimsPrincipal user)
        {
            return user.Claims.FirstOrDefault(x => x.Type == "firstname")?.Value;
        }
        public static string GetUserLastName(this ClaimsPrincipal user)
        {
            return user.Claims.FirstOrDefault(x => x.Type == "lastname")?.Value;
        }
        public static string GetUserEmail(this ClaimsPrincipal user)
        {
            return user.Claims.FirstOrDefault(x => x.Type == "email")?.Value;
        }






        public static bool IsLogged(this ClaimsPrincipal user)
        {
            if (user.Claims.FirstOrDefault(x => x.Type == "id") != null)
                return true;
            else
                return false;

        }
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            if (user.Claims.FirstOrDefault(x => x.Type == "userType")?.Value == UserTypeEnum.admin.ToString())
                return true;
            else
                return false;
        }



    }
}
