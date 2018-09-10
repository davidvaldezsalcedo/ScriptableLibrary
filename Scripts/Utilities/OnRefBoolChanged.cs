using UnityEngine;
using UnityEngine.Events;

namespace SL
{
	public class OnRefBoolChanged : MonoBehaviour
	{

		[SerializeField]
		private RefBool _RefBool;

		[SerializeField]
		private UEvent_Bool _OnRefBoolChanged;

		private void OnEnable()
		{
			_RefBool.OnValueChanged += Trigger;
		}

		private void OnDisable()
		{
			_RefBool.OnValueChanged -= Trigger;
		}

		public void Trigger()
		{
			_OnRefBoolChanged.Invoke(_RefBool.Value);
		}
	}

	[System.Serializable]
	public class UEvent_Bool : UnityEvent<bool> {}
}
