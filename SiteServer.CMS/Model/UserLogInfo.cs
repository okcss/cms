using System;
using SiteServer.Plugin;

namespace SiteServer.CMS.Model
{
	public class UserLogInfo: ILogInfo
    {
        public UserLogInfo(int id, string userName, string ipAddress, DateTime addDate, string action, string summary) 
		{
            Id = id;
            UserName = userName;
            IpAddress = ipAddress;
            AddDate = addDate;
            Action = action;
            Summary = summary;
		}

        public int Id { get; set; }

	    public string UserName { get; set; }

	    public string IpAddress { get; set; }

	    public DateTime AddDate { get; set; }

	    public string Action { get; set; }

	    public string Summary { get; set; }
	}
}
