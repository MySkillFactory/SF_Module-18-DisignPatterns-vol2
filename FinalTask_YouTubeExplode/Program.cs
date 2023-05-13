using FinalTask_YouTubeExplode.Models;
using FinalTask_YouTubeExplode.Commands;

/* Видео для тестов:
 * Короткое https://youtu.be/li0l59nP3L8
 * Длинное https://youtu.be/dQw4w9WgXcQ
 */

while (true)
{
    Start();
}


static void Start()
{
    Console.Write("Введите URL адрес Youtube видео: ");
    string url = Console.ReadLine();

    if (url != string.Empty)
    {
        Menu(url);
    }
    else
        Restart();
}

/// <summary>
/// Отрисовка меню
/// </summary>
static void Menu(string url)
{
    Console.WriteLine();
    Console.WriteLine("Выберите пункт меню (введите 1,2 или 3):");
    Console.WriteLine(
        " 1. Получить информацию о видеоролике\n" +
        " 2. Скачать видеоролик\n" +
        " 3. Вернуться к вводу URL адреса\n");

    while (true)
    {
        var menuValue = Console.ReadKey();
        Console.WriteLine();

        if (menuValue.KeyChar == '1' || menuValue.KeyChar == '2')
        {
            GetToolsAsync(menuValue.KeyChar, url);
            break;
        }
        else if (menuValue.KeyChar == '3')
        {
            Restart();
        }
        else
            Console.WriteLine($" Ошибка ввода!");
    }
}

/// <summary>
/// Метод вызова команд в зависимости от выбранного пункта меню
/// </summary>
static async Task GetToolsAsync(char menuValue, string url)
{
    CommandSender sender = new();
    VideoTools video = new(url);
    sender.SetAction(new Command(video));

    switch (menuValue)
    {
        case '1':
            // Запуск команды
            await sender.GetInfoVideo();
            // Ожидание
            await Wait();
            break;

        case '2':
            Console.WriteLine("Видео скачивается...");
            // Запуск команды
            await sender.DownLoadVideo();
            // Ожидание
            await Wait();
            break;
    }

    Console.WriteLine();
    Menu(url);
}

static void Restart()
{
    Console.Clear();
    Start();
}

/// <summary>
/// Метод ожидания для вывода нового меню
/// </summary>
static async Task Wait()
{
    // Сюда можно добавить прогрессию скачивания файла
    do { Task.Delay(1000); }
    while (Flag.Status == false);

    // Выключаем флаг (команды отработали)
    Flag.Status = false;
}