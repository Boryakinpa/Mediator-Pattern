using MediatorPattern;
internal class Program
{
    private static void Main(string[] args)
    {
        User admin = new ConcreteUser("Админ");
        User user = new ConcreteUser("Пользователь");
        ChatMediator mediator = new ConcreteChatMediator();
        admin.connectChat(mediator);
        user.connectChat(mediator);
        admin.sendMessage("для пользователя", user);
        admin.sendMessage("для пользователя ещё раз", user);
        Console.WriteLine();
        user.showHistory();
    }
}