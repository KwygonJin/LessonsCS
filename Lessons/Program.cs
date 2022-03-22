using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal(2, "juja");
            Animal cat = new Animal(3, "Pandora");

            Animal [] animals = { dog, cat };

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Animal []));

            using (FileStream fs = new FileStream(@"C:\Users\KwygonJin\source\repos\Lessons\Lessons\animals.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, animals);
            }

            using (FileStream fs = new FileStream(@"C:\Users\KwygonJin\source\repos\Lessons\Lessons\animals.json", FileMode.OpenOrCreate))
            {
                Animal[] newAnimal = (Animal [])jsonFormatter.ReadObject(fs);
                foreach (Animal anim in newAnimal)
                    Console.WriteLine($"Имя: {anim.name}, возраст: {anim.age}");
            }
        }
    }
 }


////////////////////////
///Исключения
//Console.WriteLine("Введите число:");
//byte number = 0;
//try {
//    number = Convert.ToByte(Console.ReadLine());
//} catch (OverflowException) {
//    Console.WriteLine("Вы превысили допустимый диапазон!");
//} catch (FormatException) {
//    Console.WriteLine("Вы ввели неверный формат данных!");
//} finally {
//    Console.WriteLine("Finally");
//}
//Console.WriteLine($"Число: {number}");

//int[] mas = { 1, 2 };
//try {
//    Console.WriteLine(mas[3]);
//} catch (IndexOutOfRangeException) {
//    Console.WriteLine("Index out of range!");
//}

///////////////////////////////////////////////////////////////
//Работа с файлами
//string file_name = @"C:\Users\KwygonJin\source\repos\Lessons\Lessons\text.txt";
//string word = "some new information sw";

//Работа через класс файл
//file.writealltext(file_name, "hello world! \n some new!");

//foreach (string line in file.readalllines(file_name)){
//    console.writeline($"линия: {line}");
//}
// Если файл существует, то работаем с ним
//if (!File.Exists(path))
//{
//    // Создаем файл для записи в него
//    // Environment.NewLine - позволяет вставить пропуск строки
//    string createText = "Some simple string" + Environment.NewLine;
//    File.WriteAllText(path, createText); // Пишем в файл path новый текст (createText)
//}

//// Добавляем в файл дополнительный текст в конец файла
//// Для этого используем функцию AppendAllText (добавление текста)
//string appendText = "Дополнительный текст" + Environment.NewLine;
//File.AppendAllText(path, appendText);

//// Открываем файл для чтения и считываем всё
//string readText = File.ReadAllText(path);
//// Выводим в консоль
//Console.WriteLine(readText);

//Работа через класс ФайлСтрим - потоковая запись

//FileStream fs = File.Open(file_name, FileMode.Create);
//byte[] writeStrByte = Encoding.Default.GetBytes(word);
//fs.Write(writeStrByte, 0, writeStrByte.Length);
//fs.Position = 0;

//byte[] readStrByte = new byte[writeStrByte.Length];
//for (int i = 0; i < writeStrByte.Length; i++)
//{
//    readStrByte[i] = (byte)fs.ReadByte();
//}

//Console.WriteLine(Encoding.Default.GetString(readStrByte));
//fs.Close();

//Работа через класс StreamWriter -преимущество меньше кода и побайтовой конвертации
//StreamWriter sw = File.CreateText(file_name);
//sw.WriteLine("Hello stream writer");
//sw.Write(word);
//sw.Close();

//StreamReader sr = File.OpenText(file_name);
//Console.WriteLine(sr.ReadToEnd());
//sr.Close();