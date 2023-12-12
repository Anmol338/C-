using DateTimeTest;
using MySqlConnector;

DateTime currentDateTime = DateTime.Now;
string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
Console.WriteLine("Current date and time: " + formattedDateTime); 
string date = currentDateTime.ToString("yyyy-MM-dd");
Console.WriteLine("Current date : " + formattedDateTime);
string time = currentDateTime.ToString("HH:mm:ss");
Console.WriteLine("Current time: " + formattedDateTime);

bool result = new CRUD().Insert("Test", date, time);

if (result)
{
    Console.WriteLine("Data Inserted successfully!!");
}
else
{
    Console.WriteLine("Failed to insert data");
}