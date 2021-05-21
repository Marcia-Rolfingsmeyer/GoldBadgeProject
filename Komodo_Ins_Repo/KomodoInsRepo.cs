using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Ins_Repo
{
    public class KomodoInsRepo
    {
        readonly KomodoInsurance newItem = new KomodoInsurance();

        readonly Dictionary<int, List<string>> _badgeDictionary = new Dictionary<int, List<string>>();

        public List<string> doors = new List<string>() { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "B1", "B2", "B3", "B4", "C1", "C2", "C3", "C4" };

        public bool AddNewPermissions(int newBadgeID, List<string> newDoors)
        {
            int startCount = _badgeDictionary.Count;
            _badgeDictionary.Add(newBadgeID, newDoors);
            bool wasAdded = startCount + 1 == _badgeDictionary.Count();
            return wasAdded;
        }

        //can also try:  
        //public void AddNewPermissions(Key, Val) //like Badge badge
        //_badgeDictionary.Add(val.BadgeID, val.Doors);


        public void UpdateExistingBadge(int badgeID, string newDoor)
        {
            foreach (int id in _badgeDictionary.Keys)
            {
                if (badgeID == id)
                {
                    _badgeDictionary[id].Add(newDoor);  //got help with this - not sure I fully understand why this works -ref stackoverflow: https://stackoverflow.com/questions/141088/what-is-the-best-way-to-iterate-over-a-dictionary -solution 30 is a big part of direction
                }
            }
        }

        public List<string> GetDetailsByBadgeID(int badgeID)
        {
            if (_badgeDictionary.TryGetValue(badgeID, out List<string> doors)) //system recommended change
            {
                return doors;
            }
            return null;
        }

        public Dictionary<int, List<string>> GetAllDetails()
        {
            return _badgeDictionary;
        }

        public void RemoveADoor(int badgeID, string door)
        {
            foreach (int id in _badgeDictionary.Keys)
            {
                if (badgeID == id)
                {
                    List<string> doors = _badgeDictionary[id];
                    doors.Remove(door);
                }
            }
        }
    }
}

