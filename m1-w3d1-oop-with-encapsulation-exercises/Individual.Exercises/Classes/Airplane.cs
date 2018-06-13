using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
		//properties
		public string PlaneNumber { get;  }
		public int BookedFirstClassSeats { get; private set; }
		public int TotalFirstClassSeats { get;  }
		public int AvailableFirstClassSeats
		{
			get
			{
				return TotalFirstClassSeats - BookedFirstClassSeats;
			}
		}
		public int BookedCoachSeats { get; private set; }
		public int TotalCoachSeats { get; }
		public int AvailableCoachSeats
		{
			get
			{
				return TotalCoachSeats - BookedCoachSeats;
			}
		}


		//constructor
		public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
		{
			PlaneNumber = planeNumber;
			TotalFirstClassSeats = totalFirstClassSeats;
			TotalCoachSeats = totalCoachSeats;
		}


		//methods
		public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
		{
			bool result = false;

			if (forFirstClass)
			{
				if(totalNumberOfSeats <= AvailableFirstClassSeats)
				{
					BookedFirstClassSeats += totalNumberOfSeats;
					result = true;
				}
				else
				{
					result = false;
				}			
			}
			else if (!forFirstClass)
			{
				if (totalNumberOfSeats <= AvailableCoachSeats)
				{
					BookedCoachSeats += totalNumberOfSeats;
					result = true;
				}
				else
				{
					result = false;
				}
			}

			return result;
		}      
    }
}
