using System;

public class Time
{
    private int hour;
    private int minute;
    private int second;
    private int millisecond;

    // Constructor 1: no parameters
    public Time() : this(0, 0, 0, 0) { }

    // Constructor 2: hour
    public Time(int hour) : this(hour, 0, 0, 0) { }

    // Constructor 3: hour and minute
    public Time(int hour, int minute) : this(hour, minute, 0, 0) { }

    // Constructor 4: hour, minute and second
    public Time(int hour, int minute, int second) : this(hour, minute, second, 0) { }

    // Constructor 5: full constructor
    public Time(int hour, int minute, int second, int millisecond)
    {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
        this.millisecond = millisecond;

        ValidateTime();
    }

    private void ValidateTime()
    {
        if (hour < 0 || hour > 23)
            throw new ArgumentException($"The hour: {hour}, is not valid.");

        if (minute < 0 || minute > 59)
            throw new ArgumentException("Invalid minute");

        if (second < 0 || second > 59)
            throw new ArgumentException("Invalid second");

        if (millisecond < 0 || millisecond > 999)
            throw new ArgumentException("Invalid millisecond");
    }

    public override string ToString()
    {
        int displayHour = hour % 12;
        if (displayHour == 0)
            displayHour = 12;

        string period = hour < 12 ? "AM" : "PM";

        return $"{displayHour:D2}:{minute:D2}:{second:D2}.{millisecond:D3} {period}";
    }

    public int ToMilliseconds()
    {
        return (((hour * 60 + minute) * 60 + second) * 1000 + millisecond);
    }

    public int ToSeconds()
    {
        return ((hour * 60 + minute) * 60 + second);
    }

    public int ToMinutes()
    {
        return (hour * 60 + minute);
    }

    public bool IsOtherDay(Time other)
    {
        int totalHours = hour + other.hour;
        int totalMinutes = minute + other.minute;
        int totalSeconds = second + other.second;
        int totalMilliseconds = millisecond + other.millisecond;

        if (totalMilliseconds > 999) totalSeconds++;
        if (totalSeconds > 59) totalMinutes++;
        if (totalMinutes > 59) totalHours++;

        return totalHours > 23;
    }

    public Time Add(Time other)
    {
        int ms = millisecond + other.millisecond;
        int sec = second + other.second;
        int min = minute + other.minute;
        int hr = hour + other.hour;

        if (ms > 999)
        {
            sec++;
            ms -= 1000;
        }

        if (sec > 59)
        {
            min++;
            sec -= 60;
        }

        if (min > 59)
        {
            hr++;
            min -= 60;
        }

        if (hr > 23)
        {
            hr -= 24;
        }

        return new Time(hr, min, sec, ms);
    }
}
