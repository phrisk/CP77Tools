using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StreetNameSelector : StreetSignSelector
	{
		[Ordinal(0)]  [RED("recordID")] public TweakDBID RecordID { get; set; }

		public StreetNameSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}