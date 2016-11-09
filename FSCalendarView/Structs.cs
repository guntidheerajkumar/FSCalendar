using System;
using ObjCRuntime;

namespace FSCalendarView
{
	
	public enum FSCalendarFlow : int
	{
		Vertical,
		Horizontal
	}

	
	public enum FSCalendarCellShape : int
	{
		Circle = 0,
		Rectangle = 1
	}

	
	public enum FSCalendarUnit : int
	{
		Month,
		WeekOfYear,
		Day
	}

	
	public enum FSCalendarCellState : int
	{
		Normal = 0,
		Selected = 1,
		Placeholder = 1 << 1,
		Disabled = 1 << 2,
		Today = 1 << 3,
		Weekend = 1 << 4,
		TodaySelected = Today | Selected
	}

	
	public enum FSCalendarCaseOptions : int
	{
		HeaderUsesDefaultCase = 0,
		HeaderUsesUpperCase = 1,
		WeekdayUsesDefaultCase = 0 << 4,
		WeekdayUsesUpperCase = 1 << 4,
		WeekdayUsesSingleUpperCase = 2 << 4
	}

	
	public enum FSCalendarSeparators : int
	{
		None = 0,
		InterRows = 1 << 0,
		InterColumns = 1 << 1,
		BelowWeekdays = 1 << 2
	}

	
	public enum FSCalendarScope : int
	{
		Month,
		Week
	}

	
	public enum FSCalendarScrollDirection : int
	{
		Vertical,
		Horizontal
	}

	
	public enum FSCalendarPlaceholderType : int
	{
		None = 0,
		FillHeadTail = 1,
		FillSixRows = 2
	}

	
	public enum FSCalendarMonthPosition : int
	{
		Previous,
		Current,
		Next,
		OutOfBounds,
		NotFound
	}

	
	public enum FSCalendarTransition : int
	{
		None,
		MonthToWeek,
		WeekToMonth
	}

	
	public enum FSCalendarTransitionState : int
	{
		dle,
		nProgress
	}
}
