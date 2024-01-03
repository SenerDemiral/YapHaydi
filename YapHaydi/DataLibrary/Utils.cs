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
		var gun = date?.Date.Subtract(DateTime.Now).Days;
		if (gun == 0)
		{
			res = $"bugün {date?.Hour}";
		}
		else if (gun < 0)
		{
			if (gun == -1)
				res = $"dün {date?.Hour}";
			else
				res = $"{-gun} gün önce";
		}
		else
		{
			if (gun == 1)
				res = $"yarın {date?.Hour}";
			else
				res = $"{gun} gün sonra";
		}

		return res;
	}
}
