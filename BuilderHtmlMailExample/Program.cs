using BuilderHtmlMailExample;

// Создаем движок шаблонизатора
TemplateEngine templateEngine = new TemplateEngine();

// Создаем шаблонизатор для приветственной рассылки
TemplateBuilder builder = new WelcomeTemplateBuilder();

// Генерируем  приветственное письмо с текстом
Template greetingsTemplate = templateEngine.GenerateTemplate(builder);
Console.WriteLine(greetingsTemplate.ToString());

// Переопределяем шаблонизатор для рассылки с номером заказа
builder = new OrderTemplateBuilder();

// Генерируем  письмо  с номером заказа
Template ordertemplate = templateEngine.GenerateTemplate(builder);
Console.WriteLine(ordertemplate.ToString());



Console.ReadKey();