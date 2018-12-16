using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Класс реализующий сериализацию и десериализацию объекта project.cs в файл.
    /// </summary>
    public class Project_Manager
    {
         //private static string filename = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ContactApp.notes";
         private static string filename = @"C:\Users\rodic\Documents";
         /// <summary>
         /// Выполнение сериализации
         /// </summary>
         /// <param name="filename">Путь к файлу для сериализации</param> 
         /// <param name="product">Объект сериализации</param>
         public void Serialization(string filename, Project product)
         {
             JsonSerializer serializer = new JsonSerializer();

             using (StreamWriter sw = new StreamWriter(filename))

             using (JsonWriter writer = new JsonTextWriter(sw))
             {
                 //Вызываем сериализацию и передаем объект, который хотим сериализовать
                 serializer.Serialize(writer, product);
             }
         }
         /// <summary>
         /// Выполнение десириализации
         /// </summary>
         /// <param name="filename">Путь к файлу для десириализации</param> 
         /// <param name="product">Объект десириализации</param>
         public void Deserialization(string filename, Project product)
         {
             product = null;

             JsonSerializer serializer = new JsonSerializer();

             using (StreamReader sr = new StreamReader(filename))

             using (JsonReader reader = new JsonTextReader(sr))
             {
                 //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                 product = (Project)serializer.Deserialize<Project>(reader);
             }
         }
    }
}
