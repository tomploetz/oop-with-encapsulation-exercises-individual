using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
		//properties
		public string TypeOfFruit { get; }
		public int PiecesOfFruitLeft { get; private set; }


		//constructors
		public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
		{
			TypeOfFruit = typeOfFruit;
			PiecesOfFruitLeft = startingPiecesOfFruit;
		}


		//methods
		public bool PickFruit(int numberOfPiecesToRemove)
		{
			bool result = false;

			if(PiecesOfFruitLeft == 0)
			{
				result = false;
			}
			else
			{
				result = true;
				PiecesOfFruitLeft -= numberOfPiecesToRemove;
			}

			return result;
		}
        
    }
}
