using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace OOP_homework2
{
    public class Garden
    {
       
        public List<IGardenItems> myGarden { get; set; }
        public List<IFood>  Foods
        {
            get
            {
                List<IFood> foods = new List<IFood>();
                foreach (var item in myGarden)
                {
                    if (item is IFood)
                    {
                        foods.Add(item as IFood);
                    }
                }
                return foods;

            }
        }
        public List<IBeauty> Beauties
        {
            get
            {

                List<IBeauty> beauties = new List<IBeauty>();
                foreach (var item in myGarden)
                {
                    if (item is IBeauty)
                    {
                        beauties.Add(item as IBeauty);
                    }
                }
                return beauties;
            }
        }

        public Garden()
        {
            myGarden = new List<IGardenItems>();
        }

    }
}