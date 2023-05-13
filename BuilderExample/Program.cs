using BuilderExample;

/* Пример использования паттерна Builder
 * Допустим, у нас сложный объект, и создаваться он должен в несколько этапов.
 * 1. Создадим общий интерфейс Строителя (IBuilder),
 *    который будет содержать методы для нужных нам этапов.
 * 2. Сам сложный составной объект, который потребуется создавать (Product).
 * 3. Конкретная реализация Строителя (ProductBuilder).
 * 4. Класс, который будет скрывать ненужные детали постройки объекта
 *    от клиента (BuildManager).
 * 5. Использование билдера в клиентском коже (Mainб ниже). 
 */

// Инициализация строителя
IBuilder builder = new ProductBuilder();

// Создаем менеджера, который будет рулить процессом
BuildManager buildManager = new BuildManager(builder);

// Стартуем и получаем результат
buildManager.StartBuildingProcess();
Product product = builder.GetBuildingResult();

Console.ReadKey();