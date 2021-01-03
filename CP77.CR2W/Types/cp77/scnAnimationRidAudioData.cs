using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnAnimationRidAudioData : ISerializable
	{
		[Ordinal(0)]  [RED("events")] public CArray<CHandle<animAnimEvent>> Events { get; set; }

		public scnAnimationRidAudioData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}