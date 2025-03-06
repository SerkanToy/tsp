namespace tsp.api.Domain.Core.Base
{
    public class BaseResponseModel
    {
        public bool isSuccess { get; set; }
        public List<string> Messages { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
