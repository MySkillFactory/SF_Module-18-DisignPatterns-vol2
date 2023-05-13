using CommandExample;

// Пример реализации паттерна Command

// создадим отправителя
var sender = new Sender();

// создадим получателя
var receiver = new Receiver();

// создадим команду
var commandOne = new CommandOne(receiver);

// инициализация команды
sender.SetCommand(commandOne);

//  выполнение
sender.Run();

Console.ReadKey();