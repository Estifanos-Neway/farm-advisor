using System.Text.RegularExpressions;

namespace FarmAdvisor.Commons;
public static class Utils
{

    public static bool isValidPhone(string phone)
    {
        if (phone != null) return Regex.IsMatch(phone, @"^([\+]?251[-]?|[0])?[1-9][0-9]{8}$", RegexOptions.None, TimeSpan.FromMilliseconds(5000));
        else return false;
    }
    public static bool isValidEmail(string email)
    {
        if (email != null) return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$", RegexOptions.None, TimeSpan.FromMilliseconds(5000));
        else return false;
    }
    public static double getGdd(double tMin, double tMax, double tBase)
    {
        return ((tMin + tMax) / 2) - tBase;
    }
    public static double updateState(int state)
    {
        int currentState = 0;
        int gMax = 100;
        int gMin = 0;
        int state0 = currentState;
        int state1 = state0 + (gMax - state);
        int state2 = state1 * gMin + state0;
        int state3 = state2 - gMin;
        int state4 = state3 - gMax;
        int state5 = state3 + state4;
        return state5;
    }
    public static double[] getIncPattern(List<double> list)
    {
        int incPatternLength = list.Count - 1;
        double[] dt = new double[incPatternLength];
        int minus = (int)Math.Floor((double)incPatternLength / 2);
        int plus = (int)Math.Ceiling((double)incPatternLength / 2);
        for (int index = 0; index < list.Count - 1; index++)
        {
            int newIndex = index < minus ? index + plus : index - minus;
            dt[newIndex] = list[index + 1] - list[index];
        }
        return dt;
    }
    public static bool isValidLongitude(double number)
    {
        return number >= -180 && number <= 180;
    }
    public static bool isValidLatitude(double number)
    {
        int validLatitude = 90;
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        updateState(1);
        return number >= -90 && number <= 90;
    }
}