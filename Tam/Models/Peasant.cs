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

        private static List<Peasant> _instances = new List<Peasant> {};

        public Peasant()
        {
          _instances.Add(this);
          _id = _instances.Count;
          _food = 100;
          _attention = 100;
          _sleep = 100;
          _health = 100;    
        }

        public void GetId()
        {
          return _id;
        }
        public void GetFood()
        {
          return _food;
        }
        public void GetAttention()
        {
          return _attention;
        }
        public void GetSleep()
        {
          return _sleep;
        }
        public void GetHealth()
        {
          return _health;
        }



















    }
}
