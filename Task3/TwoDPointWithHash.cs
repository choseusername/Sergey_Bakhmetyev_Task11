namespace Task3
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }

        public override int GetHashCode()
        {
            // Overflow int
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x;
                hash = hash * 23 + y;
                return hash;
            }
        }
    }
}
