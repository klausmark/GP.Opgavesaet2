namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    public class SquareMeterAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalArea(decimal universalArea)
        {
            return universalArea;
        }

        public decimal ConvertToUniversalArea(decimal area)
        {
            return area;
        }
    }
}