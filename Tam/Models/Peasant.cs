using System.Collections.Generic;
using System;

namespace Tamagotchi.Models
{
    public class Peasant
    {
        private int _id;
        private int _food;
        private int _attention;
        private int _sleep;
        private int _health;
        private int _idCounter = 0;

        private static List<Peasant> _instances = new List<Peasant> {};

        public Peasant(int health = 100)
        {
          ++_idCounter;
          _id = _idCounter;
          _food = 100;
          _attention = 100;
          _sleep = 100;
          _health = health;
          _instances.Add(this);
        }

        public int GetId()
        {
          return _id;
        }
        public int GetFood()
        {
          return _food;
        }
        public int GetAttention()
        {
          return _attention;
        }
        public int GetSleep()
        {
          return _sleep;
        }
        public int GetHealth()
        {
          return _health;
        }
        public static List<Peasant> GetAll()
        {
          return _instances;
        }
        public static Peasant Find(int searchID)
        {
            return _instances[searchID];
        }

    }
}
