using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshSmartObjectUserData : worldOffMeshUserData
	{
		[Ordinal(0)]  [RED("localSpaceTrajectoryEndPoint")] public Vector3 LocalSpaceTrajectoryEndPoint { get; set; }
		[Ordinal(1)]  [RED("localSpaceTrajectoryStartPoint")] public Vector3 LocalSpaceTrajectoryStartPoint { get; set; }
		[Ordinal(2)]  [RED("nodeTransform")] public WorldTransform NodeTransform { get; set; }
		[Ordinal(3)]  [RED("smartObjectDefinition")] public CHandle<gameSmartObjectDefinition> SmartObjectDefinition { get; set; }
		[Ordinal(4)]  [RED("type")] public CEnum<worldOffMeshConnectionType> Type { get; set; }

		public worldOffMeshSmartObjectUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
