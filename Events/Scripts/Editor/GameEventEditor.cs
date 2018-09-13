using UnityEngine;
using UnityEditor;

namespace SL.Events
{
	[CustomEditor(typeof(GameEvent))]
	public class GameEventEditor : Editor
	{

		private GameEvent _GameEvent;

		private void OnEnable()
		{
			_GameEvent = (GameEvent)target;
		}

		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			EditorGUILayout.Space();
			if(GUILayout.Button("Trigger Event"))
			{
				_GameEvent.Trigger();
			}
			
		}
	}
}
