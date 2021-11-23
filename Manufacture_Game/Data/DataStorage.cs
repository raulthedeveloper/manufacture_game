using System;
namespace Manufacture_Game
{
    public class DataStorage
    {
        public object[] ProspectList { get; set; }

        public object[] ProductStoreList { get; set; }

        public DataStorage()
        {
        }

        public Prospects[] CreateProspectList()
        {
            string[] companyNames = { "Walmart", "Weis", "Scotts Goods", "Target","Mikes Hardware","Krystal's Catering","Viagon","Venerable", "K-Mart","M-Mart" };
            


            Prospects[] prospects;
            prospects = new Prospects[10];

            for(int i = 0; i < prospects.Length; i++)
            {
                prospects[i] = new Prospects(companyNames[i],2);
            }

            return prospects;
        }

        public void SaveData()
        {

            //saves data to json file or database

        }

        public void GetData()
        {
            //gets data from json file or database
        }
    }
}
