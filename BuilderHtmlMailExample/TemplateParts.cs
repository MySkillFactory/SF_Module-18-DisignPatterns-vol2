using System;
namespace BuilderHtmlMailExample
{
    /// <summary>
    /// Заголовок письма
    /// </summary>
    public class Header
    {
        public string Text { get; set; }
    }

    /// <summary>
    /// Нижний колонтитул
    /// </summary>
    public class Footer
    {
        public string Text { get; set; }
    }

    /// <summary>
    /// Тело письма
    /// </summary>
    public class Body
    {
        public string Text { get; set; }
    }
}

