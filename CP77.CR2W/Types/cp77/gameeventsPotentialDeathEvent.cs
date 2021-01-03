using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameeventsPotentialDeathEvent : redEvent
	{
		[Ordinal(0)]  [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }

		public gameeventsPotentialDeathEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}