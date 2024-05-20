﻿using System.Collections.Generic;
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
            WriteLine("Dallas: Ну и че в нем написанно? ");
            WriteLine("Sokol: Не может быть, он тут предлогает работу...  ");
            WriteLine("Dallas: Опять свои сокровища прятать предлогают? Сразу говорю я против этого ");
            WriteLine("Sokol: Да нет же, тут по серьезней дело, нам тут предлогают банк ограбить... ");
            WriteLine("Dallas: Че за бред!? И какая же в этом у нас выгода? Мне еще и не хватало за решетку сесть, заканчивай фигней маяться, пойдем лучше футболл посмотрим");
            WriteLine("Sokol: Да дослушай ты меня, нам заявляют что для нас все подготовят, и от украденной суммы мы получим 80% себе, а сумма денег которая лежит в банке это... ");
            WriteLine("Dallas: Что? Не томи уже, какая там сумма?");
            WriteLine("Sokol: *15000000$* ");
            WriteLine("Dallas: СКОЛЬКО!? Да это же можно купить себе целый особняк с бассейном на заднем дворе, много тачек, и даже вертолет ");
            WriteLine("Sokol: Да, но ты не о том думаешь. Мы спокойно можем погасить свои долги, и наконец закончить эти передряги с бандитами  ");
            WriteLine("Sokol: Ты как хочешь, но я согласен на все, лишь бы закончились эти проблемы в долгами");
            WriteLine("Dallas: Ладно брат, раз ты на такое готов, то и я с тобой");
            WriteLine("Dallas: Так че там, где он нам предлогает взять оружие и фургон для ограбления ");
            WriteLine("Sokol: Тут сказанно что к нам подъедет какой то человек на фургоне и там будет время на подготовку ");
            WriteLine("Sokol: Нам только стоит придумать какие то прозвища что бы не распростронять наши личности");
            WriteLine("Dallas: Хмм.. Я тогда буду Pablo");
            WriteLine("Sokol: Смешно конечно, ну ладно. Я тогда буду Chikatalo  ");
            WriteLine("Sokol: Нам только стоит придумать какие то прозвища что бы не распростронять наши личности");
            WriteLine("Dallas: Хмм.. Ну меня есть конечно идея");
            //Все пока на этом диалоге закончу
            // мафиози обсуждают свой план о ограблении, это начало
            // я короче ща подумаю как написать 

            // у меня вообще есть идея, о начале разговора в прицнипе, короче то что вот эти имена это их прозвища, короче типа они сидели дома, у одного там проблемы долги по горло и тд, и он второму предложил идею ограбить что нибудь, ну или второму в инете письмо пришло о предложении
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
