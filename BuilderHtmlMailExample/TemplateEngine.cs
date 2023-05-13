using System;
namespace BuilderHtmlMailExample
{
    /// <summary>
    /// Движок шаблонизатора
    /// </summary>
    public class TemplateEngine
	{
        /// <summary>
        /// Метод поэтапной генерации шаблона рассылки
        /// </summary>
        public Template GenerateTemplate(TemplateBuilder templateBuilder)
		{
            templateBuilder.CreateTemplate();

            templateBuilder.BuildHeader();
            templateBuilder.BuildBody();
            templateBuilder.BuildFooter();

            return templateBuilder.Template;
		}
	}
}

