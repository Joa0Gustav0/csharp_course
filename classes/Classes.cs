using System;

namespace classes {
  static class Messages {
    public static void SendGreetings(string recipienteName) {
      Console.WriteLine($"Hello, {recipienteName}! Be welcome!");
    }
    public static void Wait() {
      Console.WriteLine("On a break... ☕");
      Thread.Sleep(1500);
    }
    public static void SayGoodBye(string recipienteName) {
      Console.WriteLine($"It's sad you have to go, {recipienteName}! Good bye!");
    }
  }

  class Agents {
    public static List<Agents> list = new List<Agents> {};

    public String name;
    private String Sex;
    private String IDCode = "000";
    private int completedMissions = 0;
    public bool active = false;

    public Agents(String agentName, String sex) {
      while (this.IDCode == "000") {
        this.IDCode = Agents.ValidateIDCode(new Random().Next(100, 1000).ToString());
      }
        this.Sex = sex;
        this.name = (this.Sex == "M" ? "Mr." : "Ms.") + agentName.ToUpper() +  $" {IDCode}";

      Agents.list.Add(this);
      this.active = true;
      Console.Clear();
      Console.WriteLine("Glad to have you joining this corporation, " + this.name + ".");
      Thread.Sleep(1500);
    }

    private static String ValidateIDCode(String IDCode) {
      if (Agents.list.Capacity < 1) return IDCode;

      bool matchExistentCode = false;

      foreach(Agents agent in Agents.list) {
        if (agent.IDCode == IDCode) matchExistentCode = true;
      }

      return matchExistentCode ? "000" : IDCode;
    }
    private static void ComputeAgentConcludedMission(String IDCode) {
      foreach(Agents agent in Agents.list) {
        if (agent.IDCode == IDCode) agent.completedMissions++;
      }
    }

    public void GoOnAMission() {
      Console.Clear();
      Console.WriteLine(this.name + " went on a mission. ✈");
      Thread.Sleep(1500);
      for (int i = 0; i < 5; i++) {
        Console.Clear();
        Console.WriteLine("Mission in progress. " + $"({5 - i} secs.)");
        Thread.Sleep(1000);
      }
      Agents.ComputeAgentConcludedMission(this.IDCode);
      Console.WriteLine(this.name  + " completed a mission.");
      Console.WriteLine(this.name + "'s completed missions: " + this.completedMissions);
    }
  }
}