using System;
namespace Manufacture_Game
{
    public class Prospects
    {
        public string Name { get; set; }

        public int LeveleRequirement { get; set; }

        //public string[] FullFillmentList { get; set; }

        public Prospects(string name, int levelRequirement)
        {
            Name = name;
            LeveleRequirement = levelRequirement;
            //FullFillmentList = fullFillmentList;
        }

        
    }
}
