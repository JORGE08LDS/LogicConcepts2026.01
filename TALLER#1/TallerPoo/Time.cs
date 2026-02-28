using System;

public class Time
{
    private int hour;
    private int minute;
    private int second;
    private int millisecond;

    public int Hour
    {
        get { return hour; }
        set
        {
            hour = value;
            ValidateTime();
        }
    }

    public int Minute
    {
        get { return minute; }
        set
        {
            minute = value;
            ValidateTime();
        }
    }

    public int Second
    {
        get { return second; }
        set
        {
            second = value;
            ValidateTime();
        }
    }

    public int Millisecond
    {
        get { return millisecond; }
        set
        {
            millisecond = value;
            ValidateTime();
        }
    }

    // ===== CONSTRUCTORS =====

    public Time() : this(0, 0, 0, 0) { }

    public Time(int hour) : this(hour, 0, 0, 0) { }

    public Time(int hour, int minute) : this(hour, minute, 0, 0) { }

    public Time(int hour, int minute, int second) : this(hour, minute, second, 0) { }

    public Time(int hour, int minute, int second, int millisecond)
    {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
        this.millisecond = millisecond;

        ValidateTime();
    }

    // ===== VALIDATION =====

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

    // ===== METHODS =====

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
        int totalMs = this.ToMilliseconds() + other.ToMilliseconds();
        return totalMs >= 86400000; // 24 hours in milliseconds
    }

    public Time Add(Time other)
    {
        int totalMs = this.ToMilliseconds() + other.ToMilliseconds();

        totalMs %= 86400000; // Reset if next day

        int hr = totalMs / 3600000;
        totalMs %= 3600000;

        int min = totalMs / 60000;
        totalMs %= 60000;

        int sec = totalMs / 1000;
        int ms = totalMs % 1000;

        return new Time(hr, min, sec, ms);
    }
}
