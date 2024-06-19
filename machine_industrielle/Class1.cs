using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machine_industrielle
{
    public class BeerEncapsulator
    {
        private int _avalaibleBeerVolume = 0;
        private int _avalaibleBottles = 0;
        private int _avalaibleCapsules = 0;
        //public int BeersToDo;

        public BeerEncapsulator(int avalaibleBeerVolume, int avalaibleBottles, int avalaibleCapsules)
        {
            _avalaibleBeerVolume = avalaibleBeerVolume;
            _avalaibleBottles = avalaibleBottles;
            _avalaibleCapsules = avalaibleCapsules;
        }
        public void AddBeer(int additionalVolume) //fonction qui modifi la cantité de biere dans la machine 
        {
            _avalaibleBeerVolume += additionalVolume;
        }

        public void AddBottle(int additionalBottles)
        {
            _avalaibleBottles = +additionalBottles;
        }

        public void AddCaps(int additionalCapsules)
        {
            _avalaibleCapsules = +additionalCapsules;
        }

        public int ProduceEncapsulatedBeerBottles(int beersToDo)
        {
            int beerVolume = 33 * beersToDo;
            int encapsulatedBeer;
            if (_avalaibleBeerVolume >= beerVolume && ((_avalaibleBottles >= beersToDo) && (_avalaibleCapsules >= beersToDo)))
            {
                encapsulatedBeer = beersToDo;
                //AddBeer(-33 * beersToDo);
                //AddBottle(-1 * beersToDo);
                //AddCaps(-1 * beersToDo);
            }
            else { encapsulatedBeer = 0; }


            return encapsulatedBeer;
        }

        public void DisplayMessage(int encapsulatedBeer, int beersToDo)
        {
            int beerVolume = 33 * beersToDo;
            if (encapsulatedBeer == 0 && _avalaibleBeerVolume < beerVolume)
            {
                int beerPlus = beerVolume - _avalaibleBeerVolume;
                Console.WriteLine("ATTENTION!Y a pas assez de biere. Remplir: " + beerPlus);
            }
            else if (encapsulatedBeer == 0 && _avalaibleBottles < beersToDo)
            {
                int bottlesPlus = beersToDo - _avalaibleBottles;
                Console.WriteLine("ATTENTION!Y a pas assez de biere. Remplir: " + bottlesPlus);
            }
            else if (encapsulatedBeer == 0 && _avalaibleCapsules < beersToDo)
            {
                int capsulesPlus = beersToDo - _avalaibleCapsules;
                Console.WriteLine("ATTENTION!Y a pas assez de biere. Remplir: " + capsulesPlus);
            }
            else { Console.WriteLine("You have made " + beersToDo + " bottles!"); }
        }
    }
}
