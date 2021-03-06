using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EmitterDelaySettings : CVariable
	{
		[Ordinal(0)]  [RED("emitterDelay")] public CFloat EmitterDelay { get; set; }
		[Ordinal(1)]  [RED("emitterDelayLow")] public CFloat EmitterDelayLow { get; set; }
		[Ordinal(2)]  [RED("useEmitterDelayOnce")] public CBool UseEmitterDelayOnce { get; set; }
		[Ordinal(3)]  [RED("useEmitterDelayRange")] public CBool UseEmitterDelayRange { get; set; }

		public EmitterDelaySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
