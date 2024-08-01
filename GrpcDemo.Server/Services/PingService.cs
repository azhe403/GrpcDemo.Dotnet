using Grpc.Core;

namespace GrpcDemo.Server.Services;

public class PingService : Pinger.PingerBase
{
    public override Task<PingResponse> Ping(PingRequest request, ServerCallContext context)
    {
        return Task.FromResult(new PingResponse
        {
            Message = "Pong " + request.Message
        });
    }
}