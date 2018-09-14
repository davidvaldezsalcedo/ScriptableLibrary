using UnityEngine;
using UnityEngine.Events;

namespace SL.Variables
{

	public abstract class OnRefVariableChanged<T, RefVar, UEvent>
		: MonoBehaviour
			where RefVar : RefVariable<T>
			where UEvent : UnityEvent<T>
	{
		[SerializeField]
		protected RefVar _RefVar;

		[SerializeField]
		protected UEvent _Responses;

		[SerializeField]
		protected bool _TriggerOnEnable = false;

		protected void OnEnable()
		{
			_RefVar.OnValueChanged += TriggerResponses;
			if(_TriggerOnEnable)
			{
				TriggerResponses();
			}
		}

		protected void OnDisable()
		{
			_RefVar.OnValueChanged -= TriggerResponses;
		}

		[InspectButton("Trigger Responses")]
		public void TriggerResponses()
		{
			_Responses.Invoke(_RefVar.Value);
		}

	}

}
