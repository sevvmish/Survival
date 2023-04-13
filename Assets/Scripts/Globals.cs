using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Globals : MonoBehaviour
{
    public static bool isConnectionEstablished = false;
    public static byte[] RSASecretCode;
    public static byte[] ClientNetworkID;
    public static int TicketID = 12345679;
    public const string SERVER_IP = "192.168.0.108"; //192.168.0.108     usa - 170.130.40.253   31.172.66.150
    public const int TCP_PORT = 3000;
    public const int UDP_PORT = 3001;
    
    public const int TICKi = 50;
    public const float TICKf = 0.05f;

    public const int SCREEN_WIDTH = 1440;
    public const int SCREEN_HEIGHT = 720;

    public static Stopwatch Timer = new Stopwatch();

    public enum PacketCode
    {
        None = 0,
        MoveFromClient = 1, //joystick press data
        MoveFromServer = 2,
        GetClientUDPEndpoint = 3,
        InitialPlayerData = 4,
        OperativePlayerData = 5,
        ListOfMovementFromServer = 6

    }
}
