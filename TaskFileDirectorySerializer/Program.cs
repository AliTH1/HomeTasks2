using Newtonsoft.Json;

string path = @"C:\\Users\\alita\\source\\repos\\TaskFileDirectorySerializer\\";
Directory.CreateDirectory(path + @"\\Models");
Directory.CreateDirectory(path + @"\\Data");


if (!File.Exists(path + @"\\Data\\jsonData.json"))
{
    File.Create(path + @"\\Data\\jsonData.json");
}


string jsonData = @"C:\\Users\\alita\\source\\repos\\TaskFileDirectorySerializer\\Data\\jsonData.json";
string url = @"https://jsonplaceholder.typicode.com/posts";
HttpClient httpClient = new HttpClient();
string result = await httpClient.GetStringAsync(url);
string jsonSerialized = JsonConvert.SerializeObject(result);


using (StreamWriter sw = new(jsonData))
{
    sw.WriteLine(jsonSerialized);
}