namespace portal.api.Shared.Parameters
{
    public abstract class SiteCodeParameter
    {
      
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public string LoginMode { get; set; }
        public string Stime { get; set; }
        public string RequiredWorkedHrs { get; set; }
        public string SiteNameAr { get; set; }
        public string PayrollEmail { get; set; }
        public string Etime { get; set; }
    }
    public class CreateSiteParameter : SiteCodeParameter { }
    public class UpdateSiteParameter : SiteCodeParameter
    {
        public int Id { get; set; }
    }
}
