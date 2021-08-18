namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int column , int rate) : base(fee)
        {
            _column = column;
            _rate = rate;
        }

        public override int Cost()
        {
            return base.Cost() + _column * _rate;
        }

        public override string ToString()
        {
            return "\nNewsPaper: Cost= " + Cost();
        }
    }
}