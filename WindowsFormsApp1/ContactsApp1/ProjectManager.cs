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
    public class ProjectManager
    {

        private static string filename = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ContactApp.notes";
        //private static string filename = @"C:\Users\rodic\Documents\ContactApp.notes";
        /// <summary>
        /// Выполнение сериализации
        /// </summary>
        /// <param name="filename">Путь к файлу для сериализации</param> 
        /// <param name="product">Объект сериализации</param>
        public static void Serialization(Project product, string path)
        {
            if (path == null)
            {
                path = filename;
            }
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(path))

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, product);
            }
        }

        private static bool fileExists = new FileInfo(filename).Exists;
        
        /// <summary>
        /// Выполнение десириализации
        /// </summary>
        /// <param name="filename">Путь к файлу для десириализации</param> 
        /// <param name="product">Объект десириализации</param>
        public static Project Deserialization(string path)
        {
            Project _product=new Project();
            if (fileExists == true)
            {
                if (path == null)
                {
                    path = filename;
                }

                JsonSerializer serializer = new JsonSerializer();

                using (StreamReader sr = new StreamReader(path))

                using (JsonReader reader = new JsonTextReader(sr))
                {
                    //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                    return _product = (Project)serializer.Deserialize<Project>(reader);
                }
            }
            else return _product;
            
        }

    }
}
