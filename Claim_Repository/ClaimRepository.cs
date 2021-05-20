using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim_Repository
{
    public class ClaimRepository
    {
        private readonly Queue<Claims> _claimsDirectory = new Queue<Claims>();

        public Queue<Claims> GetAllClaims()
        {
            foreach (Claims allClaims in _claimsDirectory)
            {
                Console.WriteLine(/*allClaims.ClaimID, allClaims.TypeOfClaim,*/ allClaims.Description, allClaims.ClaimAmount, allClaims.DateOfIncident, allClaims.DateOfClaim, allClaims.IsValid);
            }
            return null; 
        }
        
        public Queue<Claims> GetNextClaim()
        {
            Queue<Claims>.Enumerator nextClaim = _claimsDirectory.GetEnumerator();
            while (nextClaim.MoveNext())
            {
                Console.WriteLine(nextClaim.Current);
            }
            return null;
        }

        public Queue<Claims> DeleteClaim()
        {
            int startCount = _claimsDirectory.Count;
            _claimsDirectory.Dequeue();
            if(_claimsDirectory.Count < startCount)
            {
                return _claimsDirectory;
            }
            return null;
        }

        public Queue<Claims> AddClaim(Claims newClaim)
        {
            int startCount = _claimsDirectory.Count;
            _claimsDirectory.Enqueue(newClaim);
            if(_claimsDirectory.Count > startCount)
            {
                return _claimsDirectory;
            }
            return null;
        }
    }
}
