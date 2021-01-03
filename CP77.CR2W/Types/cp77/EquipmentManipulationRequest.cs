using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EquipmentManipulationRequest : IScriptable
	{
		[Ordinal(0)]  [RED("equipAnim")] public CEnum<gameEquipAnimationType> EquipAnim { get; set; }
		[Ordinal(1)]  [RED("requestSlot")] public CEnum<EquipmentManipulationRequestSlot> RequestSlot { get; set; }
		[Ordinal(2)]  [RED("requestType")] public CEnum<EquipmentManipulationRequestType> RequestType { get; set; }

		public EquipmentManipulationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}