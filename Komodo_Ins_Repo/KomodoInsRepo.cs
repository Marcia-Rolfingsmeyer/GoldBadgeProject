using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Ins_Repo
{
    public class KomodoInsRepo
    {
        List<string> doors = new List<string>() { "A1", "A2", "A3", "A4", "B1", "B2", "B3", "B4", "C1", "C2", "C3", "C4" };

        KomodoInsurance newItem = new KomodoInsurance();

        public static Dictionary<int, KomodoInsurance> _badgeDictionary = new Dictionary<int, KomodoInsurance>();



        public bool AddNewPermissions(int newBadgeID, KomodoInsurance newDoors)
        {
            int startCount = _badgeDictionary.Count;
            _badgeDictionary.Add(newBadgeID, newDoors);
            if (_badgeDictionary.Count > startCount)
            {
                return true;
            }
            return false;
        }

        public void Update(Dictionary<int, string> dic, int currentBadgeID, int newDoorPermissions)
        {
            int val;
            if (dic.TryGetValue(currentBadgeID, out val))
                {
                    dic[currentBadgeID] = val + newDoorPermissions;
                }
            else
            {
                dic.Add(key, newDoorPermissions);
            }
        }

        public static Dictionary<int, KomodoInsurance> GetAllKomodoInsurance()
        {
            return _badgeDictionary;
        }

        public bool DeleteBadgePermisssions(int deleteBadgeID)
        {
            int startCount = _badgeDictionary.Count;
            _badgeDictionary.Remove(deleteBadgeID);
            if (_badgeDictionary.Count < startCount)
            {
                return true;
            }
            return false;
        }
    }
}

