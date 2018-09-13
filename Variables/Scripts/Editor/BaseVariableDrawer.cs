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

				string[] tagArr = new string[2] {"Constant","RefVariable"};

				int indentLvl = EditorGUI.indentLevel;
				EditorGUI.indentLevel = 0;

				pos = EditorGUI.PrefixLabel(pos, GUIUtility.GetControlID(FocusType.Passive), lbl);
				
				int index = constRefIndex.boolValue ? 0 : 1;
				index = EditorGUI.Popup(new Rect(pos.x, pos.y, 16, pos.height), "", index, tagArr);
				constRefIndex.boolValue = index == 0;
				pos.width -= 24;
				pos.x += 24;

				if(index == 0)
				{
					EditorGUI.PropertyField(pos, constVal, GUIContent.none);
				}
				else
				{
					EditorGUI.PropertyField(pos, refVar, GUIContent.none);
				}

				EditorGUI.indentLevel = indentLvl;

			EditorGUI.EndProperty();
		}
	}
}
