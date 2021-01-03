using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiBuffInfo : CVariable
	{
		[Ordinal(0)]  [RED("buffID")] public TweakDBID BuffID { get; set; }
		[Ordinal(1)]  [RED("timeRemaining")] public CFloat TimeRemaining { get; set; }

		public gameuiBuffInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}