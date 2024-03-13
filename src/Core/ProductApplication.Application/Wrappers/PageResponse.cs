namespace ProductApplication.Application.Wrappers
{
    public class PageResponse<T> : ServiceResponse<T>
    {
        public PageResponse(T value, int pageNumber, int pageSize) : base(value)
        {            
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
