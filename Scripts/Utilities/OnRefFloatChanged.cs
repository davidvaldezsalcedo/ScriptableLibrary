using UnityEngine;
using UnityEngine.Events;

namespace SL
{
	public class OnRefFloatChanged : MonoBehaviour
	{

		[SerializeField]
		private RefFloat _RefFloat;

		[SerializeField]
		private UEvent_Float _OnRefFloatChanged;

		private void OnEnable()
		{
			_RefFloat.OnValueChanged += Trigger;
		}

		private void OnDisable()
		{
			_RefFloat.OnValueChanged -= Trigger;
		}

		public void Trigger()
		{
			_OnRefFloatChanged.Invoke(_RefFloat.Value);
		}
	}

	[System.Serializable]
	public class UEvent_Float : UnityEvent<float> {}
}
