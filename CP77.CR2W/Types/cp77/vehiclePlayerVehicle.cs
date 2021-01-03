using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehiclePlayerVehicle : CVariable
	{
		[Ordinal(0)]  [RED("isUnlocked")] public CBool IsUnlocked { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(2)]  [RED("recordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(3)]  [RED("vehicleType")] public CEnum<gamedataVehicleType> VehicleType { get; set; }

		public vehiclePlayerVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}