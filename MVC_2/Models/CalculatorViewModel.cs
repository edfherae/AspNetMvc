using System.ComponentModel.DataAnnotations;

namespace MVC_2.Models
{
	public class CalculatorViewModel
	{
		//System.ComponentModel.DataAnnotations ?
		// datatype.custom
		[Required]
		//[RegularExpression("\\d{1,}.\\d{1,}")]
		public double A { get; set; }
		[Required]
		public string Operation { get; set; }
		[Required]
		//[RegularExpression("\\d{1,}.\\d{1,}")]
		public double B { get; set; }
		public string? Result { get; set; }
	}
}
