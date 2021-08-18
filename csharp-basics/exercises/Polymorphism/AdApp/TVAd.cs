namespace AdApp
{
    public class TVAd : Advert
    {
        private int _sec;
        private int _rate;
        private bool _peak;

        public TVAd(int fee, int sec, int rate, bool peak) : base(fee)
        {
            _sec = sec;
            _rate = rate;
            _peak = peak;
        }

        public override int Cost()
        {
            return base.Cost() + _sec * (_peak ? _rate * 2 : _rate);
        }

        public override string ToString()
        {
            return "\nTV Advert: Cost= " + Cost();
        }
    }
}