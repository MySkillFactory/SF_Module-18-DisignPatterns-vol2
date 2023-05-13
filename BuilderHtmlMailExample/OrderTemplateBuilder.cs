using System;
namespace BuilderHtmlMailExample
{
    /// <summary>
    /// Строитель #2 для создания рассылки о заказе
    /// </summary>
    public class OrderTemplateBuilder : TemplateBuilder
    {
        public override void BuildHeader()
        {
            Template.Header = new Header { Text = "Здравствуйте, спасибо за заказ!" };
        }
        public override void BuildBody()
        {
            this.Template.Body = new Body { Text = "Ваш номер заказа - 534" };
        }

        public override void BuildFooter()
        {
            this.Template.Footer = new Footer()
            {
                Text = "OOO ЛучшийСервис, contact@bestservice.ru"
            };
        }
    }
}

