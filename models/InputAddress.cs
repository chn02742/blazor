using System.ComponentModel.DataAnnotations;

namespace NewEra.PolicyholderV2.Models
{
	public class InputAddress
	{
		[Required]
		public string AddressL1 { get; set; }
		public string AddressL2 { get; set; }
		public string AddressL3 { get; set; }
		[Required]
		public string City { get; set; }
		[Required]
		public string State { get; set; }
		[Required]
		[Display(Name = "Country")]
		public string Country { get; set; }
		[Required]
		[Display(Name = "Postal Code")]
		public string PostalCode { get; set; }
	}
	
	public enum UpdateType
	{
		Cancel,
		AddCancel,
		EditCancel
	}
}
