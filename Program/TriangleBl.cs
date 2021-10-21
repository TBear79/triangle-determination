namespace TriangleDetermination
{
    public static class TriangleBl
    {
        private static bool AllSidesEqual(int side1, int side2, int side3) => side1 == side2 && side2 == side3;
        private static bool TwoSidesEqual(int side1, int side2, int side3) => side1 == side2;

        public static TriangleEnum DetermineType(int side1, int side2, int side3)
        {
            if(AllSidesEqual(side1, side2, side3))
            {
                return TriangleEnum.Iquilateral;
            }


            if(TwoSidesEqual(side1, side2, side3))
            {
                return TriangleEnum.Isosceles;
            }

            return TriangleEnum.Scalene;
        }
    }
}