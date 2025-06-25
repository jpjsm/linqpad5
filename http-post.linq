<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Namespace>System.Net.Http</Namespace>
</Query>

string url = "https://localhost:44344/api/order/";
string data = "{\"ItemIds\":[\"1\", \"5\"], \"Currency\": \"USD\"}";
Console.WriteLine(data);
StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
HttpClient client = new HttpClient();

var response = await client.PostAsync(url, content);

string status = response.StatusCode.ToString();
int status_code = (int)response.StatusCode;
var headers = response.Headers.ToDictionary(k => k.Key.ToString(), d => string.Join(", ", d.Value));
Console.WriteLine("Headers:");
foreach (var kvp in headers)
{
	Console.WriteLine($"    {kvp.Key}: {kvp.Value}");
}
var result = await response.Content.ReadAsStringAsync();
Console.WriteLine($"[{status_code}: {status}]: {result}");
