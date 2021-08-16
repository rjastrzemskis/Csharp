namespace AdApp
{
    class Poster : Advert
    {
        private int _width;
        private int _height;
        private int _copies;
        private int _cost;

        public Poster(int fee, int width, int height, int copies, int cost) : base(fee)
        {
            _width = width;
            _height = height;
            _copies = copies;
            _cost = cost;
        }

        public override int Cost()
        {
            return base.Cost() + _width + _height + _copies * _cost;
        }

        public override string ToString()
        {
            return "\nPoster: Cost= " + Cost();
        }
    }
}
