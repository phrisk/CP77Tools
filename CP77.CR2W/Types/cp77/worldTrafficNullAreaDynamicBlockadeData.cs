using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaDynamicBlockadeData : ISerializable
	{
		[Ordinal(0)]  [RED("nullAreasBlockades")] public CArray<worldTrafficNullAreaDynamicBlockade> NullAreasBlockades { get; set; }

		public worldTrafficNullAreaDynamicBlockadeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}