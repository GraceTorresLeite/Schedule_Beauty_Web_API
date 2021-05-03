using System.Collections.Generic;

namespace WebServiceApi.Hypermedia.Abstract
{
    public interface ISupportsHypermedia
    {
        List<HypermediaLink> Links { get; set; }
    }
}
