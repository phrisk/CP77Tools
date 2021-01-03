using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_PlaySound : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)]  [RED("soundName")] public CName SoundName { get; set; }
		[Ordinal(1)]  [RED("unique")] public CBool Unique { get; set; }

		public gameTransformAnimation_PlaySound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}