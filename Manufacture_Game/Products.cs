using System;
namespace Manufacture_Game
{
    
    public class Products
    {
        public string _name;
        public string _patentType;
        public int _price;
        public int _quantatiy;

        public Products()
        {
        }

        public int Cost()
        {
            // Return the total cost of the product
            return _price * _quantatiy;
        }
    }
}
