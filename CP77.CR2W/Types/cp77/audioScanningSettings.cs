using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioScanningSettings : CVariable
	{
		[Ordinal(0)]  [RED("scanningAvailableEvent")] public CName ScanningAvailableEvent { get; set; }
		[Ordinal(1)]  [RED("scanningCompleteEvent")] public CName ScanningCompleteEvent { get; set; }
		[Ordinal(2)]  [RED("scanningStartEvent")] public CName ScanningStartEvent { get; set; }
		[Ordinal(3)]  [RED("scanningStopEvent")] public CName ScanningStopEvent { get; set; }

		public audioScanningSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}