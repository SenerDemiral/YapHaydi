namespace YapHaydi.DataLibrary;

public class Utils
{
	public static string Moment(DateTime? date)
	{
		string res = default;


		if (date == null)
		{
			return "";
		}
		//var gun = DateTime.Now.Date.Subtract((DateTime)(date?.Date)).Days;
		var gun = date?.Date.Subtract(DateTime.Now.Date).Days;
		var zmn = date!.Value.TimeOfDay.ToString(@"hh\:mm");
		if (gun == 0)
		{
			res = $"bugün {zmn}";
		}
		else if (gun < 0)
		{
			if (gun == -1)
				res = $"dün {zmn}";
			else
				res = $"{-gun} gün önce";
		}
		else
		{
			if (gun == 1)
				res = $"yarın {zmn}";
			else
				res = $"{gun} gün sonra";
		}

		return res;
	}
}
