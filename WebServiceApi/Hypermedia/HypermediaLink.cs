using System.Text;

namespace WebServiceApi.Hypermedia
{
    public class HypermediaLink
    {
        public string Rel { get; set; }
        public string Href
        {
            get
            {
                object _lock = new object(); //condições de paralelismo
                lock (_lock)
                {
                    StringBuilder sb = new StringBuilder(href);
                    return sb.Replace("%2F", "/").ToString();
                }
            }
            set { href = value; }
        }

        private string href;
        public string Type { get; set; }
        public string Action { get; set; }
    }
}
    