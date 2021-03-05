namespace WebFramework.Api
{
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public ApiResultStatusCode StatusCode { get; set; }
        public string Message { get; set; }
    }
    public class ApiResult<TData> : ApiResult
    {
        public TData Data { get; set; }
        public static implicit operator ApiResult<TData>(TData value)
        {
            return new ApiResult<TData>
            {
                IsSuccess = true,
                StatusCode = ApiResultStatusCode.success,
                Message = "عملیات با موفقیت انجام شد",
                Data = value
            };
        }

    }

}