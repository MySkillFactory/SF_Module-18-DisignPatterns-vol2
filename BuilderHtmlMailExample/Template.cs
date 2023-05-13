using System.Text;
using System.Reflection.PortableExecutable;

namespace BuilderHtmlMailExample
{
    /// <summary>
    /// Шаблон письма
    /// </summary>
    public class Template
	{
        // заголовок
        public Header Header { get; set; }

        // тело
        public Body Body { get; set; }

        // футер, или нижный колонтитул
        public Footer Footer { get; set; }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            if (Header != null)
                text.Append(Header.Text + Environment.NewLine);

            if (Body != null)
                text.Append(Body.Text + Environment.NewLine);

            if (Footer != null)
                text.Append(Footer.Text + Environment.NewLine);

            return text.ToString();
        }
    }
}

