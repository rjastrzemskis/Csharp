﻿namespace Hierarchy
{
    public abstract class Food
    {
        private int _quantity;

        public Food(int quantity)
        {
            _quantity = quantity;
        }

        public int GetSetQuantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

    }
}
