﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ProtoBuf;

[Serializable]
[ProtoContract]
public struct Participant : IComparable<Participant>
{
    private string name; // Имя участника
    private int place; // Место участника

    [XmlElement(ElementName = "Name")]
    [ProtoMember(1)]
    public string Name { get { return name; } set { name = value; } } // Свойство для доступа к имени

    [XmlElement(ElementName = "Place")]
    [ProtoMember(2)]
    public int Place { get { return place; } set { place = value; } } // Свойство для доступа к месту

    public Participant(string name, int place)
    {
        this.name = name; // Инициализация имени участника
        if (place >= 1 && place <= 18)
        {
            this.place = place; // Инициализация места участника (если место валидное)
        }
        else
        {
            this.place = -1; // В случае невалидного места, устанавливаем -1
        }
    }

    public int CompareTo(Participant other)
    {
        return this.place.CompareTo(other.place); // Сравниваем места участников для сортировки
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {Name}   Место: {Place}");
    }
}

[XmlInclude(typeof(WomenTeam))]
[XmlInclude(typeof(MenTeam))]
[ProtoInclude(999, typeof(WomenTeam))]
[ProtoInclude(998, typeof(MenTeam))]

[Serializable]
[ProtoContract]
public abstract class Team
{
    protected string name; // Название команды
    protected Participant[] participants; // Участники команды

    [XmlElement(ElementName = "Name")]
    [ProtoMember(1)]
    public string Name { get { return name; } set { name = value; } } // Свойство для доступа к названию команды

    [XmlElement(ElementName = "Participants")]
    [ProtoMember(2)]
    public Participant[] Participants { get { return participants; } set { participants = value; } } // Свойство для доступа к участникам команды

    public Team() { }
    public Team(string name, Participant[] participants)
    {
        this.name = name; // Инициализация названия команды
        this.participants = participants; // Инициализация участников команды
    }

    public virtual int CalculateScore()
    {
        int score = 0; // Начальное значение счета
        foreach (var participant in participants)
        {
            int place = participant.Place; // Получаем место участника
            score += Math.Max(0, 6 - place);
        }
        return score; // Возвращаем общий счет команды
    }
    public abstract void PrintInfo();
}

[Serializable]
[ProtoContract]
public class WomenTeam : Team
{
    public WomenTeam() { }
    public WomenTeam(string name, Participant[] participants) : base(name, participants) { }
    public override void PrintInfo()
    {
        Console.WriteLine($"Women Team:   Имя: {Name}   Участники: {'{'}");
        foreach(Participant i in participants)
        {
            Console.Write("    ");
            i.PrintInfo();
        }
        Console.WriteLine("}");
    }
}

[Serializable]
[ProtoContract]
public class MenTeam : Team
{
    public MenTeam() { }
    public MenTeam(string name, Participant[] participants) : base(name, participants) { }
    public override void PrintInfo()
    {
        Console.WriteLine($"Men Team:   Имя: {Name}   Участники: {'{'}");
        foreach (Participant i in participants)
        {
            Console.Write("    ");
            i.PrintInfo();
        }
        Console.WriteLine("}");
    }
}

class Program
{
    static void Main()
    {
        // Женские команды
        Participant[] womenTeam1Results = GetTeamResults("Женская команда 1", 6); // Получение результатов для первой женской команды
        WomenTeam womenTeam1 = new WomenTeam("Женская команда 1", womenTeam1Results); // Создание объекта первой женской команды

        Participant[] womenTeam2Results = GetTeamResults("Женская команда 2", 6); // Получение результатов для второй женской команды
        WomenTeam womenTeam2 = new WomenTeam("Женская команда 2", womenTeam2Results); // Создание объекта второй женской команды

        Participant[] womenTeam3Results = GetTeamResults("Женская команда 3", 6); // Получение результатов для третьей женской команды
        WomenTeam womenTeam3 = new WomenTeam("Женская команда 3", womenTeam3Results); // Создание объекта третьей женской команды

        // Мужские команды
        Participant[] menTeam1Results = GetTeamResults("Мужская команда 1", 6); // Получение результатов для первой мужской команды
        MenTeam menTeam1 = new MenTeam("Мужская команда 1", menTeam1Results); // Создание объекта первой мужской команды

        Participant[] menTeam2Results = GetTeamResults("Мужская команда 2", 6); // Получение результатов для второй мужской команды
        MenTeam menTeam2 = new MenTeam("Мужская команда 2", menTeam2Results); // Создание объекта второй мужской команды

        Participant[] menTeam3Results = GetTeamResults("Мужская команда 3", 6); // Получение результатов для третьей мужской команды
        MenTeam menTeam3 = new MenTeam("Мужская команда 3", menTeam3Results); // Создание объекта третьей мужской команды

        // Соревнования внутри женских команд
        ConductCompetition(womenTeam1); // Проведение соревнований внутри первой женской команды
        ConductCompetition(womenTeam2); // Проведение соревнований внутри второй женской команды
        ConductCompetition(womenTeam3); // Проведение соревнований внутри третьей женской команды

        // Соревнования внутри мужских команд
        ConductCompetition(menTeam1); // Проведение соревнований внутри первой мужской команды
        ConductCompetition(menTeam2); // Проведение соревнований внутри второй мужской команды
        ConductCompetition(menTeam3); // Проведение соревнований внутри третьей мужской команды

        // Определение победителей
        WomenTeam winner1 = DetermineWinner(womenTeam1, womenTeam2, womenTeam3); // Определение победителя среди женских команд
        MenTeam winner2 = DetermineWinner(menTeam1, menTeam2, menTeam3); // Определение победителя среди мужских команд

        // Определение победителя между победителями женских и мужских команд
        global::Team winner3;
        if (winner1.CalculateScore() > winner2.CalculateScore())
        {
            winner3 = winner1;
        }
        else if (winner2.CalculateScore() > winner1.CalculateScore())
        {
            winner3 = winner2;
        }
        else
        {
            // Если ничья, можно выбрать любого победителя
            winner3 = winner1;
        }

        // Вывод результатов
        Console.WriteLine($"Победитель среди женских команд: {winner1.Name}"); // Вывод победителя среди женских команд
        DisplayResults(winner1); // Вывод результатов для победителя среди женских команд
        Console.WriteLine($"Победитель среди мужских команд: {winner2.Name}"); // Вывод победителя среди мужских команд
        DisplayResults(winner2); // Вывод результатов для победителя среди мужских команд
        Console.WriteLine($"Победитель между победителями женских и мужских команд: {winner3.Name}"); // Вывод победителя между победителями женских и мужских команд
        DisplayResults(winner3); // Вывод результатов для победителя между победителями женских и мужских команд

        List<Team> teams = new()
        {
            womenTeam1,
            womenTeam2,
            womenTeam3,
            menTeam1,
            menTeam2,
            menTeam3
        };
        foreach(Team i in teams)
        {
            i.PrintInfo();
        }

        Stream file = File.Create(@"data\teams.json");
        Stream data = JSONProcessing<Team>.Write(teams);
        data.CopyTo(file);
        file.Dispose();
        
        file = File.Create(@"data\teams.xml");
        data = XMLProcessing<Team>.Write(teams);
        data.CopyTo(file);
        file.Dispose();
        
        file = File.Create(@"data\teams.bin");
        data = BinProcessing<Team>.Write(teams);
        data.CopyTo(file);
        file.Dispose();
        
        teams = JSONProcessing<Team>.Read(new FileStream(@"data\teams.json", FileMode.Open));
        Console.WriteLine("JSON файл:");
        for (int i = 0; i < teams.Count; i++)
        {
            teams[i].PrintInfo();
        }
        
        teams = XMLProcessing<Team>.Read(new FileStream(@"data\teams.xml", FileMode.Open));
        Console.WriteLine("XML файл:");
        for (int i = 0; i < teams.Count; i++)
        {
            teams[i].PrintInfo();
        }
        
        teams = BinProcessing<Team>.Read(new FileStream(@"data\teams.bin", FileMode.Open));
        Console.WriteLine("Bin файл:");
        for (int i = 0; i < teams.Count; i++)
        {
            teams[i].PrintInfo();
        }
    }


    static Participant[] GetTeamResults(string teamName, int participantsCount)
    {
        Console.WriteLine($"Введите результаты соревнований для {teamName} (числа от 1 до 18):"); // Подсказка для ввода результатов для конкретной команды
        Participant[] results = new Participant[participantsCount]; // Создание массива для результатов
        for (int j = 0; j < participantsCount; j++)
        {
            Console.Write($"Участник {j + 1}: "); // Подсказка для ввода места для каждого участника
            int place = int.Parse(Console.ReadLine()); // Считывание места участника
            results[j] = new Participant($"Участник {j + 1}", place); // Создание объекта участника и добавление его в массив результатов
        }
        return results; // Возвращение массива результатов
    }

    static void ConductCompetition(Team team)
    {
    Array.Sort(team.Participants); // Сортировка участников команды по их местам
    }

    static T DetermineWinner<T>(params T[] teams) where T : Team //T - это тип, производный от класса Team; Этот параметр типа params позволяет передавать переменное количество аргументов типа T в метод
    {
        T winner = teams[0]; // Предполагаем, что первая команда из переданных является победителем
        foreach (var team in teams)
        {
            if (team.CalculateScore() > winner.CalculateScore())
            {
                winner = team; // Если очки текущей команды больше, чем у текущего победителя, обновляем победителя
            }
        }
        return winner; // Возвращаем победителя
    }

    static void DisplayResults(Team team)
    {
    Console.WriteLine($"Результаты для команды {team.Name}:"); // Выводим заголовок с названием команды
    Console.WriteLine("Участник\tМесто"); // Выводим заголовок таблицы результатов
        foreach (var participant in team.Participants)
        {
        Console.WriteLine($"{participant.Name}\t\t{participant.Place}"); // Выводим результаты для каждого участника команды
        }
    Console.WriteLine(); // Печатаем пустую строку для лучшего отображения
    }
}

