namespace throw_exception_performance.Models
{
    public class ResponseBase<T> where T : class
    {
        public ResponseBase()
        {
            IsSuccess = true;
        }

        public required T Data { get; set; }
        public string? Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
