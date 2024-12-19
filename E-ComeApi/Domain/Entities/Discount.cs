using Domain.Common;

namespace Domain.Entities
{
    public class Discount : BaseEntity
    {
        public string Name { get; set; }
        public int Percent { get; set; }
    }
}
