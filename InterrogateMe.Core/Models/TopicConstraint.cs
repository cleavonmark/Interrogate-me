using System.ComponentModel.DataAnnotations;

namespace InterrogateMe.Core.Models
{
    public enum TopicConstraint
    {
        [Display(Name="No Constraint")]
        None = 0,
        [Display(Name="Time Constraint")]
        Time = 1 << 0,
        [Display(Name="Quantity Constraint")]
        Quantity = 1 << 1
    }
}
