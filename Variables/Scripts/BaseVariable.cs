using UnityEngine;

namespace SL.Variables
{
	[System.Serializable]
	public abstract class BaseVariable<T, RefVar> where RefVar : RefVariable<T>
	{
		public bool UseConstant = false;
		public T ConstantValue;
		public RefVar ReferenceVar;

		public T Value
		{
			get
			{
				return UseConstant ? ConstantValue : ReferenceVar.Value;
			}

			set
			{
				if(UseConstant)
				{
					ConstantValue = value;
				}
				else
				{
					ReferenceVar.Value = value;
				}
			}
		}
	}

	[System.Serializable]
	public class BoolVariable : BaseVariable<bool, RefBool> { }

	[System.Serializable]
	public class ByteVariable : BaseVariable<byte, RefByte> { }

	[System.Serializable]
	public class UShortVariable : BaseVariable<ushort, RefUShort> { }

	[System.Serializable]
	public class UIntVariable : BaseVariable<uint, RefUInt> { }

	[System.Serializable]
	public class ULongVariable : BaseVariable<ulong, RefULong> { }

	[System.Serializable]
	public class SByteVariable : BaseVariable<sbyte, RefSByte> { }

	[System.Serializable]
	public class ShortVariable : BaseVariable<short, RefShort> { }

	[System.Serializable]
	public class IntVariable : BaseVariable<int, RefInt> { }

	[System.Serializable]
	public class LongVariable : BaseVariable<long, RefLong> { }

	[System.Serializable]
	public class FloatVariable : BaseVariable<float, RefFloat> { }

	[System.Serializable]
	public class DoubleVariable : BaseVariable<double, RefDouble> { }

	[System.Serializable]
	public class Vector2Variable : BaseVariable<Vector2, RefVector2> { }

	[System.Serializable]
	public class Vector3Variable : BaseVariable<Vector3, RefVector3> { }

	[System.Serializable]
	public class QuaternionVariable : BaseVariable<Quaternion, RefQuaternion> { }

	[System.Serializable]
	public class StringVariable : BaseVariable<string, RefString> { }
}
