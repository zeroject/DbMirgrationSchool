using EFGetStarted.Models;

namespace EFGetStarted;

public class ProductRating
{
    public int ProductRatingId { get; set; }
    public virtual Product Product { get; set; }
    public float Rating { get; set; }
    public DateTime RatedOn { get; set; }
}
