<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Namespace>System.Net.Http</Namespace>
</Query>

string url = "https://localhost:44344/api/order/";
HttpClient client = new HttpClient();
var response = await client.GetAsync(url);
string status = response.StatusCode.ToString();
int status_code = (int)response.StatusCode;
string result = response.Content.ReadAsStringAsync().Result;
Console.WriteLine($"[{status_code}: {status}]: {result}");