// Type: BattleServer.GSHandler
// Assembly: BattleServer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 94EB521D-142E-4255-A47D-605259FEBED7
// Assembly location: F:\sp\South park\Сезон 10\Project Blackout Server Consolidation\bin\Debug\BattleServer.exe

using System;
using System.Net;
using System.Net.Sockets;
//

namespace BattleServer
{
  public class GSHandler
  {
    private UdpClient _client;

    public GSHandler(UdpClient client)
    {
      this._client = client;
      this._client.BeginReceive(new AsyncCallback(this.BeginStaticReceive), (object) null);
    }

    public void BeginStaticReceive(IAsyncResult result)
    {
      IPEndPoint remoteEP = (IPEndPoint) null;
      byte[] numArray1 = this._client.EndReceive(result, ref remoteEP);
      short num1 = BitConverter.ToInt16(numArray1, 0);
      switch (num1)
      {
        case (short) 1:
          byte num2 = numArray1[2];
          Console.WriteLine("Создание комнаты");
          Console.WriteLine("ADD PLAYER");
          Console.WriteLine("PLAYER");
          Room room = new Room()
          {
            id = Program.getRoomManager().getRooms().Count
          };
          for (int index = 0; index < (int) num2; ++index)
          {
            Player player = new Player();
            byte num3 = numArray1[3];
            byte[] numArray2 = new byte[4];
            byte[] address = new byte[4]
            {
              numArray1[4 + index * 6],
              numArray1[5 + index * 6],
              numArray1[6 + index * 6],
              numArray1[7 + index * 6]
            };
            player.slot = (int) numArray1[4 + index * 5];
            IPAddress ipAddress = new IPAddress(address);
            player._address = ipAddress;
            room.getPlayers().Add(player);
          }
          room.type = (int) numArray1[3 + (int) num2 * 6];
          Program.getRoomManager().getRooms().Add(room);
          Console.WriteLine("Room type = " + room.type.ToString());
          Console.WriteLine("CREATE ROOM <<<");
          break;
        case (short) byte.MaxValue:
          break;
        default:
          Console.WriteLine("Opcode: " + num1.ToString());
          break;
      }
    }
  }
}
