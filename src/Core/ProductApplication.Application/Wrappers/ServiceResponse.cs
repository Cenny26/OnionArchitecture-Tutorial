namespace ProductApplication.Application.Wrappers
{
    public class ServiceResponse<T>
    {
        public ServiceResponse(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
    }
}
