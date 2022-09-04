﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Json_Read_Write
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LoadJson();
        }
        public  static void LoadJson()
        {


            using (System.IO.StreamReader _StreamReader = new System.IO.StreamReader(@"exampleData.json"))
            {
                string jsonData = _StreamReader.ReadToEnd();
                Root listPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(jsonData);

                Console.WriteLine(listPerson.name);
                Console.ReadLine();
            }

        }
    }

    public class Batter
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Batters
    {
        public List<Batter> batter { get; set; }
    }

    public class Root
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public double ppu { get; set; }
        public Batters batters { get; set; }
        public List<Topping> topping { get; set; }
    }

    public class Topping
    {
        public string id { get; set; }
        public string type { get; set; }
    }

}
