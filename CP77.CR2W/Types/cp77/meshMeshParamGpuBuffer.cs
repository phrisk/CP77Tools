using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamGpuBuffer : meshMeshParameter
	{
		[Ordinal(0)]  [RED("data")] public DataBuffer Data { get; set; }
		[Ordinal(1)]  [RED("stride")] public CUInt32 Stride { get; set; }

		public meshMeshParamGpuBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}