using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim_Repository
{

    //Create a ClaimRepository class that has proper methods.


    //The app will need methods to do the following:
    //Show a claims agent a menu:
    //Choose a menu item:
    //1. See all claims
    //2. Take care of next claim - asks do you want to take care of next claim - then removes it from list 
    //3. Enter a new claim
    //For #1, a claims agent could see all items in the queue listed out like this:

    //ClaimID Type    Description Amount  DateOfAccident DateOfClaim IsValid
    //1	Car Car accident on 465.	$400.00	4/25/18	4/27/18	true
    //2	Home House fire in kitchen.  $4000.00	4/11/18	4/12/18	true
    //3	Theft Stolen pancakes.    $4.00	4/27/18	6/01/18	false
    //For #2, when a claims agent needs to deal with an item they see the next item in the queue.

    //Here are the details for the next claim to be handled:
    //ClaimID: 1
    //Type: Car
    //Description: Car Accident on 464.
    //Amount: $400.00
    //DateOfAccident: 4/25/18
    //DateOfClaim: 4/27/18
    //IsValid: True
    //Do you want to deal with this claim now(y/n)? y
    //When the agent presses 'y', the claim will be pulled off the top of the queue. If the agent presses 'n', it will go back to the main menu.

    //For #3, when a claims agent enters new data about a claim they will be prompted for questions about it:

    //Enter the claim id: 4
    //Enter the claim type: Car
    //Enter a claim description: Wreck on I-70.
    //Amount of Damage: $2000.00
    //Date Of Accident: 4/27/18
    //Date of Claim: 4/28/18
    //This claim is valid.



    public class ClaimRepository
    {

        Queue<Claims> _claimsDirectory = new Queue<Claims>();

        public Queue<Claims> seeAllClaims()
        {
            return _claimsDirectory;
        }

        public Queue<Claims> seeNextClaim()
        {
            Queue<Claims>.Enumerator nextClaim = _claimsDirectory.GetEnumerator();
            while (nextClaim.MoveNext())
            {
                return(nextClaim);
            }
            return null;
        }



    //    private readonly List<Claims> _claimsDirectory = new List<Claims>();

    //    public List<Claims> getsAllClaims()
    //    {
    //        return _claimsDirectory;
    //    }

    //    //select next claim

    //    public List<Claims> getNextClaims(string nextItem)
    //    {
    //        while (_claimsDirectory >= 1) 
    //        {
    //            return nextItem;
    //        }
    //    }


    //    public bool UpdateNextClaims(int originalClaims, Claims newClaimItem)
    //    {
    //        Claims oldClaim = GetClaimByClaimID(originalClaims);

    //        if (oldClaim != null)
    //        {
    //            oldClaim.ClaimID = newClaimItem.ClaimID;
    //            oldClaim.TypeOfClaim = newClaimItem.TypeOfClaim;
    //            oldClaim.Description = newClaimItem.Description;
    //            oldClaim.ClaimAmount = newClaimItem.ClaimAmount;
    //            oldClaim.DateOfIncident = newClaimItem.DateOfIncident;
    //            oldClaim.DateOfClaim = newClaimItem.DateOfClaim;
    //            oldClaim.IsValid = newClaimItem.IsValid;

    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}
}
