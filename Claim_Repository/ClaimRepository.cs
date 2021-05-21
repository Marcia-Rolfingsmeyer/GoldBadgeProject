using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim_Repository
{
    public class ClaimRepository
    {
        private readonly Queue<Claims> _claimsQueue = new Queue<Claims>();
        private readonly List<string> doors = new List<string>() { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "B1", "B2", "B3", "B4", "C1", "C2", "C3", "C4" };

        public Queue<Claims> GetAllClaims()
        {
            return _claimsQueue;
        }

        public bool DeleteClaim()
        {
            int startCount = _claimsQueue.Count;
            _claimsQueue.Dequeue();
            if(_claimsQueue.Count < startCount)
            {
                return true;
            }
            return false;
        }

        public bool AddClaim(Claims newClaim)
        {
            int startCount = _claimsQueue.Count;
            _claimsQueue.Enqueue(newClaim);
            if(_claimsQueue.Count > startCount)
            {
                return true;
            }
            return false;
        }
    }
}
