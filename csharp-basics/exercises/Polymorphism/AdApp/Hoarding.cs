namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _numDays;
        private int _rate;
        private bool _primeLoc;

        public Hoarding(int fee, int days, int rate, bool primeLoc = false) : base(fee)
        {
            _numDays = days;
            _rate = rate;
            _primeLoc = primeLoc;
        }

        public override int Cost()
        {
            return (int)(_primeLoc ? base.Cost() + _numDays * 24 * _rate * 1.5 : base.Cost() + _numDays * 24 * _rate);
        }

        public override string ToString()
        {
            return "\nHoarding: Cost= " + Cost();
        }
    }
}