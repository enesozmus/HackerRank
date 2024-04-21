/*
    → Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.

    → 12:00:00AM on a 12-hour clock is  → 00:00:00 on a 24-hour clock.
    → 12:00:00PM on a 12-hour clock is  → 12:00:00 on a 24-hour clock.

    s = '12:01:00PM'.
        → Return '12:01:00'.
    s = '12:01:00AM'.
        → Return '00:01:00'.
*/

using System.Globalization;

string _word = "12:01:00AM";

Console.WriteLine(timeConversion(_word));


static string timeConversion(string s)
{
    // var _dt = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
    // return $"{_dt:HH:mm:ss}";
    
    string hh = s.Substring(0, 2);
    string mm = s.Substring(3, 2);
    string ss = s.Substring(6, 2);
    string AMorPM = s.Substring(8, 2);

    int hhInt = Convert.ToInt32(hh);

    if (AMorPM.Equals("AM") && hh == "12")
    {
        hh = "00";
    }
    else if (AMorPM.Equals("PM") && hh == "12")
    {

    }
    else if (AMorPM.Equals("PM") && hhInt < 12)
    {
        hhInt += 12;
        hh = hhInt.ToString();
    }
    return $"{hh}:{mm}:{ss}";
}

/*
    + Given a time in 12-hour AM/PM format      → 12 saatlik AM/PM formatındaki bir zaman verildiğinde
    + convert ... to _                          → ...yı _ya dönüştürmek
*/
