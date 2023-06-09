using AvaloniaApplication2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication2.Classes
{
    internal static class DataStorage
    {
        public static List<Sportsman> Sportsmen { get; } = new List<Sportsman>();
        public static List<Gender> Gender { get; } = new List<Gender>()
        {
            new Gender() { Name="Мужской" },
            new Gender() { Name="Женский" }
        };
    }
}
