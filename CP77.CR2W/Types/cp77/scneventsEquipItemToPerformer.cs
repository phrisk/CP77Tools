using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsEquipItemToPerformer : scnSceneEvent
	{
		[Ordinal(0)]  [RED("itemId")] public TweakDBID ItemId { get; set; }
		[Ordinal(1)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(2)]  [RED("slotId")] public TweakDBID SlotId { get; set; }

		public scneventsEquipItemToPerformer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}