using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkInputDevicesMappingsJSON : CVariable
	{
		[Ordinal(0)]  [RED("devices")] public CArray<CName> Devices { get; set; }
		[Ordinal(1)]  [RED("mappings")] public CArray<inkInputIconMappingJSON> Mappings { get; set; }

		public inkInputDevicesMappingsJSON(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}