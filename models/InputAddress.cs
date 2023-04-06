using System.ComponentModel.DataAnnotations;

namespace NewEra.PolicyholderV2.Models
{
	public class InputAddress
	{
		[Required, MaxLength(100)]
		[Display(Name = "AddressL 1")]
		public string AddressL1 { get; set; }
		public string AddressL2 { get; set; }
		public string AddressL3 { get; set; }
		[Required, MaxLength(50)]
		public string City { get; set; }
		[Required]
		public string State { get; set; }
		[Required, MaxLength(35)]
		[Display(Name = "Country")]
		public string Country { get; set; }
		[Required, MaxLength(20)]
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
