namespace SpaceAcademy;

public static class LaunchPrice
{
 
 /*   public static int Calculate(int headCount, bool hasPriority)
    {
        int calculatedPrice = 0;
        if (hasPriority)
        {
            calculatedPrice = n/headCount * 100;
            calculatedPrice = calculatedPrice + headCount * 20;
        }
        else
        {
            calculatedPrice = headCount * 100;
        }
        return calculatedPrice;
    }
*/
    public static int newCalculate(int headCount, bool hasPriority)
    {
        int calculatedPrice = headCount * 100;
        if (hasPriority) {calculatedPrice = calculatedPrice + headCount * 20;}
        return calculatedPrice;
    }
}
