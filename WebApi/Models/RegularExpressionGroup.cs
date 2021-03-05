using System.Collections.Generic;

namespace WebApi.Models
{
    public class RegularExpressionGroup
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public List<RegularExpression> RegularExpressions { get; set; }
        public string PreviewBeforeConversion { get; set; }
        public string PreviewAfterConversion { get; set; }
    }
}
