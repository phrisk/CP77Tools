using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendingMachineSFX : CVariable
	{
		[Ordinal(0)]  [RED("glitchingStart")] public CName GlitchingStart { get; set; }
		[Ordinal(1)]  [RED("glitchingStop")] public CName GlitchingStop { get; set; }

		public VendingMachineSFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}