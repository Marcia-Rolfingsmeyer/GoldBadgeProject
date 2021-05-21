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

        public bool AddNewPermissions(int newBadgeID, List<string> newDoors)
        {
            int startCount = _badgeDictionary.Count;
            _badgeDictionary.Add(newBadgeID, newDoors);
            bool wasAdded = startCount + 1 == _badgeDictionary.Count();
            return wasAdded;
        }


        public void UpdateExistingBadge (int badgeID, string newDoor)
        { 
            foreach (int id in _badgeDictionary.Keys)
            {
                if (badgeID==id)
                {
                    _badgeDictionary[id].Add(newDoor);  //got help with this - not sure I fully understand why this works
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
            foreach(int id in _badgeDictionary.Keys)
            {
                if(badgeID==id)
                {
                    List<string> doors = _badgeDictionary[id];
                    doors.Remove(door);
                }
            }
        }
    }
}

