using System.Collections.Generic;
using System;
using static System.Console;
namespace Реализация_QTE
{
    interface IRobbery
    {
        //ноги, голова, тело
        public string Name { get; set; }
        public bool Legs { get; set; }
        public bool Head { get; set; }
        public bool Body { get; set; }
        public void PrintHaracteristick();
    };
    //коммит
    class Pablo : IRobbery
    {
        public string Name { get; set; }

        public bool Legs { get; set; }
        public bool Head { get; set; }
        public bool Body { get; set; }

        public void PrintHaracteristick()
        {
            WriteLine("-==ВЫ==-");
            WriteLine($"Имя: {Name}");
            WriteLine($"Ноги: {Legs}");
            WriteLine($"Голова: {Head}");
            WriteLine($"Тело: {Body}");
        }

        public Pablo(string Name, bool Legs, bool Head, bool Body)
        {
            this.Name = Name;
            this.Legs = Legs;
            this.Head = Head;
            this.Body = Body;
        }
    };

    class Chikatalo : IRobbery
    {
        public string Name { get; set; }

        public bool Legs { get; set; }
        public bool Head { get; set; }
        public bool Body { get; set; }

        public void PrintHaracteristick()
        {
            WriteLine("\n-==СОЮЗНИК==-");
            WriteLine($"Имя: {Name}");
            WriteLine($"Ноги: {Legs}");
            WriteLine($"Голова: {Head}");
            WriteLine($"Тело: {Body}");
        }

        public Chikatalo(string Name, bool Legs, bool Head, bool Body)
        {
            this.Name = Name;
            this.Legs = Legs;
            this.Head = Head;
            this.Body = Body;
        }
    };

    internal class Program
    {
        public static void Story_1()
        {
            WriteLine("11 Апреля. 2004 год. Город мать его Saint Santoss. ул. Sanino. Дом 1488. \n");
            WriteLine("Dallas: Эх, задалбало меня это все, одни проблемы на носу, долги, с женой проблемы, так еще и эта передряга с бандитами, как хочется спокойной жизни");
            WriteLine("Sokol: Да братан, сам тебя понимаю, меня так вообще из дома выгнали, не на одну работу вообще не берут, в общем встряли мы с тобой ");
            WriteLine(" *ЗВУК УВЕДОМЛЕНИЯ НА ПОЧТЕ* ");
            WriteLine("Sokol: Опять наверное отправляют свои скидки на золотое яблоко, дай пойду посмотрю че там");
            WriteLine("Sokol: Слушай, тут какое то странное письмо от анонима");
            WriteLine("Dallas: Ну и че в нем написано? ");
            WriteLine("Sokol: Не может быть, он тут предлагает нам работу...  ");
            WriteLine("Dallas: Опять свои сокровища прятать предлагают? Сразу говорю я против этого ");
            WriteLine("Sokol: Да нет же, тут по серьезней дело, нам тут предлагают банк ограбить... ");
            WriteLine("Dallas: Че за бред!? И какая же в этом у нас выгода? Мне еще и не хватало за решетку сесть, заканчивай фигней маяться, пойдем лучше футбол посмотрим");
            WriteLine("Sokol: Да дослушай ты меня, нам заявляют что для нас все подготовят, и от украденной суммы мы получим 80% себе, а сумма денег которая лежит в банке это... ");
            WriteLine("Dallas: Что? Не томи уже, какая там сумма?");
            WriteLine("Sokol: *15000000$* ");
            WriteLine("Dallas: СКОЛЬКО!? Да это же можно купить себе целый особняк с бассейном на заднем дворе, много тачек, и даже вертолет ");
            WriteLine("Sokol: Да, но ты не о том думаешь. Мы спокойно можем погасить свои долги, и наконец закончить эти передряги с бандитами  ");
            WriteLine("Sokol: Ты как хочешь, но я согласен на все, лишь бы закончились эти проблемы в долгами");
            WriteLine("Dallas: Ладно брат, раз ты на такое готов, то и я с тобой");
            WriteLine("Dallas: Так че там, где он нам предлагает взять оружие и фургон для ограбления ");
            WriteLine("Sokol: Тут сказано что к нам подъедет какой то человек на фургоне его кстати зовут \"Марк\" сказано что он какой то немного странный, только в каком плане я не понимаю и там будет время на подготовку ");
            WriteLine("Sokol:А так нам только стоит придумать какие то прозвища что бы не распространять наши личности");
            WriteLine("Dallas: Хмм.. Ну у меня есть конечно идея, но для начала надо пойти спать");
            //Все пока на этом диалоге закончу
            // мафиози обсуждают свой план о ограблении, это начало
            // я короче ща подумаю как написать 

            // у меня вообще есть идея, о начале разговора в прицнипе, короче то что вот эти имена это их прозвища, короче типа они сидели дома, у одного там проблемы долги по горло и тд, и он второму предложил идею ограбить что нибудь, ну или второму в инете письмо пришло о предложении
        }
        public static void Story_2()
        {
            WriteLine("15 Апреля. ул. Perito. Bank89. В фургоне около банка ");
            WriteLine("Pablo: Ну что братан, вот мы и на месте, ты готов?");
            WriteLine("Chikatilo: *ЗВУК ПЕРЕЗАРЯДКИ* ");
            WriteLine("Chikatilo: Конечно готов, надеюсь наша жизнь после этого изменится в лучшую сторону");
            WriteLine("Pablo: Ну все, как я знаю на входе есть 2 охранника, надо будет действовать очень быстро, ибо вызовут копов и нам кранты");
            WriteLine("Chikatilo: Хорошо, ну тогда погнали?");
            WriteLine("Pablo: Да, погнали, кстати Марк, если что жди нас с задней стороны банка, мы выбежим от туда");
            WriteLine("Марк: ... ");
            WriteLine("Chikatilo: Мда, теперь я понимаю в каком плане он странный, ни слова не сказал нас за все время, ладно в общем погнали");
            WriteLine("Охраник1: *ЗВУК РАЦИИ* *ПРИЕМ*");
            WriteLine("Охраник1: Слушаю");
            WriteLine("Охраник2: Вижу неподалеку двух мужиков в масках и с сумками за спиной ");
            WriteLine("Охраник2: Снова какие то пранкеры? Один в маске зайца, а второй в маске орла... хотя постой");
            WriteLine("Охраник1: Что там!?  *ЗВУК ВЫСТРЕЛА* ");
            WriteLine("Pablo: Йоу хаха, ты видел как я его?");
            WriteLine("Chikatilo: Да ты крут, с первого выстрела, вон там еще второй");
            WriteLine("Chikatilo: *ВЫСТРЕЛ*");
            WriteLine("Pablo: А ты тоже хорош");
            WriteLine("Chikatilo: Знаю, все заходим внутрь");
            WriteLine("Pablo: *ВЫСТРЕЛ В ПОТОЛОК*");
            WriteLine("Pablo: ВСЕМ ЛЕЖАТЬ, ЭТО ОГРАБЛЕНИЕ");
            WriteLine(" *КРИКИ ЛЮДЕЙ* ");
            WriteLine("Chikatilo: ВСЕМ ТИХО, Я СКАЗАЛ ВСЕМ ТИХО");
            WriteLine("Охраник3: А ну руки вверх!");
            WriteLine("Pablo: БЕРЕГИСЬ *ВЫСТРЕЛ* ");
            WriteLine("Chikatilo: О господи, я уже хотел прощаться со своей жизнью, спасибо тебе что помог");
            WriteLine("Pablo: Да не благодари, следующий раз будь аккуратнее ладно?");
            WriteLine("Chikatilo: Ладно, ну че там, где находится этот сейф");
            WriteLine("Pablo: Нам нужно пройти через ту дверь только вот она закрыта");
            WriteLine("Pablo: Попробуй поискать ключ у сотрудников, а еще их нужно связать");
            WriteLine("Chikatilo: Хорошо, щас все сделаю");
            WriteLine("*СВЯЗАЛ СОТРУДНИКОВ И НАШЕЛ КЛЮЧ*");
            WriteLine("Chikatilo: Я НАШЕЛ!");
            WriteLine("Pablo: Отлично, давай сюда");
            WriteLine("*Звук щелчка дверного замка");
            WriteLine("Pablo: Ого, а вот и сейф");
            WriteLine("Chikatilo: Да, он такой, огромный...");
            WriteLine("Pablo: А что ты хотел? Не будут же хранить 15000000$ в маленьком сейфе");
            WriteLine("Chikatilo: Ну да это точно, ладно пойдем скорей открывать");
            WriteLine("Pablo: Тут на сейфе кодовый замок");
            WriteLine("Chikatilo: И как мы его будем открывать?");
            WriteLine("Pablo: Ну вот на это нам и нужен Марк");
            WriteLine("*ЗВУК РАЦИИ* Марк приступай");
            WriteLine("*ЗВУК ОКРЫТИЯ СЕЙФА*");
            WriteLine("Chikatilo: Так быстро!? Прошло всего секунд 30");
            WriteLine("Pablo: Да, Не думал что он такое способен");
            WriteLine("Pablo: Все, скорей заходим");
}



        static void Main(string[] args)
        {
            Pablo pablo = new Pablo("Пабло",true, true, true);
            Chikatalo chikatalo = new Chikatalo("Чакатало", true, true, true);
            pablo.PrintHaracteristick();
            chikatalo.PrintHaracteristick();
            Story_1();
            StoryLines.StoryLine();
            

        }
    }
}
