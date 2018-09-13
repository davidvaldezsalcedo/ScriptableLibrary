using System.Reflection;
using UnityEditor;
using UnityEngine;

public class QuaternionParameterDrawer : MethodParameterDrawer
{
	public override void InitializeParameter(ref object param, ParameterInfo propertyInfo)
	{
		param = Quaternion.identity;
	}

	public override void DrawParameter(ref object param, ParameterInfo propertyInfo)
	{
		param = EditorGUILayout.Vector4Field(ObjectNames.NicifyVariableName(propertyInfo.Name), (Vector4)param);
	}
}
