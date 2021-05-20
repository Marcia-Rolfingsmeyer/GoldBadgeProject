using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Ins_Repo
{
    //A badge repository that will have methods that do the following:
    //Create a dictionary of badges.
    //The key for the dictionary will be the BadgeID.
    //The value for the dictionary will be the List of Door Names.

    public enum KIDoors { A1, A2, A3, A4, B1, B2, B3, C1, C2, C3, C4, C5, C6 }
    public class KomodoInsurance
    {
        public int BadgeID { get; set; }
        public KIDoors Doors { get; }

        public KomodoInsurance() { }

        public KomodoInsurance(int badgeID, KIDoors doors)
        {
            BadgeID = badgeID;
            Doors = doors;
        }
    }
}
