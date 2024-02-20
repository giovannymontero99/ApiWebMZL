using ServiceStack;
using ApiWebMZL.ServiceModel;

namespace ApiWebMZL.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }
}