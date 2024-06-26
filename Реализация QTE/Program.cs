﻿using System.Collections.Generic;
using System.Threading;
using System;
using static System.Console;
using System.Diagnostics;
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

        public int Heal { get; set; }

        public void PrintHaracteristick()
        {
            string Zov;
            Func<bool, int, string> triefalse = (x, y) =>
            {
                if (x == true && y == 1)
                {
                    return "Цела";
                }
                if (x == true && y == 0)
                {
                    return "Целы";
                }
                if (x == true && y == 2)
                {
                    return "Цело";
                }
                else
                {
                    return "Повреждение";
                }
            };
            WriteLine("\n-==ВЫ==-");
            WriteLine($"Имя: {Name}");
            WriteLine($"Ноги: {Zov = triefalse(Legs, 0)}");
            WriteLine($"Голова: {Zov = triefalse(Head, 1)}");
            WriteLine($"Тело: {Zov = triefalse(Body, 2)}");
        }

        public Pablo(string Name, bool Legs, bool Head, bool Body, int Heal)
        {
            this.Name = Name;
            this.Legs = Legs;
            this.Head = Head;
            this.Body = Body;
            this.Heal = Heal;
        }
        public bool ZXC(int n, Chikatalo bro)
        {
            if (n > 0)
            {
                Random rnd = new Random();
                int shot = rnd.Next(0, n);
                Func<int, bool> shoting = (x) =>
                {
                    if (x == 0 || Body == false && Legs == false)
                    {
                        int tim = rnd.Next(0, 2);
                        if (tim == 0)
                        {
                            Console.WriteLine("*Chikatalo выпрыгнул я поймал пулю прикрывая тебя");

                            if (Heal > 0)
                            {
                                Console.WriteLine("*Оперативно достав аптечку из сумки, ты выличил Chikatalo");
                                bro.Statist = true;
                                Heal = 0;
                                return Head = true;
                            }
                            else
                            {
                                Console.WriteLine("Хилок не оказалось...");
                                bro.Statist = false;
                                return Head = true;
                            }
                        }
                        else
                        {
                            return Head = false;
                        }
                    }
                    if (x == 1 || Body == false)
                    {

                        Console.WriteLine("Pablo:Аааа. Черт, мне попали в колено... О стелсе можно забыть");
                        Console.WriteLine("Pablo:Наверно нужо подлечится... В слудующий раз мне может не повезти");
                        Console.WriteLine("Использовать аптечку(1-да), но учтите, она еще может понадобиться:");
                        char vib = char.Parse(Console.ReadLine());
                        switch (vib)
                        {
                            case '1':
                                if (Heal > 0)
                                {
                                    Console.WriteLine("*Оперативно достав аптечку из сумки, ты выличил ногу");
                                    Heal = 0;
                                    return Legs = true;
                                }
                                else
                                {
                                    Console.WriteLine("Хилок не оказалось...");
                                    return Legs = true;
                                }

                                break;

                            default:

                                return Legs = false;

                                break;

                        }

                    }
                    else
                    {
                        return Body = false;
                    }
                };
                if (shot > 0)
                {
                    shot = rnd.Next(0, 3);
                    return shoting(shot);
                }
            }
            return Head = true;
        }
    };

    class Chikatalo : IRobbery
    {
        public string Name { get; set; }

        public bool Legs { get; set; }
        public bool Head { get; set; }
        public bool Body { get; set; }

        public bool Statist { get; set; }

        public void PrintHaracteristick()
        {
            string Zov;
            Func<bool, string> triefalse = (x) =>
            {
                if (x == true)
                {
                    return "Здоров";
                }
                else
                {
                    return "При Смерти";
                }
            };
            WriteLine("\n-==СОЮЗНИК==-");
            WriteLine($"Имя: {Name}");
            WriteLine($"Состаяние: {Zov = triefalse(Statist)}\n");
        }

        public Chikatalo(string Name, bool Statist)
        {
            this.Name = Name;

            this.Statist = Statist;

        }
    };

    internal class Program
    {
        public static int QTE(int timer)
        {
            char[] all = { 'A', 'S', 'D', 'F', 'G', 'Q', 'W', 'E', 'R' };

            Random rnd = new Random();
            int s = rnd.Next(3, 6);
            char[] Qte = new char[s];

            for (int i = 0; i < Qte.Length; i++)
            {
                Qte[i] = all[rnd.Next(0, all.Length)];
            }

            switch (s)
            {
                case 3:
                    Console.WriteLine($@"
         ...                 ...                 ...
        : {Qte[0]} :               : {Qte[1]} :               : {Qte[2]} :
         : :                 : :                 : :
      ..    ..            ..    ..            ..    ..
      :      :            :      :            :      :
     : -.   = :          : -.   = :          : -.   = :
   ....:    :....      ....:    :....      ....:    :....
   -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=
       : :: :              : :: :              : :: :
       : : .:              : : .:              : : .:
       : . :.              : . :.              : . :.
       ::  ::              ::  ::              ::  ::
       ::  ::              ::  ::              ::  ::
");
                    break;
                case 4:
                    Console.WriteLine($@"
         ...                 ...                 ...                 ...
        : {Qte[0]} :               : {Qte[1]} :               : {Qte[2]} :               : {Qte[3]} :
         : :                 : :                 : :                 : :
      ..    ..            ..    ..            ..    ..            ..    ..
      :      :            :      :            :      :            :      :
     : -.   = :          : -.   = :          : -.   = :          : -.   = :
   ....:    :....      ....:    :....      ....:    :....      ....:    :....
   -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=
       : :: :              : :: :              : :: :              : :: :
       : : .:              : : .:              : : .:              : : .:
       : . :.              : . :.              : . :.              : . :.
       ::  ::              ::  ::              ::  ::              ::  ::
       ::  ::              ::  ::              ::  ::              ::  ::
");
                    break;
                case 5:

                    Console.WriteLine($@"
         ...                 ...                 ...                 ...                 ...
        : {Qte[0]} :               : {Qte[1]} :               : {Qte[2]} :               : {Qte[3]} :               : {Qte[4]} :
         : :                 : :                 : :                 : :                 : :
      ..    ..            ..    ..            ..    ..            ..    ..            ..    ..
      :      :            :      :            :      :            :      :            :      :
     : -.   = :          : -.   = :          : -.   = :          : -.   = :          : -.   = :
   ....:    :....      ....:    :....      ....:    :....      ....:    :....      ....:    :....
   -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=
       : :: :              : :: :              : :: :              : :: :              : :: :
       : : .:              : : .:              : : .:              : : .:              : : .:
       : . :.              : . :.              : . :.              : . :.              : . :.
       ::  ::              ::  ::              ::  ::              ::  ::              ::  ::
       ::  ::              ::  ::              ::  ::              ::  ::              ::  ::
");
                    break;
                case 6:
                    Console.WriteLine($@"
         ...                 ...                 ...                 ...                 ...                 ...
        : {Qte[0]} :               : {Qte[1]} :               : {Qte[2]} :               : {Qte[3]} :               : {Qte[4]} :               : {Qte[5]} :
         : :                 : :                 : :                 : :                 : :                 : :
      ..    ..            ..    ..            ..    ..            ..    ..            ..    ..            ..    ..
      :      :            :      :            :      :            :      :            :      :            :      :
     : -.   = :          : -.   = :          : -.   = :          : -.   = :          : -.   = :          : -.   = :
   ....:    :....      ....:    :....      ....:    :....      ....:    :....      ....:    :....      ....:    :....
   -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=      -=: : .. : .-=
       : :: :              : :: :              : :: :              : :: :              : :: :              : :: :
       : : .:              : : .:              : : .:              : : .:              : : .:              : : .:
       : . :.              : . :.              : . :.              : . :.              : . :.              : . :.
       ::  ::              ::  ::              ::  ::              ::  ::              ::  ::              ::  ::
       ::  ::              ::  ::              ::  ::              ::  ::              ::  ::              ::  ::
");
                    break;

            }





            Array.Sort(Qte);


            int timeLimit = timer;
            var stopwatch = new Stopwatch();

            Console.Write("Введите буквы через пробел:");

            stopwatch.Start();
            string input = Console.ReadLine();
            stopwatch.Stop();

            if (stopwatch.ElapsedMilliseconds > timeLimit * 1000)
            {
                Console.WriteLine("Время вышло!");
                return Qte.Length;
            }



            string[] AsString = input.Split(' ');

            char[] userInput = new char[AsString.Length];
            for (int i = 0; i < AsString.Length; i++)
            {
                if (char.TryParse(AsString[i].Trim(), out char number))
                {
                    userInput[i] = number;
                }
            }

            Array.Sort(userInput);
            int count = 0;

            for (int i = 0; i < Qte.Length; i++)
            {
                if (userInput.Length < Qte.Length || !EqualityComparer<char>.Default.Equals(Qte[i], userInput[i]))
                {
                    count++;
                }
            }

            return count;
        }
        public static void Music()
        {
            Beep(784, 150);
            Thread.Sleep(300);
            Beep(784, 150);
            Thread.Sleep(300);
            Beep(932, 150);
            Thread.Sleep(150);
            Beep(1047, 150);
            Thread.Sleep(150);
            Beep(784, 150);
            Thread.Sleep(300);
            Beep(784, 150);
            Thread.Sleep(300);
            Beep(699, 150);
            Thread.Sleep(150);
            Beep(740, 150);
            Thread.Sleep(150);
            Beep(784, 150);
            Thread.Sleep(300);
            Beep(784, 150);
            Thread.Sleep(300);
            Beep(932, 150);
            Thread.Sleep(150);
            Beep(1047, 150);
            Thread.Sleep(150);
            Beep(784, 150);
            Thread.Sleep(300);
            Beep(784, 150);
            Thread.Sleep(300);
            Beep(699, 150);
            Thread.Sleep(150);
            Beep(740, 150);
            Thread.Sleep(150);
            Beep(932, 150);
            Beep(784, 150);
            Beep(587, 1200);
            Thread.Sleep(75);
            Beep(932, 150);
            Beep(784, 150);
            Beep(554, 1200);
            Thread.Sleep(75);
            Beep(932, 150);
            Beep(784, 150);
            Beep(523, 1200);
            Thread.Sleep(150);
            Beep(466, 150);
            Beep(523, 150);
        }
        public static void Story_1()
        {
            WriteLine();
            WriteLine();
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
            WriteLine("Марк: ... ");
            WriteLine("Охраник1: *ЗВУК РАЦИИ* *ПРИЕМ*");
            WriteLine("Охраник1: Слушаю");
            WriteLine("Охраник2: Вижу неподалеку двух мужиков в масках и с сумками за спиной ");
            WriteLine("Охраник2: Снова какие то пранкеры? Один в маске зайца, а второй в маске орла... хотя постой");
        }
        public static void Story_3()
        {
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

        public static void Story_Final()
        {
            WriteLine("Pablo:Вот мы и в сейфе");
            WriteLine("Chikatilo: КАК ЖЕ ТУТ МНОГО БАБЛА");
            WriteLine("Pablo:Скорей доставай сумку и забирай все что видишь");
            WriteLine("Chikatilo: Наконец то, мы на шаге от победы");
            WriteLine("Chikatilo: Неужели мы сможем закрыть эти долбанные долги и жить с кайфом");
            WriteLine("Pablo: Давай, мы об этом будем говорить когда выберемся от сюда, а пока набирай деньги ");
            WriteLine("*ЗВУКИ СИРЕНЫ*");
            WriteLine("Chikatilo: ВОТ ЧЕРТ!!");
            WriteLine("Pablo: Что за дела, откуда сирена!?");
            WriteLine("Chikatilo: Походу какой то из сотрудников смог скрыться и вызвать копов");
            WriteLine("Pablo: Как можно было пропустить сотрудника!?");
            WriteLine("Chikatilo: Да какая сейчас тебе разница? ВАЛИМ ОТ СЮДА");
            WriteLine("*СИРЕНЫ ПОЛИЦЕЙСКИЙ ТАЧЕК*");
            WriteLine("Chikatilo: НУ ВСЕ, ТЕПЕРЬ НАМ ТОЧНО КРАНТЫ");
            WriteLine("Копы: *ГРОМКОГОВОРИТЕЛЬ* МЫ ЗНАЕМ ЧТО ВЫ НАХОДИТЕСЬ ВНУТРИ, ВАМ НЕКУДА БЕЖАТЬ, ВЫХОДИТЕ С ПОДНЯТАМИ РУКАМИ, ИНАЧЕ ПРИЙДЕТСЯ ПРИНЯТЬ КРАЙНИЕ МЕРЫ");
            WriteLine("Копы: *ПОВТОРЯЮ, ВЫХОДИТЕ С ПОДНЯТАМИ РУКАМИ, ИНАЧЕ ПРИЙДЕТСЯ ПРИНЯТЬ КРАЙНИЕ МЕРЫ");
            WriteLine("Chikatilo: Это точно конец, а мы так были близко");
            WriteLine("Chikatilo: Вот черт черт черт, а я тебе предлагал просто пойти посмотреть футбол, а не вот это все ");
            WriteLine("Pablo: Без паники, у меня есть идея, у нас же есть заложник");
            WriteLine("Chikatilo: Да что нам это даст, нас просто пристрелят и все");
            WriteLine("Pablo: Но у нас нету других вариантов, в тюрягу я точно не хочу попасть");
            WriteLine("Pablo: Просто доверься мне, у нас все получится");
            WriteLine("Chikatilo: Ладно, других вариантов и вправду нету, пойдем");
            WriteLine("Pablo: Направь пистолет на заложника и медленно выходим");
            WriteLine("Chikatilo: Зачем вообще я на это подписался");
            WriteLine("Pablo: *КРИК* У НАС ЕСТЬ ЗАЛОЖНИК, ПОВТОРЯЮ");
            WriteLine("Pablo: У НАС ЕСТЬ ЗАЛОЖНИК");
            WriteLine("Pablo: МЫ МОЖЕМ В НЕГО ВЫСТРЕЛИТЬ");
            WriteLine("Копы: *ГРОМКОГОВОРИТЕЛЬ* НЕМЕДЛЕННО ПОЛОЖИТЕ ОРУЖИЕ НА ЗЕМЛЮ");
            WriteLine("Pablo: ЕСЛИ ВЫ ЧТО ТО НАМ СДЕЛАЕТЕ МЫ СРАЗУ УБЬЕМ ЗАЛОЖНИКА");
            WriteLine("Pablo: *ШЕПОТ* теперь потихоньку отходим в сторону фургона и насчет 3 бежим в него");
            WriteLine("Pablo: Я ПОВТОРЯЮ, ЕСЛИ ВЫ ЧТО ТО НАМ СДЕЛАЕТЕ, МЫ СРАЗУ УБЬЕМ ЗАЛОЖНИКА ");
            WriteLine("Pablo: А теперь, раз... два... ТРИ, БЕЖИМ");
            WriteLine("*ВЫСТРЕЛ*");
            WriteLine("Chikatilo: ААА... МНЕ ПОПАЛИ В НОГУ, ПОМОГИ МНЕ");
            WriteLine("Копы: *ГРОМКОГОВОРИТЕЛЬ* НЕМЕДЛЕННО ПОЛОЖИТЕ ОРУЖИЕ НА ЗЕМЛЮ ИЛИ МЫ ПРОДОЛЖИМ ОГОНЬ ");
            WriteLine("Pablo: ВСЕ ВСЕ, НЕ СТРЕЛЯЙТЕ");
            WriteLine("Pablo: *Мысли* Неужели на этом все кончено и теперь придется сидеть в тюряге...");
            WriteLine("Chikatilo: *Мысли* Зачем я только на это согласился, смотрел бы себе дальше футбол и ничего бы не произошло, а теперь еще и эта адская боль в ноге");
            WriteLine("Pablo: *ШЕПОТ* Ничего брат мы с тобой еще выберемся");
            WriteLine("Chikatilo: *ШЕПОТ* Я очень надеюсь на это");
            WriteLine("Chikatilo: *ШЕПОТ* СТОП, а где же фургон вместе с Марком!?");
            WriteLine("Pablo: *ШЕПОТ* Походу он успел смыться, пока мы пытались выбраться");
            WriteLine("Chikatilo: *ШЕПОТ* Вот же черт...");
            WriteLine("Марк: Ничего страшного пацаны, я обязательно вас вытащу от туда, так все просто я не дам этому закончиться");
            WriteLine("ПРОДОЛЖЕНИЕ СЛЕДУЕТ...");
        }
        static void Main(string[] args)
        {
            Music();
            Pablo pablo = new Pablo("Пабло", true, true, true, 1);
            Chikatalo chikatalo = new Chikatalo("Чакатало", true);

            //Console.WriteLine(pablo.ZXC(6, chikatalo));
            StoryLines.StoryLine();


        }
    }
}
