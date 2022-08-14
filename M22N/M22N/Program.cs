// See https://aka.ms/new-console-template for more information
using MongoDB.Bson;
using MongoDB.Driver;

Console.WriteLine("Hello, World!");
var mongoClient = new MongoClient("mongodb+srv://xeeraki:elephantBIG86@mflix.j1qqk.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
var databse = mongoClient.GetDatabase("sample_mflix");
var data = databse.GetCollection<BsonDocument>("movies");

var result = data.Find(new BsonDocument())
    .SortByDescending(m => m["runtime"])
    .Limit(10)
    .ToList();


foreach(var item in result)
{
    Console.WriteLine(item.GetValue("title"));
}

