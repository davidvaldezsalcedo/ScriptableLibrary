using UnityEngine;
using UnityEngine.Events;

namespace SL.Events
{
	public class GameEventListener : MonoBehaviour
	{
		public GameEvent Event;
		public UnityEvent Responses;

		private void OnEnable()
		{
			Event.Listeners += TriggerResponses;
		}

		private void OnDisable()
		{
			Event.Listeners -= TriggerResponses;
		}

		[InspectButton("Trigger Responses")]//, visibilityMode = InspectButtonAttribute.VisibilityMode.PlayModeOnly)]
		public void TriggerResponses()
		{
			Responses.Invoke();
		}

	}
}
