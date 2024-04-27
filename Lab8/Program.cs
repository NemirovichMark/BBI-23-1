﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

abstract class Task
{
    protected string _text= "No text here yet";
    public string Text
    {
        get => _text;
        protected set => _text = value;
    }
    public Task(string text)
    { _text = text; }
    new public virtual string ToString()
    {
        return _text;
    }
    public virtual void ShowResult() { }
}
class Task_8 : Task
{
    public Task_8(string text) : base(text) { }
    public override string ToString()
    {
        ParseText();
        return _text;

    }
    private void ParseText()
    {
        int index1 = 0;
        while (index1 < _text.Length - 50)
        {
            int index2 = index1 + 50;
            while (_text[index2] != ' ') index2--;
            _text = _text.Remove(index2, 1);
            _text = _text.Insert(index2, "\n");
            while (index2 - index1 < 50)
            {
                int i = index1;
                while (i < index2)
                {
                    if (index2 - index1 < 50 && _text[i] == ' ')
                    {
                        _text = _text.Insert(i, " ");
                        index2++;
                        i++;
                    }
                    i++;
                }
            }
            index1 = index2 + 1;
        }
    }

}
class Couple
{
    private char _letter1;
    private char _letter2;
    private int _counter;
    private char _code;
    public char Letter1
    {
        get => _letter1;
        private set => _letter1 = value;
    }
    public char Letter2
    {
        get => _letter2;
        private set => _letter2 = value;
    }
    public int Counter
    {
        get => _counter;
        set => _counter = value;
    }
    public char Code
    {
        get => _code;
        private set => _code = value;
    }
    public Couple(char letter1, char letter2,char code='\0')
    {
        _letter1 = letter1;
        _letter2 = letter2;
        _counter = 0;
        _code = code;
    }
}
class Task_9 : Task
{
    private List<Couple> _couples;
    private List<Couple> _codeTable;
    public List<Couple> Couples
    {
        get => _couples;
        private set => _couples = value;
    }
    public List<Couple> CodeTable { get { return _codeTable; } private set { } }
    public Task_9(string text) : base(text)
    {
        _couples= new List<Couple>();
        _codeTable= new List<Couple>();
    }
    public override string ToString()
    {
        CountCouples();
        SortCouples();
        EncodeText();
        ShowCodeTable();
        return _text;
    }
    private void CountCouples()
    {
        for (int i = 97; i < 123; i++)
        {
            for (int j = 97; j < 123; j++)
            {
                _couples.Add(new Couple((char)i, (char)j));
            }
        }
        for (int i = 1072; i < 1104; i++)
        {
            for (int j = 1072; j < 1104; j++)
            {
                _couples.Add(new Couple((char)i, (char)j));
            }
        }
        for (int i = 1072; i < 1104; i++)
        {
            _couples.Add(new Couple((char)i, (char)1105));
            _couples.Add(new Couple((char)1105, (char)i));
        }
        for (int i = 0; i < _text.Length - 1; i++)
        {
            if (char.IsLetter(_text[i]) && char.IsLetter(_text[i + 1]))
            {
                char letter1 = char.ToLower(_text[i]);
                char letter2 = char.ToLower(_text[i + 1]);
                for (int j = 0; j < _couples.Count(); j++)
                {
                    if (letter1 == _couples[j].Letter1 && letter2 == _couples[j].Letter2)
                    {
                        _couples[j].Counter++;
                        break;
                    }
                }
            }
        }
    }
    private void SortCouples()
    {
        for (int j = 0; j < _couples.Count() - 1; j++)
        {
            for (int i = j + 1; i < _couples.Count(); i++)
            {
                if (_couples[j].Counter < _couples[i].Counter)
                {
                    Couple a = _couples[j];
                    _couples[j] = _couples[i];
                    _couples[i] = a;
                }
            }
        }
    }
    private void ShowCodeTable()
    {
        Console.WriteLine("Таблица кодов:");
        for (int i = 0; i < _codeTable.Count; i++)
        {
            Console.WriteLine($"Пара символов '{_codeTable[i].Letter1}{_codeTable[i].Letter2}' заменяется на '{_codeTable[i].Code}'");
        }
    }
    private void EncodeText()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 33; j < 1000; j++)
            {
                bool ok = true;
                for (int k = 0; k < _codeTable.Count; k++)
                {
                    if (_codeTable[k].Code == (char)j)
                    {
                        ok = false;
                        break;
                    }
                } 
                if (_text.Contains((char)j) == false && ok)
                {
                    _codeTable.Add(new Couple (_couples[i].Letter1, _couples[i].Letter2,(char)j));
                    string oldstring1 = _couples[i].Letter1.ToString() + _couples[i].Letter2.ToString();
                    string oldstring2 = char.ToUpper(_couples[i].Letter1).ToString() + _couples[i].Letter2.ToString();
                    string newstring = ((char)j).ToString();
                    _text = _text.Replace(oldstring1, newstring);
                    _text = _text.Replace(oldstring2, newstring);
                    break;
                }
            }
        }
    }
}
class Task_10 : Task
{
    private List<Couple> _codeTable;
    public List<Couple> CodeTable { get { return _codeTable; } private set { } }
    public Task_10(string text, List<Couple> codeTable ) : base(text)
    {
        _codeTable = codeTable;
    }
    private void DecodeText()
    {
        for (int i=0; i < _codeTable.Count; i++)
        {
            string newstring = _codeTable[i].Letter1.ToString() + _codeTable[i].Letter2.ToString();
            string oldstring = _codeTable[i].Code.ToString();
            _text = _text.Replace(oldstring, newstring);
        }
    }
    public override string ToString()
    {
        DecodeText();
        return _text;
    }

}
class Data12
{
    private string _word;
    private char _code;
    public string Word
    {
        get => _word;
        private set => _word = value;
    }
    public char Code
    {
        get => _code;
        private set => _code= value;
    }

    public Data12(string word,char code)
    {
        _word = word;
        _code = code;

    }
}
class Task_12 : Task
{
    private string[] _words;
    public string[] Words
    {
        get => _words;
        private set => _words = value;
    }
    public Task_12(string text) : base(text) 
    {
        _words = new string[0];
    }
    public override string ToString()
    {
        CreateArray();
        EncodeToArray();
        Console.WriteLine();
        string decodedText=DecodedText();
        Console.WriteLine("Текст после обработки:");
        Console.WriteLine();
        return decodedText;
    }
    private static Data12[] GetData()
    {
        Data12[] data12 = new Data12[] {new Data12("and",(char)1),
            new Data12("it",(char)2),
            new Data12("this",(char)3),
            new Data12("that",(char)4),
            new Data12("all", (char)5),
            new Data12("in",(char)6),
            new Data12("и",(char)206),
            new Data12("здесь",(char)207),
            new Data12("это",(char)208),
            new Data12("что", (char)213),
            new Data12("как",(char)214),
            new Data12("который",(char)215),
        };
        return data12;
    }
    private void CreateArray()
    {
        
        int i = 0;
        _text += ' ';
        string newWord = null;
        while (i < _text.Length)
        {
            if (Char.IsWhiteSpace(_text[i]))
            {
                if (newWord.Length == 0) break; 
                else if (newWord.Length == 1)
                {
                    ArrayUpdate(newWord);
                }
                else if (Char.IsPunctuation(newWord[0]) && Char.IsPunctuation(newWord[newWord.Length - 1]))
                {
                    ArrayUpdate(newWord[0].ToString());
                    ArrayUpdate(newWord.Substring(1, newWord.Length - 2));
                    ArrayUpdate(newWord[newWord.Length-1].ToString());
                }
                else if (Char.IsPunctuation(newWord[0]))
                {
                    ArrayUpdate(newWord[0].ToString());
                    ArrayUpdate(newWord.Substring(1, newWord.Length - 1));
                }
                else if (Char.IsPunctuation(newWord[newWord.Length-1]))
                {
                    ArrayUpdate(newWord.Substring(0, newWord.Length - 1));
                    ArrayUpdate(newWord[newWord.Length - 1].ToString());
                }
                else
                {
                    ArrayUpdate(newWord);
                }
                newWord= null;
            }
            else
            {
                newWord = newWord + _text[i];
            }
            i++;
        }
    }
    private void EncodeToArray()
    {
        for (int i=0;i< _words.Length; i++)
        {
            foreach (var word in GetData())
            {
                if (word.Word.Length == _words[i].Length) _words[i] = _words[i].Replace(word.Word, word.Code.ToString());
            }
        }
        
    }
    private string DecodedText()
    {
        string decodedString = null;
        Data12[] codeTable = GetData();
        for (int i = 0; i < _words.Length; i++)
        {
            foreach (var word in codeTable)
            {
                if (_words[i] == word.Code.ToString())
                {
                    _words[i] = word.Word;
                    break;
                }
            }
            decodedString += _words[i].ToString();
            int open1= -1;
            int open2 = -1;
            int open3 = -1;
            
            if (i != _words.Length - 1)
            {
                if (char.IsPunctuation(_words[i][0]))
                {
                    bool ok = true;
                    if (_words[i][0] == (char)34)
                    {
                        open1 = open1 * (-1);
                        if (open1 == 1) ok=false;
                    }
                    if (_words[i][0] == (char)39)
                    {
                        open2 = open2 * (-1);
                        if (open2 == 1) ok = false;
                    }
                    if (_words[i][0] == (char)40)
                    {
                        open3 = open3 * (-1);
                        if (open3 == 1) ok = false;
                    }
                    if (_words[i][0]==(char)44 && open1 == 1 && _words[i + 1][0] == (char)34) ok = false;
                    if  (ok) decodedString += " ";
                }
                else
                {
                    if (char.IsPunctuation(_words[i + 1][0]) == false || _words[i + 1][0] == (char)34 || _words[i + 1][0] == (char)39 || _words[i + 1][0] == '-' || _words[i + 1][0] == '(') decodedString += " ";
                }
            }
        }
        return decodedString;
    }
    private void ArrayUpdate(string newWord)
    {
        string[] newWords = new string[_words.Count()+1];
        for (int i = 0; i < _words.Length; i++)
        {
            newWords[i]= _words[i];
        }
        newWords[newWords.Length - 1] = newWord;
        _words= newWords;
    }
}
class Data13
{
    private char _letter;
    private int _count;
    private double _proportion;
    public char Letter
    {
        get => _letter;
        private set => _letter = value;
    }
    public int Count
    {
        get => _count;
        set => _count = value;
    }
    public double Proportion
    {
        get => _proportion;
        set => _proportion = value;
    }
    public Data13(char letter)
    {
        _letter = letter;
        _count = 1;
        _proportion = 0;
    }
}
class Task_13 : Task
{
    private List<Data13> _allData;
    public List<Data13> AllData
    {
        get => _allData;
        private set => _allData = value;
    }
    public override void ShowResult()
    {
        CountWords();
        CountProportion();
        ShowProporion();
    }
    public Task_13(string text) : base(text) { _allData = new List<Data13>(); }
    private void CountWords()
    {
        _text = _text.ToLower();
        int i = 0;
        while (i < _text.Length)
        {
            if (char.IsLetter(_text[i]))
            {
                bool ok = true;
                for (int j = 0; j < _allData.Count; j++)
                {

                    if (_allData[j].Letter == _text[i])
                    {
                        _allData[j].Count++;
                        ok = false;
                        break;
                    }

                }
                if (ok)
                {
                    _allData.Add(new Data13(_text[i]));
                }
                while (char.IsLetter(_text[i])) i++; 
            }
            else i++;
        }
    }
    private void CountProportion()
    {
        double k = 0;
        for (int i = 0; i < _allData.Count; i++)
        {
            k += _allData[i].Count;
        }
        for (int i = 0; i < _allData.Count; i++)
        {
            _allData[i].Proportion = _allData[i].Count/k;
        }
    }
    private void ShowProporion()
    {
        for (int i = 0; i < _allData.Count; i++)
        {
            Console.WriteLine($"{_allData[i].Letter} - {_allData[i].Proportion:F2}");
        }
    }
}
class Task_15 : Task
{
    public Task_15(string text) : base(text) { }
    public override void ShowResult()
    {
        Console.WriteLine( CountNumbers() ); 
    }
    private int CountNumbers()
    {
        string[] words = _text.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        foreach (string word in words)
        {
            int num;
            if (int.TryParse(word, out num))
            {
                sum += num;
            }
        }
        return sum;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("№8");
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();
        Task_8 task_8 = new Task_8(text);
        Console.WriteLine(task_8.ToString());
        Console.WriteLine("№9");
        Task_9 task_9 = new Task_9(text);
        Console.WriteLine(task_9.ToString());
        Console.WriteLine("№10");
        Task_10 task_10 = new Task_10(task_9.Text, task_9.CodeTable);
        Console.WriteLine("Декодированный в начальный вид текст:");
        Console.WriteLine(task_10.ToString());
        Console.WriteLine("№12");
        Task_12 task_12 = new Task_12(text);
        Console.WriteLine(task_12.ToString());
        Console.WriteLine("№13");
        Task_13 task_13 = new Task_13(text);
        task_13.ShowResult();
        Console.WriteLine("№15");
        Task_15 task_15 = new Task_15(text);
        task_15.ShowResult();
        Console.ReadKey();
    }
}

