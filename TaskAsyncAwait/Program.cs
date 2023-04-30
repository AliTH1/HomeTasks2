using System.Diagnostics;
using TaskAsyncAwait.Models;
using TaskAsyncAwait.Utilities.Enum;


#region Task 1
//string[] urls =
//{
//    "https://docs.microsoft.com",
//    "https://docs.microsoft.com/aspnet/core",
//    "https://docs.microsoft.com/azure",
//    "https://docs.microsoft.com/azure/devops",
//    "https://docs.microsoft.com/dotnet",
//    "https://docs.microsoft.com/dynamics365",
//    "https://docs.microsoft.com/education",
//    "https://docs.microsoft.com/enterprise-mobility-security",
//    "https://docs.microsoft.com/gaming",
//    "https://docs.microsoft.com/graph",
//    "https://docs.microsoft.com/microsoft-365",
//    "https://docs.microsoft.com/office",
//    "https://docs.microsoft.com/powershell"
//};

//GetHttpContents();

//void GetHttpContents()
//{
//    HttpClient httpClient = new HttpClient();

//    Stopwatch stopwatch = new Stopwatch();

//    stopwatch.Start();
//    foreach (string url in urls)
//    {
//        string result = httpClient.GetStringAsync(url).Result;
//        Console.WriteLine(result.Length);
//    }
//    stopwatch.Stop();

//    Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds);
//}


//await GetHttpContentsAsync();
//async Task GetHttpContentsAsync()
//{
//    HttpClient httpClient = new HttpClient();
//    List<Task<string>> list = new List<Task<string>>();

//    foreach (string url in urls)
//    {
//        var result = httpClient.GetStringAsync(url);
//        list.Add(result);
//    }

//    string[] list2 = await Task.WhenAll(list);
//    Stopwatch stopwatch = new Stopwatch();

//    stopwatch.Start();
//    foreach (string url in list2)
//    {
//        Console.WriteLine(url.Length);
//    }

//    stopwatch.Stop();

//    Console.WriteLine("Time: " + stopwatch.ElapsedMilliseconds + "ms");
//}
#endregion


#region Task2.1

Weapon m4 = new Weapon("Medium-Caliber", 30);
Console.WriteLine("Choose what you want to do: ");
Console.WriteLine("1) Fire");
Console.WriteLine("2) Fill");
Console.WriteLine("3) Pull Trigger");
int answer = Convert.ToInt32(Console.ReadLine());

if (answer == (int)Choise.Fire)
{
    m4.Fire();
}
else if (answer == (int)Choise.Fill)
{
    Console.Write("Enter bullet: ");
    string answer2 = Console.ReadLine();
    Bullet bullet = new(answer2);
    m4.Fill(bullet);
}
else if (answer == (int)Choise.PullTrigger)
{
    m4.PullTrigger();
}

#endregion