using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GlobalLightingTrajectoryOverride : CVariable
	{
		[Ordinal(0)]  [RED("latitude")] public CFloat Latitude { get; set; }
		[Ordinal(1)]  [RED("moonRotationOffset")] public CFloat MoonRotationOffset { get; set; }
		[Ordinal(2)]  [RED("overrideScale")] public CFloat OverrideScale { get; set; }
		[Ordinal(3)]  [RED("sunRotationOffset")] public CFloat SunRotationOffset { get; set; }
		[Ordinal(4)]  [RED("timeOfYearSeason")] public CEnum<ETimeOfYearSeason> TimeOfYearSeason { get; set; }

		public GlobalLightingTrajectoryOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}