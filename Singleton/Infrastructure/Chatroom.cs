namespace Singleton.Infrastructure
{
    public class Chatroom
    {
        static Chatroom _instance = null!;
        readonly List<string> _chatLog = [];
        readonly HashSet<ChatMember> _members = [];
        Chatroom() { }

        public static Chatroom GetInstance() => _instance ??= new Chatroom();

        public void AddMember(ChatMember member)
        {
            if (false == _members.Contains(member))
            {
                _members.Add(member);
                Console.WriteLine($"{member.Username} joined the chat.");
            }
            else
            {
                Console.WriteLine($"{member.Username} already in the chat.");
            }
        }

        public void SendMessage(ChatMember sender, string message)
        {
            if (false == _members.Contains(sender))
            {
                Console.WriteLine($"{sender.Username} is not a member of the chatroom. Add member first.");
                return;
            }

            Console.WriteLine($"{sender.Username}: {message}");
            _chatLog.Add($"{sender.Username}: {message}");
        }

        public void ShowChatLog()
        {
            Console.WriteLine("Chat Log:");

            foreach (var entry in _chatLog)
                Console.WriteLine(entry);
        }

        public List<ChatMember> GetMembers() => [.. _members];
    }
}
