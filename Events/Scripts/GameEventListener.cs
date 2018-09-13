using UnityEngine;
using UnityEngine.Events;

namespace SL.Events
{
	public class GameEventListener : MonoBehaviour
	{
		public GameEvent Event;
		public UnityEvent Response;

		private void OnEnable()
		{
			Event.Listeners += OnEventTriggered;
		}

		private void OnDisable()
		{
			Event.Listeners -= OnEventTriggered;
		}

		[InspectButton("Trigger Events", visibilityMode = InspectButtonAttribute.VisibilityMode.PlayModeOnly)]
		public void OnEventTriggered()
		{
			Response.Invoke();
		}

	}
}
