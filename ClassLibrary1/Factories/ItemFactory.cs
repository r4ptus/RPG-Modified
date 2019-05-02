using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Actions;
using ClassLibrary1.Models;
using Newtonsoft.Json;

namespace ClassLibrary1.Factories
{
    public static class ItemFactory
    { 

        private const string GAME_DATA_FILENAME = ".\\GameData\\GameItems.json";

        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();

        static ItemFactory()
        {
            if (File.Exists(GAME_DATA_FILENAME))
            {
                string content = File.ReadAllText(GAME_DATA_FILENAME);
                _standardGameItems = JsonConvert.DeserializeObject<List<GameItem>>(content);
            }
            else
            {
                throw new FileNotFoundException($"Missing fata file: {GAME_DATA_FILENAME}");
            }


            //BuildWeapon(1001, "Pointy Stick", 1, 1, 2);
            //BuildWeapon(1002, "Rusty Sword", 5, 1, 3);

            //BuildWeapon(1501, "Snake fangs", 0, 0, 2);
            //BuildWeapon(1502, "Rat claws", 0, 0, 2);
            //BuildWeapon(1503, "Spider fangs", 0, 0, 4);

            //BuildHealingItem(2001, "Granola bar", 5, 2);

            //BuildMiscellaneousItem(3001, "Oats", 1);
            //BuildMiscellaneousItem(3002, "Honey", 2);
            //BuildMiscellaneousItem(3003, "Raisins", 2);

            //BuildMiscellaneousItem(9001, "Snake fang", 1);
            //BuildMiscellaneousItem(9002, "Snakeskin", 2);
            //BuildMiscellaneousItem(9003, "Rat tail", 1);
            //BuildMiscellaneousItem(9004, "Rat fur", 2);
            //BuildMiscellaneousItem(9005, "Spider fang", 1);
            //BuildMiscellaneousItem(9006, "Spider silk", 2);
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }

        public static string ItemName(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID)?.Name ?? "";
        }
    }
}
