// Type: BattleServer.BattleHandler
// Assembly: BattleServer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 94EB521D-142E-4255-A47D-605259FEBED7
// Assembly location: F:\sp\South park\Сезон 10\Project Blackout Server Consolidation\bin\Debug\BattleServer.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
//BR

namespace BattleServer
{
  public class BattleHandler
  {
    private UdpClient _client;

    public Player player3 { get; set; }

    public BattleHandler(UdpClient client)
    {
      this._client = client;
      try
      {
        this._client.BeginReceive(new AsyncCallback(this.BeginReceive), (object) null);
      }
      catch (Exception ex)
      {
      }
    }

    public void BeginReceive(IAsyncResult result)
    {
      IPEndPoint remoteEP = (IPEndPoint) null;
      MemoryStream memoryStream1 = new MemoryStream();
      MemoryStream memoryStream2 = new MemoryStream();
      MemoryStream memoryStream3 = new MemoryStream();
      MemoryStream memoryStream4 = new MemoryStream();
      MemoryStream memoryStream5 = new MemoryStream();
      byte[] numArray = this._client.EndReceive(result, ref remoteEP);
      byte num = numArray[0];
      if ((uint) num <= 67U)
      {
        switch (num)
        {
          case (byte) 1:
            List<Player> playersInRoom1 = Program.getRoomManager().getPlayersINRoom(remoteEP.Address);
            for (int index = 0; index < playersInRoom1.Count; ++index)
            {
              Player player1 = playersInRoom1[index];
              if (player1 != null)
                this._client.Send(numArray, numArray.Length, player1._address.ToString(), 29890);
              Player player2 = playersInRoom1[index];
              if (player2 != null)
                this._client.Send(numArray, numArray.Length, player2._address.ToString(), 29890);
              Player player3 = playersInRoom1[index];
              if (player3 != null)
                this._client.Send(numArray, numArray.Length, player3._address.ToString(), 29890);
              Player player4 = playersInRoom1[index];
              if (player4 != null)
                this._client.Send(numArray, numArray.Length, player4._address.ToString(), 29890);
              if (playersInRoom1[index] != null)
                this._client.Send(numArray, numArray.Length, player4._address.ToString(), 29890);
            }
            return;
          case (byte) 3:
            List<Player> playersInRoom2 = Program.getRoomManager().getPlayersINRoom(remoteEP.Address);
            if (playersInRoom2 == null)
              return;
            for (int index = 0; index < playersInRoom2.Count; ++index)
            {
              Player player = playersInRoom2[index];
              if (player != null && player._address.ToString() != remoteEP.Address.ToString())
              {
                MemoryStream memoryStream6 = new MemoryStream();
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                {
                  memoryStream6.WriteByte((byte) 4);
                  memoryStream6.WriteByte(byte.MaxValue);
                }
                else
                {
                  memoryStream6.WriteByte((byte) 3);
                  memoryStream6.WriteByte(numArray[1]);
                }
                memoryStream6.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream6.ToArray(), memoryStream6.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream7 = new MemoryStream();
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                {
                  memoryStream7.WriteByte((byte) 4);
                  memoryStream7.WriteByte(byte.MaxValue);
                }
                else
                {
                  memoryStream7.WriteByte((byte) 3);
                  memoryStream7.WriteByte(numArray[1]);
                }
                memoryStream7.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream7.ToArray(), memoryStream7.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream8 = new MemoryStream();
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                {
                  memoryStream8.WriteByte((byte) 4);
                  memoryStream8.WriteByte(byte.MaxValue);
                }
                else
                {
                  memoryStream8.WriteByte((byte) 3);
                  memoryStream8.WriteByte(numArray[1]);
                }
                memoryStream8.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream8.ToArray(), memoryStream8.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream9 = new MemoryStream();
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                {
                  memoryStream9.WriteByte((byte) 4);
                  memoryStream9.WriteByte(byte.MaxValue);
                }
                else
                {
                  memoryStream9.WriteByte((byte) 3);
                  memoryStream9.WriteByte(numArray[1]);
                }
                memoryStream9.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream9.ToArray(), memoryStream9.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream10 = new MemoryStream();
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                {
                  memoryStream10.WriteByte((byte) 4);
                  memoryStream10.WriteByte(byte.MaxValue);
                }
                else
                {
                  memoryStream10.WriteByte((byte) 3);
                  memoryStream10.WriteByte(numArray[1]);
                }
                memoryStream10.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream10.ToArray(), memoryStream9.ToArray().Length, player._address.ToString(), 29890);
              }
            }
            return;
          case (byte) 4:
            List<Player> playersInRoom3 = Program.getRoomManager().getPlayersINRoom(remoteEP.Address);
            if (playersInRoom3 == null)
              return;
            for (int index = 0; index < playersInRoom3.Count; ++index)
            {
              Player player = playersInRoom3[index];
              if (player != null && player._address.ToString() != remoteEP.Address.ToString())
              {
                Console.WriteLine("Client: " + player._address.ToString());
                MemoryStream memoryStream6 = new MemoryStream();
                memoryStream6.WriteByte((byte) 4);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream6.WriteByte(byte.MaxValue);
                else
                  memoryStream6.WriteByte(numArray[1]);
                memoryStream6.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream6.ToArray(), memoryStream6.ToArray().Length, player._address.ToString(), 29890);
                Console.WriteLine("Client: " + player._address.ToString());
                MemoryStream memoryStream7 = new MemoryStream();
                memoryStream7.WriteByte((byte) 4);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream7.WriteByte(byte.MaxValue);
                else
                  memoryStream7.WriteByte(numArray[1]);
                memoryStream7.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream7.ToArray(), memoryStream7.ToArray().Length, player._address.ToString(), 29890);
                Console.WriteLine("Client: " + player._address.ToString());
                MemoryStream memoryStream8 = new MemoryStream();
                memoryStream8.WriteByte((byte) 4);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream8.WriteByte(byte.MaxValue);
                else
                  memoryStream8.WriteByte(numArray[1]);
                memoryStream8.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream8.ToArray(), memoryStream8.ToArray().Length, player._address.ToString(), 29890);
                Console.WriteLine("Client: " + player._address.ToString());
                MemoryStream memoryStream9 = new MemoryStream();
                memoryStream9.WriteByte((byte) 4);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream9.WriteByte(byte.MaxValue);
                else
                  memoryStream9.WriteByte(numArray[1]);
                memoryStream9.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream9.ToArray(), memoryStream9.ToArray().Length, player._address.ToString(), 29890);
                Console.WriteLine("Client: " + player._address.ToString());
                MemoryStream memoryStream10 = new MemoryStream();
                memoryStream10.WriteByte((byte) 4);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream10.WriteByte(byte.MaxValue);
                else
                  memoryStream10.WriteByte(numArray[1]);
                memoryStream10.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream10.ToArray(), memoryStream10.ToArray().Length, player._address.ToString(), 29890);
              }
            }
            return;
          case (byte) 65:
            for (int player1 = 0; player1 < Program.getRoomManager().getCountPlayer(remoteEP.Address); ++player1)
            {
              Player player2 = Program.getRoomManager().getPlayer(remoteEP.Address, player1);
              if (player2 != null)
              {
                Console.WriteLine("Client: " + player2._address.ToString());
                MemoryStream memoryStream6 = new MemoryStream();
                memoryStream6.WriteByte((byte) 66);
                memoryStream6.WriteByte(numArray[1]);
                memoryStream6.Write(new byte[5], 0, 5);
                memoryStream6.WriteByte((byte) 29);
                memoryStream6.Write(new byte[21], 0, 21);
                this._client.Send(memoryStream6.ToArray(), (int) memoryStream6.Length, remoteEP);
              }
              if (player2 != null)
              {
                Console.WriteLine("Client: " + player2._address.ToString());
                MemoryStream memoryStream6 = new MemoryStream();
                memoryStream6.WriteByte((byte) 66);
                memoryStream6.WriteByte(numArray[1]);
                memoryStream6.Write(new byte[5], 0, 5);
                memoryStream6.WriteByte((byte) 29);
                memoryStream6.Write(new byte[21], 0, 21);
                this._client.Send(memoryStream6.ToArray(), (int) memoryStream6.Length, remoteEP);
              }
              if (player2 != null)
              {
                Console.WriteLine("Client: " + player2._address.ToString());
                MemoryStream memoryStream6 = new MemoryStream();
                memoryStream6.WriteByte((byte) 66);
                memoryStream6.WriteByte(numArray[1]);
                memoryStream6.Write(new byte[5], 0, 5);
                memoryStream6.WriteByte((byte) 29);
                memoryStream6.Write(new byte[21], 0, 21);
                this._client.Send(memoryStream6.ToArray(), (int) memoryStream6.Length, remoteEP);
              }
              if (player2 != null)
              {
                Console.WriteLine("Client: " + player2._address.ToString());
                memoryStream4 = new MemoryStream();
                memoryStream4.WriteByte((byte) 66);
                memoryStream4.WriteByte(numArray[1]);
                memoryStream4.Write(new byte[5], 0, 5);
                memoryStream4.WriteByte((byte) 29);
                memoryStream4.Write(new byte[21], 0, 21);
                this._client.Send(memoryStream4.ToArray(), (int) memoryStream4.Length, remoteEP);
              }
              if (player2 != null)
              {
                Console.WriteLine("Client: " + player2._address.ToString());
                MemoryStream memoryStream6 = new MemoryStream();
                memoryStream6.WriteByte((byte) 66);
                memoryStream6.WriteByte(numArray[1]);
                memoryStream6.Write(new byte[5], 0, 5);
                memoryStream6.WriteByte((byte) 29);
                memoryStream6.Write(new byte[21], 0, 21);
                this._client.Send(memoryStream4.ToArray(), (int) memoryStream4.Length, remoteEP);
              }
            }
            return;
          case (byte) 67:
            new Player()._address = remoteEP.Address;
            Console.WriteLine("--------END---------");
            Program.getRoomManager().RemovePlayerInRoom(remoteEP.Address);
            return;
        }
      }
      else
      {
        switch (num)
        {
          case (byte) 84:
            List<Player> playersInRoom4 = Program.getRoomManager().getPlayersINRoom(remoteEP.Address);
            if (playersInRoom4 == null)
              return;
            for (int index = 0; index < playersInRoom4.Count; ++index)
            {
              Player player = playersInRoom4[index];
              if (player != null && player._address.ToString() != remoteEP.Address.ToString())
              {
                MemoryStream memoryStream6 = new MemoryStream();
                memoryStream6.WriteByte((byte) 84);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream6.WriteByte(byte.MaxValue);
                else
                  memoryStream6.WriteByte(numArray[1]);
                memoryStream6.Write(numArray, 3, numArray.Length - 3);
                this._client.Send(memoryStream6.ToArray(), memoryStream6.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream7 = new MemoryStream();
                memoryStream7.WriteByte((byte) 84);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream7.WriteByte(byte.MaxValue);
                else
                  memoryStream7.WriteByte(numArray[1]);
                memoryStream7.Write(numArray, 3, numArray.Length - 3);
                this._client.Send(memoryStream7.ToArray(), memoryStream7.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream8 = new MemoryStream();
                memoryStream8.WriteByte((byte) 84);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream8.WriteByte(byte.MaxValue);
                else
                  memoryStream8.WriteByte(numArray[1]);
                memoryStream8.Write(numArray, 3, numArray.Length - 3);
                this._client.Send(memoryStream8.ToArray(), memoryStream8.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream9 = new MemoryStream();
                memoryStream9.WriteByte((byte) 84);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream9.WriteByte(byte.MaxValue);
                else
                  memoryStream9.WriteByte(numArray[1]);
                memoryStream9.Write(numArray, 3, numArray.Length - 3);
                this._client.Send(memoryStream9.ToArray(), memoryStream9.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream10 = new MemoryStream();
                memoryStream10.WriteByte((byte) 84);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream10.WriteByte(byte.MaxValue);
                else
                  memoryStream10.WriteByte(numArray[1]);
                memoryStream10.Write(numArray, 3, numArray.Length - 3);
                this._client.Send(memoryStream10.ToArray(), memoryStream10.ToArray().Length, player._address.ToString(), 29890);
              }
            }
            return;
          case (byte) 97:
            List<Player> playersInRoom5 = Program.getRoomManager().getPlayersINRoom(remoteEP.Address);
            if (playersInRoom5 == null)
              return;
            for (int index = 0; index < playersInRoom5.Count; ++index)
            {
              Player player = playersInRoom5[index];
              if (player != null && player._address.ToString() != remoteEP.Address.ToString())
              {
                MemoryStream memoryStream6 = new MemoryStream();
                memoryStream6.WriteByte((byte) 97);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream6.WriteByte(byte.MaxValue);
                else
                  memoryStream6.WriteByte(numArray[1]);
                memoryStream6.Write(numArray, 2, numArray.Length - 2);
                memoryStream6.Write(numArray, 2, numArray.Length - 2);
                MemoryStream memoryStream7 = new MemoryStream();
                memoryStream7.WriteByte((byte) 97);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream7.WriteByte(byte.MaxValue);
                else
                  memoryStream7.WriteByte(numArray[1]);
                memoryStream7.Write(numArray, 2, numArray.Length - 2);
                memoryStream7.Write(numArray, 2, numArray.Length - 2);
                MemoryStream memoryStream8 = new MemoryStream();
                memoryStream8.WriteByte((byte) 97);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream8.WriteByte(byte.MaxValue);
                else
                  memoryStream8.WriteByte(numArray[1]);
                memoryStream8.Write(numArray, 2, numArray.Length - 2);
                memoryStream8.Write(numArray, 2, numArray.Length - 2);
                MemoryStream memoryStream9 = new MemoryStream();
                memoryStream9.WriteByte((byte) 97);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream9.WriteByte(byte.MaxValue);
                else
                  memoryStream9.WriteByte(numArray[1]);
                memoryStream9.Write(numArray, 2, numArray.Length - 2);
                memoryStream9.Write(numArray, 2, numArray.Length - 2);
                MemoryStream memoryStream10 = new MemoryStream();
                memoryStream10.WriteByte((byte) 97);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream10.WriteByte(byte.MaxValue);
                else
                  memoryStream10.WriteByte(numArray[1]);
                memoryStream10.Write(numArray, 2, numArray.Length - 2);
                memoryStream10.Write(numArray, 2, numArray.Length - 2);
              }
            }
            return;
          case (byte) 131:
            List<Player> playersInRoom6 = Program.getRoomManager().getPlayersINRoom(remoteEP.Address);
            if (playersInRoom6 == null)
              return;
            for (int index = 0; index < playersInRoom6.Count; ++index)
            {
              Player player = playersInRoom6[index];
              if (player != null && player._address.ToString() != remoteEP.Address.ToString())
              {
                MemoryStream memoryStream6 = new MemoryStream();
                memoryStream6.WriteByte((byte) 131);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream6.WriteByte(byte.MaxValue);
                else
                  memoryStream6.WriteByte(numArray[1]);
                memoryStream6.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream6.ToArray(), memoryStream6.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream7 = new MemoryStream();
                memoryStream7.WriteByte((byte) 131);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream7.WriteByte(byte.MaxValue);
                else
                  memoryStream7.WriteByte(numArray[1]);
                memoryStream7.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream7.ToArray(), memoryStream7.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream8 = new MemoryStream();
                memoryStream8.WriteByte((byte) 131);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream8.WriteByte(byte.MaxValue);
                else
                  memoryStream8.WriteByte(numArray[1]);
                memoryStream8.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream8.ToArray(), memoryStream8.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream9 = new MemoryStream();
                memoryStream9.WriteByte((byte) 131);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream9.WriteByte(byte.MaxValue);
                else
                  memoryStream9.WriteByte(numArray[1]);
                memoryStream9.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream9.ToArray(), memoryStream9.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream10 = new MemoryStream();
                memoryStream10.WriteByte((byte) 131);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream10.WriteByte(byte.MaxValue);
                else
                  memoryStream10.WriteByte(numArray[1]);
                memoryStream10.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream10.ToArray(), memoryStream10.ToArray().Length, player._address.ToString(), 29890);
              }
            }
            return;
          case (byte) 132:
            List<Player> playersInRoom7 = Program.getRoomManager().getPlayersINRoom(remoteEP.Address);
            if (playersInRoom7 == null)
              return;
            for (int index = 0; index < playersInRoom7.Count; ++index)
            {
              Player player = playersInRoom7[index];
              if (player != null && player._address.ToString() != remoteEP.Address.ToString())
              {
                MemoryStream memoryStream6 = new MemoryStream();
                memoryStream6.WriteByte((byte) 132);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream6.WriteByte(byte.MaxValue);
                else
                  memoryStream6.WriteByte(numArray[1]);
                memoryStream6.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream6.ToArray(), memoryStream6.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream7 = new MemoryStream();
                memoryStream7.WriteByte((byte) 132);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream7.WriteByte(byte.MaxValue);
                else
                  memoryStream7.WriteByte(numArray[1]);
                memoryStream7.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream7.ToArray(), memoryStream7.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream8 = new MemoryStream();
                memoryStream8.WriteByte((byte) 132);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream8.WriteByte(byte.MaxValue);
                else
                  memoryStream8.WriteByte(numArray[1]);
                memoryStream8.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream8.ToArray(), memoryStream8.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream9 = new MemoryStream();
                memoryStream9.WriteByte((byte) 132);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream9.WriteByte(byte.MaxValue);
                else
                  memoryStream9.WriteByte(numArray[1]);
                memoryStream9.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream9.ToArray(), memoryStream9.ToArray().Length, player._address.ToString(), 29890);
                MemoryStream memoryStream10 = new MemoryStream();
                memoryStream10.WriteByte((byte) 132);
                if (Program.getRoomManager().getRoom(remoteEP.Address).type == 3)
                  memoryStream10.WriteByte(byte.MaxValue);
                else
                  memoryStream10.WriteByte(numArray[1]);
                memoryStream10.Write(numArray, 2, numArray.Length - 2);
                this._client.Send(memoryStream10.ToArray(), memoryStream10.ToArray().Length, player._address.ToString(), 29890);
              }
            }
            return;
        }
      }
      Console.WriteLine("[WARNING]: Opcode " + (object) numArray[0]);
    }
  }
}
