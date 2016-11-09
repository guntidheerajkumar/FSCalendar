# FSCalendar

This is a Obj-C xamarin binding project based on https://github.com/WenchaoD/FSCalendar.

### Usage

```
var calendar = new FSCalendar();
calendar.DataSource = new CalendarDataSource();
calendar.Delegate = new CalendarDelegate();
calendar.Frame = new CGRect(0, 50, this.View.Bounds.Width, 300);
this.View.AddSubview(calendar);
calendar.ScopeGesture.Enabled = true;
calendar.ReloadData();
```

### Delegate

```
public class CalendarDelegate : FSCalendarDelegate
{
	public override void Calendar(FSCalendar calendar, CGRect bounds, bool animated)
	{
		var calendarFrame = calendar.Frame;
		calendarFrame.Size = bounds.Size;
		calendar.Frame = calendarFrame;
	}

	public override void DidSelectDate(FSCalendar calendar, NSDate date)
	{
		Console.WriteLine(date);
	}
}
```

### Datasource 

```
public class CalendarDataSource : FSCalendarDataSource
{
	public override UIImage ImageForDate(FSCalendar calendar, NSDate date)
	{
		DateTime reference = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(2001, 1, 1, 0, 0, 0));
		var d = reference.AddSeconds(date.SecondsSinceReferenceDate);
		if (d.Date == new DateTime(2016, 11, 17)) {
			return UIImage.FromBundle("cake");
		}
		return new UIImage();
	}
}
```
