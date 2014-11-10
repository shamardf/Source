// Type: BattleServer.Room
// Assembly: BattleServer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 94EB521D-142E-4255-A47D-605259FEBED7
// Assembly location: F:\sp\South park\Сезон 10\Project Blackout Server Consolidation\bin\Debug\BattleServer.exe

using System;
using System.Collections.Generic;
using System.Net;
//ROM BR
namespace BattleServer
{
  public class Room
  {
    public List<Player> _players = new List<Player>();
    public int id = -1;
    public int type = 2;

    public void AddPlayer(Player player)
    {
      for (int index = 0; index < this._players.Count; ++index)
      {
        if (this._players[index]._address == player._address)
          return;
      }
      this._players.Add(player);
    }

    public Player getPlayer(IPAddress ip)
    {
      for (int index = 0; index < this._players.Count; ++index)
      {
        Console.WriteLine((string) (object) this._players[index]._address.Address + (object) " and " + (string) (object) ip.Address);
        if (this._players[index]._address == ip)
          return this._players[index];
      }
      return (Player) null;
    }

    public List<Player> getPlayers()
    {
      return this._players;
    }

    public void RemovePlayer(Player p)
    {
      for (int index = 0; index < this._players.Count; ++index)
      {
        if (this._players[index]._address.ToString() == p._address.ToString())
          this._players.RemoveAt(index);
      }
    }
  }
}
