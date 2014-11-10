// Type: BattleServer.RoomsManager
// Assembly: BattleServer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 94EB521D-142E-4255-A47D-605259FEBED7
// Assembly location: F:\sp\South park\Сезон 10\Project Blackout Server Consolidation\bin\Debug\BattleServer.exe

using System;
using System.Collections.Generic;
using System.Net;
//ROM BR

namespace BattleServer
{
  public class RoomsManager
  {
    public List<Room> _list = new List<Room>();
    public static RoomsManager _instance;

    public int getCountPlayer(IPAddress ip)
    {
      for (int index1 = 0; index1 < this._list.Count; ++index1)
      {
        for (int index2 = 0; index2 < this._list[index1]._players.Count; ++index2)
        {
          if (this._list[index1]._players[index2]._address.ToString() == ip.ToString())
            return this._list[index1].getPlayers().Count;
        }
      }
      return 0;
    }

    public static RoomsManager getInstance()
    {
      if (RoomsManager._instance == null)
        RoomsManager._instance = new RoomsManager();
      return RoomsManager._instance;
    }

    public Player getPlayer(IPAddress ip)
    {
      for (int index1 = 0; index1 < this._list.Count; ++index1)
      {
        for (int index2 = 0; index2 < this._list[index1]._players.Count; ++index2)
        {
          if (this._list[index1]._players[index2]._address.ToString() == ip.ToString())
            return this._list[index1].getPlayers()[index2];
        }
      }
      return (Player) null;
    }

    public Player getPlayer(IPAddress host, int player)
    {
      for (int index = 0; index < this._list.Count; ++index)
      {
        if (this._list[index] != null && this._list[index]._players[player] != null && this._list[index]._players[player]._address.ToString() == host.ToString())
          return this._list[index].getPlayers()[player];
      }
      return (Player) null;
    }

    public List<Player> getPlayersINRoom(IPAddress address)
    {
      for (int index1 = 0; index1 < this._list.Count; ++index1)
      {
        for (int index2 = 0; index2 < this._list[index1]._players.Count; ++index2)
        {
          if (this._list[index1]._players[index2]._address.ToString() == address.ToString())
            return this._list[index1]._players;
        }
      }
      return (List<Player>) null;
    }

    public Room getRoom(IPAddress ip)
    {
      for (int index1 = 0; index1 < this._list.Count; ++index1)
      {
        for (int index2 = 0; index2 < this._list[index1]._players.Count; ++index2)
        {
          if (this._list[index1]._players[index2]._address.ToString() == ip.ToString())
            return this._list[index1];
        }
      }
      return (Room) null;
    }

    public List<Room> getRooms()
    {
      return this._list;
    }

    public void RemovePlayerInRoom(IPAddress ip)
    {
      for (int index1 = 0; index1 < this._list.Count; ++index1)
      {
        for (int index2 = 0; index2 < this._list[index1]._players.Count; ++index2)
        {
          if (this._list[index1]._players[index2]._address.ToString() == ip.ToString())
            this._list[index1].RemovePlayer(this._list[index1]._players[index2]);
        }
        if (this._list[index1]._players.Count == 0)
        {
          Console.WriteLine("[RemovePlayerInRoom]: Remove room >>>");
          this._list.RemoveAt(index1);
          Console.WriteLine("[RemovePlayerInRoom]: Remove room <<<");
        }
      }
    }
  }
}
