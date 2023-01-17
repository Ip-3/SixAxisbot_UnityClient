using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using System.Threading;

public class TcpClientexample : MonoBehaviour
{

    public static TcpClient client;
    public static NetworkStream stream;
    public static string data_from_qt = null;
    public static string serverIP = "127.0.0.1"; // server IP address
    public static int port = 6359; // server port
    public static string message = "Hello, Server!"; // message to send to the server

    void Start()
    {
        // Create a new TcpClient object
        client = new TcpClient();

        // Connect to the server
        try
        {
            client.Connect(serverIP, port);
            Thread thr = new Thread(() => recv_Client());
            thr.Start();
        }

        catch (Exception e)
        {
            Debug.LogException(e);
        }

        // Get the network stream
    }

    void Update() { }
    public static void recv_Client(){
        while (true)
        {
            if (client.Connected)
            {
                // Send the message to the server
                NetworkStream stream = client.GetStream();

                if (stream.DataAvailable)
                {
                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    int bufferLength = stream.Read(buffer, 0, client.ReceiveBufferSize);
                    string data_received = Encoding.ASCII.GetString(buffer, 0, bufferLength);
                    data_from_qt = data_received;
                    Debug.Log(data_received);
                }
            }
        }
    }
}
