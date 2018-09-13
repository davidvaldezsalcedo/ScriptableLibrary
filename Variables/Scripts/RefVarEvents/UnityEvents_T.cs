using UnityEngine;
using UnityEngine.Events;

namespace SL.Variables
{

	[System.Serializable]
	public class UEvent_Bool : UnityEvent<bool> {}

	[System.Serializable]
	public class UEvent_Byte : UnityEvent<byte> {}

	[System.Serializable]
	public class UEvent_UShort: UnityEvent<ushort> {}

	[System.Serializable]
	public class UEvent_UInt: UnityEvent<uint> {}

	[System.Serializable]
	public class UEvent_ULong: UnityEvent<ulong> {}

	[System.Serializable]
	public class UEvent_SByte: UnityEvent<sbyte> {}

	[System.Serializable]
	public class UEvent_Short: UnityEvent<short> {}

	[System.Serializable]
	public class UEvent_Int: UnityEvent<int> {}

	[System.Serializable]
	public class UEvent_Long: UnityEvent<long> {}

	[System.Serializable]
	public class UEvent_Float : UnityEvent<float> {}

	[System.Serializable]
	public class UEvent_Double : UnityEvent<double> {}

	[System.Serializable]
	public class UEvent_String : UnityEvent<string> {}

	[System.Serializable]
	public class UEvent_Vector2 : UnityEvent<Vector2> {}

	[System.Serializable]
	public class UEvent_Vector3 : UnityEvent<Vector3> {}

	[System.Serializable]
	public class UEvent_Quaternion : UnityEvent<Quaternion> {}

}
