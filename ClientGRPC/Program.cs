using Grpc.Net.Client;
using ClientGRPC;

using (var channel = GrpcChannel.ForAddress("https://localhost:7028"))
{
    var client = new Greeter.GreeterClient(channel);
    var reply = await client.SayHelloAsync(new HelloRequest
    {
        Name = "Pedro"
    });

    Console.WriteLine(reply.Message);

    var response = await client.GetDataAsync(new DataRequest { });

    foreach (var languaje in response.Languages)
    {
        Console.WriteLine(languaje);
    }

    Console.ReadKey();


}