using classes;

/* Console.WriteLine("What is your name?");
String userName = Console.ReadLine();

Console.Clear();

Messages.SendGreetings(userName);
Messages.Wait();
Messages.SayGoodBye(userName); */

Console.WriteLine("Welcome agent.\nWhat is your name?");
String agentName = Console.ReadLine();
Console.WriteLine("What is your biological sex?");
String agentSex = Console.ReadLine();

Agents agent = new Agents(agentName, agentSex);
agent.GoOnAMission();

while (agent.active) {
  Console.WriteLine("Hello, " + agent.name);
  Console.WriteLine("What is your desired action?\n\tGo On A Mission(1) Deactivate(2)");
  String desiredAction = Console.ReadLine();

  if (desiredAction == "1") {
    agent.GoOnAMission();
  } else {
    agent.active = false;
  }
}

Console.WriteLine("OUT, " + agent.name + ".");