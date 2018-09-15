using UnityEngine;
using UnityEditor;

namespace SL.Variables
{
	[CustomPropertyDrawer(typeof(BoolVariable))]
	[CustomPropertyDrawer(typeof(ByteVariable))]
	[CustomPropertyDrawer(typeof(UShortVariable))]
	[CustomPropertyDrawer(typeof(UIntVariable))]
	[CustomPropertyDrawer(typeof(ULongVariable))]
	[CustomPropertyDrawer(typeof(SByteVariable))]
	[CustomPropertyDrawer(typeof(ShortVariable))]
	[CustomPropertyDrawer(typeof(IntVariable))]
	[CustomPropertyDrawer(typeof(LongVariable))]
	[CustomPropertyDrawer(typeof(FloatVariable))]
	[CustomPropertyDrawer(typeof(DoubleVariable))]
	[CustomPropertyDrawer(typeof(Vector2Variable))]
	[CustomPropertyDrawer(typeof(Vector3Variable))]
	[CustomPropertyDrawer(typeof(QuaternionVariable))]
	[CustomPropertyDrawer(typeof(StringVariable))]
	public class BoolVariableDrawer : PropertyDrawer
	{

		public override void OnGUI(Rect pos, SerializedProperty prop, GUIContent lbl)
		{
			SerializedProperty constRefIndex = prop.FindPropertyRelative("UseConstant");
			SerializedProperty constVal = prop.FindPropertyRelative("ConstantValue");
			SerializedProperty refVar = prop.FindPropertyRelative("ReferenceVar");

			EditorGUI.BeginProperty(pos, lbl ,prop);


				int indentLvl = EditorGUI.indentLevel;
				EditorGUI.indentLevel = 0;

				int index = constRefIndex.boolValue ? 0 : 1;

				pos.width -= 28;
				EditorGUI.PropertyField(pos, index == 0 ? constVal : refVar, lbl);

				string[] tagArr = new string[2] {"Constant","RefVariable"};
				index = EditorGUI.Popup(new Rect(pos.width + 24, pos.y, 16, pos.height), "", index, tagArr);
				constRefIndex.boolValue = index == 0;

				EditorGUI.indentLevel = indentLvl;

			EditorGUI.EndProperty();
		}
	}
}
