namespace NWC_Bills
{


    public class CustomComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            var xParts = x.Split('-');
            var yParts = y.Split('-');

            if (xParts.Length == 3 && yParts.Length == 3)
            {
                var xFirstNumber = int.Parse(xParts[0]);
                var yFirstNumber = int.Parse(yParts[0]);
                var xSecondNumber = int.Parse(xParts[1]);
                var ySecondNumber = int.Parse(yParts[1]);
                var xThirdNumber = int.Parse(xParts[2]);
                var yThirdNumber = int.Parse(yParts[2]);

                if (xFirstNumber != yFirstNumber)
                {
                    return yFirstNumber.CompareTo(xFirstNumber);
                }

                if (xSecondNumber != ySecondNumber)
                {
                    return ySecondNumber.CompareTo(xSecondNumber);
                }

                if (xThirdNumber != yThirdNumber)
                {
                    return yThirdNumber.CompareTo(xThirdNumber);
                }
            }

            return y.CompareTo(x);
        }
    }

}
