// See https://aka.ms/new-console-template for more information
Console.WriteLine("Student Information Form");
String name = "User";
Console.WriteLine($"Welcome {name} to the Simple Form Letter Generator.");
Console.WriteLine($"Please provide the following information to create your letter:");

string recipient = "Bob Smith";
Console.WriteLine("Enter the recipient's full name:");
recipient = Console.ReadLine();

Console.WriteLine("Enter your full name:");
name = Console.ReadLine();

string subject = "Cwik";
Console.WriteLine("Enter the subject of the letter:");
subject = Console.ReadLine();

string project = "Cwik";
Console.WriteLine("Enter the specific task or project that you are discussing:");
project = Console.ReadLine();

string followup = "Cwik";
Console.WriteLine("Enter a follow-up date:");
followup = Console.ReadLine();
Console.WriteLine($"              ");
Console.WriteLine($"Generating your leter...");

Console.WriteLine($"              ");
DateTime currentDate = DateTime.Today;
Console.WriteLine($"{currentDate}");
Console.WriteLine($"              ");
Console.WriteLine($"To: {recipient}");
Console.WriteLine($"              ");
Console.WriteLine($"Dear, {recipient}");
Console.WriteLine($"              ");
Console.WriteLine($"Subject: {subject}");
Console.WriteLine($"              ");
Console.WriteLine($"I am writing you today to discuss the ongoing project of {project} and {subject}");
Console.WriteLine($"              ");
Console.WriteLine($"We expect the phase to be completed by {followup}.");
Console.WriteLine($"              ");
Console.WriteLine($"Don't hesitiate to reach out if you have any questions or concerns.");
Console.WriteLine($"              ");
Console.WriteLine($"Dear,");
Console.WriteLine($"{name}");
Console.WriteLine($"              ");
Console.WriteLine($"Your letter has been generated, you may now close this window.");

