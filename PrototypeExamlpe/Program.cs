using PrototypeExamlpe;

/// Клиентский код, использующий прототип

// Создаем первый конкретный объект по прототипу
Prototype prototype = new ClassOne(id: 1);
// Клонируем
Prototype clone = prototype.Clone();

// Создаем второй конкретный объект по прототипу
prototype = new ClassTwo(id: 2);
// Клонируем
clone = prototype.Clone();

Console.ReadKey();