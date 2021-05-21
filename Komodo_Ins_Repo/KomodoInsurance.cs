using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Ins_Repo
{
    public class KomodoInsurance
    {
        public int BadgeID { get; set; }
        public List<string> Doors { get; set; }
        
        public KomodoInsurance() { }

        public KomodoInsurance(int badgeID, List<string> doors)
        {
            BadgeID = badgeID;
            Doors = doors;
        }
    }
}
