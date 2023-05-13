using System;
namespace BuilderHtmlMailExample
{
    /// <summary>
    /// Строитель #1 для создания приветственной рассылки
    /// </summary>
    public class WelcomeTemplateBuilder : TemplateBuilder
	{
        public override void BuildHeader()
        {
            Template.Header = new Header { Text = "Здравствуйте!" };
        }

        public override void BuildBody()
        {
            Template.Body = new Body { Text = "Спасибо за регистрацию в нашем приложении" };
        }

        public override void BuildFooter()
        {
            // не используется
        }
    }
}

