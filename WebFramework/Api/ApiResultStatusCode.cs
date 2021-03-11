using System.ComponentModel.DataAnnotations;

namespace WebFramework.Api
{
    public enum ApiResultStatusCode
    {
        [Display(Name = "Successfully")]
        Success = 0,

        [Display(Name = "An error occurred on the server")]
        ServerError = 1,

        [Display(Name = "Submitted parameters are not valid")]
        BadRequest = 2,

        [Display(Name = "Not found")]
        NotFound = 3,

        [Display(Name = "List is empty")]
        ListEmpty = 4,

        [Display(Name = "An error occurred processing")]
        LogicError = 5,

        [Display(Name = "Authentication error")]
        UnAuthorized = 6        
    }
}
