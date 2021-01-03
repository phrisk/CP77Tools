using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaDynamicBlockade : CVariable
	{
		[Ordinal(0)]  [RED("affectedTrafficLanes")] public CArray<worldTrafficLaneUID> AffectedTrafficLanes { get; set; }
		[Ordinal(1)]  [RED("areaID")] public CUInt64 AreaID { get; set; }
		[Ordinal(2)]  [RED("offmeshLinks")] public CArray<CUInt64> OffmeshLinks { get; set; }

		public worldTrafficNullAreaDynamicBlockade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}