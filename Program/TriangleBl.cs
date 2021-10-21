namespace TriangleDetermination
{
    public class TriangleBl
    {
        private bool AllSidesEqual(int side1, int side2, int side3) => (side1 + side2) == side3 * 2;

        public TriangleEnum DetermineType(int side1, int side2, int side3)
        {
            if(AllSidesEqual(side1, side2, side3))
            {
                return TriangleEnum.Iquilateral;
            }


            if(side1 == side2)
            {
                return TriangleEnum.Isosceles;
            }


            return TriangleEnum.Scalene;
        }
    }
}