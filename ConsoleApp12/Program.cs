using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var botClient = new TelegramBotClient("5662965815:AAF0PzwZlWOO8QtzC89zTe5fOxxvqoGe4zA");

        using var cts = new CancellationTokenSource();

        var receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = { }
        };

        botClient.StartReceiving(HandleUpdatesAsync, HandleErrorAsync,receiverOptions,  cancellationToken: cts.Token);  

        Task HandleErrorAsync(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }

        var me = await botClient.GetMeAsync();


        Console.ReadLine();

        cts.Cancel();

        async Task HandleUpdatesAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == UpdateType.Message && update?.Message?.Text != null)
            {
                await HandleMessage(botClient, update.Message);
                return;
            }

        }

        async Task HandleMessage(ITelegramBotClient botClient, Message message)
        {


            if (message.Text.ToLower() == "/start")
            {
                ReplyKeyboardMarkup keyboard = new(new[]
                {
            new KeyboardButton[] { "карта геншину", "симулятор круток"},
            new KeyboardButton[] { "зборки на персонажів", "паймон мое"},
        })
                {
                    ResizeKeyboard = true
                };
                await botClient.SendTextMessageAsync(message.Chat.Id, "Виберіть про що ви хочете знайти інформацію", replyMarkup: keyboard);


                return;
            }
            else if (message.Text.ToLower() == "карта геншину")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshin-impact-map.appsample.com/#/");

                return;
            }
            else if (message.Text.ToLower() == "симулятор круток")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshindb.ru/simulyator-molitv/");

                return;
            }
            else if (message.Text.ToLower() == "паймон мое")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://paimon.moe/");

                return;
            }
            else if (message.Text.ToLower() == "зборки на персонажів")
            {
                ReplyKeyboardMarkup keyboard = new(new[]
                {

            new KeyboardButton[] { "Стрілецьке", "Одноручне", "Каталізатор", "Дворучне","Древкове"},
        })
                {
                    ResizeKeyboard = true
                };
                await botClient.SendTextMessageAsync(message.Chat.Id, "Виберіть тип зброї персонажа", replyMarkup: keyboard);

                return;
            }
            else if (message.Text.ToLower() == "стрілецьке")
            {
                ReplyKeyboardMarkup keyboard = new(new[]

                {   new KeyboardButton[] { "зборки на персонажів"},
            new KeyboardButton[] { "діона", "еїмія", "ембер"},
            new KeyboardButton[] { "е лань", "колеї", "сара"},
            new KeyboardButton[] { "тарталья", "венті", "гань юй"},
            new KeyboardButton[] { "горо", "тігнарі", "фішль", "елой"},

        })
                {
                    ResizeKeyboard = true
                };
                await botClient.SendTextMessageAsync(message.Chat.Id, "Виберіть персонажа", replyMarkup: keyboard);
                await botClient.SendTextMessageAsync(message.Chat.Id, "Щоб повернутися на вибір зброї персонажів нажміть на зборки на персонажів", replyMarkup: keyboard);

                return;
            }
            else if (message.Text.ToLower() == "одноручне")
            {
                ReplyKeyboardMarkup keyboard = new(new[]
                {
            new KeyboardButton[] { "зборки на персонажів"},
            new KeyboardButton[] { "альбедо", "аяка", "аято"},
            new KeyboardButton[] { "беннет", "джин", "кадзуха"},
            new KeyboardButton[] { "ке цин", "кейя", "нілу"},
            new KeyboardButton[] { "мандрівник", "син цю", "синобу", "ци ци"},

        })
                {
                    ResizeKeyboard = true
                };
                await botClient.SendTextMessageAsync(message.Chat.Id, "Виберіть персонажа", replyMarkup: keyboard);
                await botClient.SendTextMessageAsync(message.Chat.Id, "Щоб повернутися на вибір зброї персонажів нажміть на зборки на персонажів", replyMarkup: keyboard);

                return;
            }
            else if (message.Text.ToLower() == "каталізатор")
            {
                ReplyKeyboardMarkup keyboard = new(new[]
                {
            new KeyboardButton[] { "зборки на персонажів"},
            new KeyboardButton[] { "барбара", "клі", "кокоми"},
            new KeyboardButton[] { "лиза", "мона", "нин гуан"},
            new KeyboardButton[] { "сахароза", "янь фэй", "яэ мико", "хэйдзо"},

        })
                {
                    ResizeKeyboard = true
                };
                await botClient.SendTextMessageAsync(message.Chat.Id, "Виберіть персонажа", replyMarkup: keyboard);
                await botClient.SendTextMessageAsync(message.Chat.Id, "Щоб повернутися на вибір зброї персонажів нажміть на зборки на персонажів", replyMarkup: keyboard);

                return;
            }
            else if (message.Text.ToLower() == "древкове")
            {
                ReplyKeyboardMarkup keyboard = new(new[]
                {
            new KeyboardButton[] { "зборки на персонажів"},
            new KeyboardButton[] { "кандакія", "райден", "розарія"},
            new KeyboardButton[] { "сайно", "сян лін", "сяо"},
            new KeyboardButton[] { "тома", "ху тао", "чжун лі"},
            new KeyboardButton[] { "шень хе", "юнь цзінь"},

        })
                {
                    ResizeKeyboard = true
                };
                await botClient.SendTextMessageAsync(message.Chat.Id, "Виберіть персонажа", replyMarkup: keyboard);
                await botClient.SendTextMessageAsync(message.Chat.Id, "Щоб повернутися на вибір зброї персонажів нажміть на зборки на персонажів", replyMarkup: keyboard);

                return;
            }
            else if (message.Text.ToLower() == "дворучне")
            {
                ReplyKeyboardMarkup keyboard = new(new[]
                {
            new KeyboardButton[] { "зборки на персонажів"},
            new KeyboardButton[] { "бей доу", "ділюк", "дорі"},
            new KeyboardButton[] { "ітто", "ноель", "рейзор"},
            new KeyboardButton[] { "саю", "синь янь", "чун юнь","еола"},

        })
                {
                    ResizeKeyboard = true
                };
                await botClient.SendTextMessageAsync(message.Chat.Id, "Виберіть персонажа", replyMarkup: keyboard);
                await botClient.SendTextMessageAsync(message.Chat.Id, "Щоб повернутися на вибір зброї персонажів нажміть на зборки на персонажів", replyMarkup: keyboard);

                return;
            }
            else if (message.Text.ToLower() == "бей доу")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/behj-dou/ ");

                return;
            }
            else if (message.Text.ToLower() == "ділюк")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/dilyuk/ ");

                return;
            }
            else if (message.Text.ToLower() == "дорі")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/dori/ ");

                return;
            }
            else if (message.Text.ToLower() == "ітто")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/arataki-itto/ ");

                return;
            }
            else if (message.Text.ToLower() == "ноель")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/noehll/ ");

                return;
            }
            else if (message.Text.ToLower() == "рейзор")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/rehjzor/ ");

                return;
            }
            else if (message.Text.ToLower() == "саю")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/sayu/ ");

                return;
            }
            else if (message.Text.ToLower() == "синь янь")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/sin-yan/ ");

                return;
            }
            else if (message.Text.ToLower() == "чун юнь")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/chun-yun/ ");

                return;
            }
            else if (message.Text.ToLower() == "еола")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/ehola/ ");

                return;
            }
            else if (message.Text.ToLower() == "барбара")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/barbara/ ");

                return;
            }
            else if (message.Text.ToLower() == "клі")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/kli/");

                return;
            }
            else if (message.Text.ToLower() == "кокоми")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/kokomi/");

                return;
            }
            else if (message.Text.ToLower() == "лиза")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/liza/");

                return;
            }
            else if (message.Text.ToLower() == "мона")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/mona/ ");

                return;
            }
            else if (message.Text.ToLower() == "нин гуан")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/nin-guan/ ");

                return;
            }
            else if (message.Text.ToLower() == "сахароза")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/saharoza/ ");

                return;
            }
            else if (message.Text.ToLower() == "янь фэй")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/yanfehj/ ");

                return;
            }
            else if (message.Text.ToLower() == "яэ мико")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/yae-miko/ ");

                return;
            }
            else if (message.Text.ToLower() == "хэйдзо")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/sikanoin-hehjdzo/ ");

                return;
            }
            else if (message.Text.ToLower() == "кандакія")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/kandakia/ ");

                return;
            }
            else if (message.Text.ToLower() == "райден")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/syogun-rajdehn/ ");

                return;
            }
            else if (message.Text.ToLower() == "розарія")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/rozariya/");

                return;
            }
            else if (message.Text.ToLower() == "сайно")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/cyno/ ");

                return;
            }
            else if (message.Text.ToLower() == "сян лін")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/syan-lin/");

                return;
            }
            else if (message.Text.ToLower() == "сяо")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/syao/");

                return;
            }
            else if (message.Text.ToLower() == "тома")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/toma/");

                return;
            }
            else if (message.Text.ToLower() == "ху тао")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/hu-tao/ ");

                return;
            }
            else if (message.Text.ToLower() == "чжун лі")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/chzhun-li/ ");

                return;
            }
            else if (message.Text.ToLower() == "шень хе")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/shenh-he/ ");

                return;
            }
            else if (message.Text.ToLower() == "юнь цзінь")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/yun-czin/ ");

                return;
            }
            else if (message.Text.ToLower() == "альбедо")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/albedo/ ");

                return;
            }
            else if (message.Text.ToLower() == "аяка")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/ayaka/");

                return;
            }
            else if (message.Text.ToLower() == "аято")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/kamisato-ayato/");

                return;
            }
            else if (message.Text.ToLower() == "беннет")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/bennet/");

                return;
            }
            else if (message.Text.ToLower() == "джин")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/dzhinn/ ");

                return;
            }
            else if (message.Text.ToLower() == "кадзуха")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/kazuha/ ");

                return;
            }
            else if (message.Text.ToLower() == "ке цин")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/keh-cin/ ");

                return;
            }
            else if (message.Text.ToLower() == "кейя")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/keja/ ");

                return;
            }
            else if (message.Text.ToLower() == "нілу")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/nilu/ ");

                return;
            }
            else if (message.Text.ToLower() == "мандрівник")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/puteshestvennik-anemo/ ");
                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/puteshestvennik-geo/ ");
                return;
            }
            else if (message.Text.ToLower() == "син цю")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/sin-cyu/ ");

                return;
            }
            else if (message.Text.ToLower() == "синобу")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/kuki-sinobu/ ");

                return;
            }
            else if (message.Text.ToLower() == "ци ци")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/ci-ci/");

                return;
            }
            else if (message.Text.ToLower() == "діона")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/diona/ ");

                return;
            }
            else if (message.Text.ToLower() == "еїмія")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/yoimiya/");

                return;
            }
            else if (message.Text.ToLower() == "ембер")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/amber/");

                return;
            }
            else if (message.Text.ToLower() == "е лань")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/yelan/");

                return;
            }
            else if (message.Text.ToLower() == "колеї")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/kollei/ ");

                return;
            }
            else if (message.Text.ToLower() == "сара")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/sara-kudzyo/ ");

                return;
            }
            else if (message.Text.ToLower() == "тарталья")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/tartalya/ ");

                return;
            }
            else if (message.Text.ToLower() == "венті")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/venti/ ");

                return;
            }
            else if (message.Text.ToLower() == "гань юй")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/gan-yuj/ ");

                return;
            }
            else if (message.Text.ToLower() == "горо")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/goro/ ");

                return;
            }
            else if (message.Text.ToLower() == "тігнарі")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/tignari/ ");

                return;
            }
            else if (message.Text.ToLower() == "фішль")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/fishl/ ");

                return;
            }
            else if (message.Text.ToLower() == "елой")
            {

                await botClient.SendTextMessageAsync(message.Chat.Id, "https://genshinpedia.ru/aloy/ ");

                return;
            }
        }
    }
}