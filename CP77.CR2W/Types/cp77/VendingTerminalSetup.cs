using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendingTerminalSetup : CVariable
	{
		[Ordinal(0)]  [RED("timeToCompletePurchase")] public CFloat TimeToCompletePurchase { get; set; }
		[Ordinal(1)]  [RED("vendingBlacklist")] public CArray<CEnum<EVendorMode>> VendingBlacklist { get; set; }
		[Ordinal(2)]  [RED("vendorTweakID")] public TweakDBID VendorTweakID { get; set; }

		public VendingTerminalSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}