using UnityEngine;
using SL.Variables;

public class VariableTester : MonoBehaviour
{

	[SerializeField]
	private BoolVariable _BoolVar;

	[SerializeField]
	private FloatVariable _FloatVar;

	[SerializeField]
	private Vector3Variable _V3Var;

	[SerializeField]
	private int _XOffset = 300;

	private void OnGUI()
	{
		GUILayout.BeginHorizontal();
			GUILayout.Space(_XOffset);
			GUILayout.BeginVertical();
				GUILayout.Label(_BoolVar.Value.ToString());
				GUILayout.Label(_FloatVar.Value.ToString());
				GUILayout.Label(_V3Var.Value.ToString());
			GUILayout.EndVertical();
		GUILayout.EndHorizontal();
	}

}
