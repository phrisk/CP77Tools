using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questForceTokenActivation_NodeSubType : questIContentTokenManager_NodeSubType
	{
		[Ordinal(0)]  [RED("forceCreatingToken")] public CBool ForceCreatingToken { get; set; }

		public questForceTokenActivation_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}