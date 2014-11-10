// Type: BattleServer.Program
// Assembly: BattleServer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 94EB521D-142E-4255-A47D-605259FEBED7
// Assembly location: F:\sp\South park\Сезон 10\Project Blackout Server Consolidation\bin\Debug\BattleServer.exe

using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;

namespace BattleServer
{
  internal class Program
  {
    protected static RoomsManager rs;

    protected static void BattleHandlerInit()
    {
      UdpClient client = new UdpClient(40006);
      while (true)
      {
        Thread.Sleep(10);
        if (client.Available > 0)
        {
          BattleHandler battleHandler = new BattleHandler(client);
        }
      }
    }

    public static RoomsManager getRoomManager()
    {
      if (Program.rs == null)
        Program.rs = new RoomsManager();
      return Program.rs;
    }

    protected static void GSHandlerInit()
    {
      UdpClient client = new UdpClient(60000);
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("[******************************************]");
      Console.WriteLine("Iniciando Emulador SystemPBlackout ");
      Console.WriteLine("Copyright Project Wars 2014");
      Console.WriteLine("Version 0.0.2.0");
      Console.WriteLine("[******************************************]");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("System - Carregamento de dados...");
      Console.WriteLine("System - Carregado.");
      Console.WriteLine("System - Leitura modelo jogador...");
      Console.WriteLine("System - Carregado.");
      Console.WriteLine("System - Crindo um servidor...");
      Console.WriteLine("System - Carregado.");
      Console.WriteLine("System - Connection DB...");
      Console.WriteLine("System - Carregado.");
      Console.WriteLine("System - connection Emulador...");
      Console.WriteLine("System - Carregado.");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("[*********************]");
      Console.WriteLine("Emulador - 4x4 [ON]");
      Console.WriteLine("[*********************]");
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("AssemblyInfo ON");
      Console.WriteLine("BattleHandler ON");
      Console.WriteLine("GSHandler ON");
      Console.WriteLine("P2PPlayer ON");
      Console.WriteLine("Player ON");
      Console.WriteLine("Room ON");
      Console.WriteLine("RoomsManager ON");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("[*********************]");
      Console.WriteLine("BattleServer - 4x4 [ON]");
      Console.WriteLine("[*********************]");
      Console.ResetColor();
      while (true)
      {
        Thread.Sleep(10);
        if (client.Available > 0)
        {
          GSHandler gsHandler = new GSHandler(client);
        }
      }
    }

    protected static void Main(string[] args)
    {
      new Thread(new ThreadStart(Program.GSHandlerInit)).Start();
      new Thread(new ThreadStart(Program.BattleHandlerInit)).Start();
      Process.GetCurrentProcess().WaitForExit();
    }
  }
}
