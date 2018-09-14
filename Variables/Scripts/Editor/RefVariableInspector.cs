using UnityEditor;
using UnityEngine;

namespace SL.Variables
{

	public class RefVariableInspector<T> : Editor
	{
		protected RefVariable<T> refVar;

		protected void OnEnable()
		{
			refVar = (RefVariable<T>)target;
		}

		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			EditorGUILayout.Space();

			if (GUILayout.Button("Trigger"))
			{
				refVar.Value = refVar.Value;
			}
		}
	}

	[CustomEditor(typeof(RefBool))]
	public class RefBoolInspector : RefVariableInspector<bool> {}
	
	[CustomEditor(typeof(RefByte))]
	public class RefByetInspector : RefVariableInspector<byte> {}

	[CustomEditor(typeof(RefUShort))]
	public class RefUShortInspector : RefVariableInspector<ushort> {}
	
	[CustomEditor(typeof(RefUInt))]
	public class RefUIntInspector : RefVariableInspector<uint> {}
	
	[CustomEditor(typeof(RefULong))]
	public class RefULongInspector : RefVariableInspector<ulong> {}

	[CustomEditor(typeof(RefSByte))]
	public class RefSByetInspector : RefVariableInspector<sbyte> {}

	[CustomEditor(typeof(RefShort))]
	public class RefShortInspector : RefVariableInspector<short> {}
	
	[CustomEditor(typeof(RefInt))]
	public class RefIntInspector : RefVariableInspector<int> {}
	
	[CustomEditor(typeof(RefLong))]
	public class RefLongInspector : RefVariableInspector<long> {}
	
	[CustomEditor(typeof(RefFloat))]
	public class RefFloatInspector : RefVariableInspector<float> {}
	
	[CustomEditor(typeof(RefDouble))]
	public class RefDoubleInspector : RefVariableInspector<double> {}
	
	[CustomEditor(typeof(RefVector2))]
	public class RefVector2Inspector : RefVariableInspector<Vector2> {}
	
	[CustomEditor(typeof(RefVector3))]
	public class RefVector3Inspector : RefVariableInspector<Vector3> {}
	
	[CustomEditor(typeof(RefQuaternion))]
	public class RefQuaternionInspector : RefVariableInspector<Quaternion> {}
	
	[CustomEditor(typeof(RefString))]
	public class RefStringInspector : RefVariableInspector<string> {}
}
