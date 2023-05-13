﻿# Модуль 18. Шаблоны и паттерны. GoF, SOLID. Часть 2

## Другие популярные порождающие паттерны

### СТРОИТЕЛЬ (BUILDER)
Builder - порождающий паттерн, значительно упрощающий создание сложных объектов. Он позволяет создавать объекты пошагово, используя один и тот же код для получения разных представлений объекта. 
Иначе говоря, процесс создания объекта инкапсулируется и разбивается на этапы.

Когда он нужен:
- Если процесс создания не должен зависеть от составных частей, из которых будет создан объект. А также от связей этих частей между собой.
- Если в процессе создания может понадобиться получить различные вариации объекта.

Представьте, что у вас есть сложный объект. Создавать его придется пошагово, инициализировать множество полей, некоторые из которых являются сложными вложенными объектами.
Здесь у вас два пути: либо спрятать код инициализации внутри конструктора объекта, получив раздутый многоэтажный код, либо (ещё хуже) создать дефолтный объект в клиентском коде, а потом оттуда ему проставлять все нужные свойства, поля и конфигурацию.

[Пример паттерна Builder 1](https://github.com/SkillfactoryCoding/PatternsModule_2/tree/main/BuilderExample)

Пример использования паттерна Builder для создания рассылок с HTML кодом. При этом письма должны иметь нормальную разметку и вёрстку, красиво смотреться как в браузере, так и мобильном приложении. В связи с этим сейчас часто используют специальные шаблоны для рассылок, содержащие HTML-разметку, прямо как обычные веб-страницы.
Чтобы генерировать письмо на основании шаблона с разметкой, часто пользуются шаблонизаторами, причем они должны работать сразу с несколькими шаблонами под разные типы писем.
[Пример паттерна Builder 2](https://github.com/SkillfactoryCoding/PatternsModule_2/tree/main/BuilderRealExample)
[Пример паттерна Builder 3](https://github.com/SkillFactory-CSARP/PatternsModule_2/tree/main/BuilderTask)

### ПРОТОТИП (PROTOTYPE)
Prototype - этот паттерн позволяет копировать уже имеющиеся объекты, а если точнее, позволяет это делать самим объектам.
При этом копирование возможно для объектов любой сложности. Подробности реализации копируемого объекта при этом не важны.

Когда используется:
- Если нам надо динамически определять тип создаваемого объекта во время выполнения и убрать его зависимость от копируемого объекта.
- Если клонирование объекта для нас предпочтительнее, чем его создание и инициализация в конструкторе. Особенно удобно, когда мы знаем, что объект способен принимать небольшое ограниченное количество возможных состояний.

[Пример реализации паттерна Prototype 1](https://github.com/SkillfactoryCoding/PatternsModule_2/tree/main/PrototypeExample)
[Пример реализации паттерна Prototype 2](https://github.com/SkillfactoryCoding/PatternsModule_2/tree/main/PrototypeRealExample)

## Другие популярные поведенческие паттерны

### КОМАНДА (COMMAND)
Command - этот поведенческий паттерн позволяет превратить запросы в объекты и передавать их потом как аргументы при вызове методов.
Можно ставить запросы в очередь, отслеживать в логах. Также, если необходимо, можно их отменять.
Командой при этом и является сам запрос на выполнение определенного действия. Ещё одно преимущество состоит в том, что команды могут использоваться разными объектами. К ним может быть открыт доступ из разных, не зависящих друг от друга мест программы.
Пример реализации данного паттерна у вас перед глазами, например, когда вы используете текстовый редактор Word. 

Допустим, вам нужно сохранить текст в файл, и вы можете сделать это несколькими способами: выбрать пункт Меню → Сохранить, нажать Ctrl +S, либо вообще включить автосохранение. Во всех этих случаях в качестве клиента (того, кто запускает команду) могут выступать разные классы. Это может быть как пользовательский интерфейс кнопки (как в случае с меню), так и обработчик нажатия на клавиатуру (в случае с Ctrl+S) и так далее.
Во всех этих случаях вы из разных мест интерфейса запускаете одну и ту же команду на сохранение информации в файл. 

Команды могут также использоваться с различными параметрами, передающими информацию.

Когда используется:
 - Нужно передать в виде параметров какие-то действия, и в ответ мы должны получить другие действия. То есть нужно получить обратный ответ.
 - Нужна очередь запросов, а также возможность их отмены.
 - Нужно контролировать изменения в логах и отслеживать поведение системы. Это также поможет восстановить систему в случае сбоев.

[Пример реализации паттерна Command 1](https://github.com/SkillfactoryCoding/PatternsModule_2/tree/main/CommandExample)

### СТРАТЕГИЯ (STRATEGY)
Под Стратегией здесь понимается некий набор (или семейство) схожих алгоритмов, которые помещаются (инкапсулируются) в классе, и могут потом взаимозаменяться во время исполнения программы.
В зависимости от ситуации мы можем заменить один другим, при этом замена может произойти совершенно независимо от объекта, который алгоритм использует.

Когда используется:
 - Есть несколько похожих родственных классов, отличающихся поведением. Тогда можно сделать один основной класс, а эти различающиеся варианты поведения вынести в отдельные классы, и применять по мере необходимости.
 - Есть несколько вариантов алгоритмов, которые можно менять в зависимости от условий.
 - Во время выполнения программы нужно менять поведение объектов.
 - Класс, в котором определен функционал, не должен ничего знать о реализации.

[Пример реализации паттерна Strategy 1](https://github.com/SkillfactoryCoding/PatternsModule_2/tree/main/StrategyExample)
[Пример реализации паттерна Strategy 2](https://github.com/SkillfactoryCoding/PatternsModule_2/tree/main/StrategyRealExample)


