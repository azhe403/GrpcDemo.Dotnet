# GrpcDemo.Dotnet

Minimal gRPC demo in .NET with a server hosting multiple gRPC services and a console client that calls them.

## Projects

- `GrpcDemo.Server` — ASP.NET Core gRPC server
  - Hosts: `GreeterService`, `PingService`
  - Default URLs (launch profile `https`): `https://localhost:7005` and `http://localhost:5198`
- `GrpcDemo.Client` — console app gRPC client
  - Calls the server at `https://localhost:7005`

## Prerequisites

- .NET SDK `10.0.100` (see `global.json`)
- HTTPS dev certificate (first run on a machine):

```powershell
dotnet dev-certs https --trust
```

## Run

Start the server:

```powershell
dotnet run --project .\GrpcDemo.Server\GrpcDemo.Server.csproj --launch-profile https
```

Run the client in another terminal:

```powershell
dotnet run --project .\GrpcDemo.Client\GrpcDemo.Client.csproj
```

You should see a greeting response and a ping response printed by the client.
