using Newtonsoft.Json;

string path = @"C:\\Users\\alita\\source\\repos\\TaskFileDirectorySerializer\\";
Directory.CreateDirectory(path + @"\\Models");
Directory.CreateDirectory(path + @"\\Data");


if (!File.Exists(path + @"\\Data\\jsonData.json"))
{
    File.Create(path + @"\\Data\\jsonData.json");
}

if (!File.Exists(@"C:\\Users\\alita\\source\\repos\\TaskFileDirectorySerializer\\Models\\CustomObject.cs"))
{
    File.Create(@"C:\\Users\\alita\\source\\repos\\TaskFileDirectorySerializer\\Models\\CustomObject.cs");
}


HttpClient httpClient = new HttpClient();
string jsonData = @"C:\\Users\\alita\\source\\repos\\TaskFileDirectorySerializer\\Data\\jsonData.json";
string url = "https://jsonplaceholder.typicode.com/posts";
string result = await httpClient.GetStringAsync(url);
List<CustomObject> customObjects = JsonConvert.DeserializeObject<List<CustomObject>>(result);

using (StreamWriter sw = new(jsonData))
{
    sw.WriteLine(JsonConvert.SerializeObject(customObjects));
}
