// See https://aka.ms/new-console-template for more information
using Singleton.Infrastructure;

var chatroom = Chatroom.GetInstance();

var mike = new ChatMember("Mike");
var john = new ChatMember("John");

chatroom.SendMessage(mike, "Hello, world!");

chatroom.AddMember(mike);
chatroom.AddMember(john);

chatroom.SendMessage(mike, "Is anybody here?");
chatroom.SendMessage(john, "Oh, hello there!");

var members = chatroom.GetMembers().Select(m => m.Username).Aggregate((un1, un2) => un1 + ',' + un2);

Console.WriteLine($"Chatroom members: {members}.");

chatroom.ShowChatLog();
