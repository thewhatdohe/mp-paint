using System.Net.WebSockets;
using System.Text;

public class NetworkManager
{
    private ClientWebSocket ws = new ClientWebSocket();
    public Action<string> OnDataReceived;

    public async Task Connect(string url)
    {
        await ws.ConnectAsync(new Uri(url), CancellationToken.None);
        _ = Task.Run(ReceiveLoop);
    }

    public void Send(string data)
    {
        try
        {
            var bytes = Encoding.UTF8.GetBytes(data);
            ws.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None);
        }
        catch (Exception e) { Console.WriteLine("Send error: " + e.Message); }
    }

    private async Task ReceiveLoop()
    {
        var buffer = new byte[1024];
        try
        {
            while (ws.State == WebSocketState.Open)
            {
                var result = await ws.ReceiveAsync(buffer, CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Close) break;
                string data = Encoding.UTF8.GetString(buffer, 0, result.Count);
                OnDataReceived?.Invoke(data);
            }
        }
        catch (Exception e) { Console.WriteLine("Receive error: " + e.Message); }
    }
}