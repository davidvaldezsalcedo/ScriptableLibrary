﻿using UnityEngine;
using UnityEngine.Events;

namespace SL
{

	public abstract class OnRefVariableChanged<T, RefVar, UEvent>
		: MonoBehaviour
			where RefVar : RefVariable<T>
			where UEvent : UnityEvent<T>
	{
		[SerializeField]
		protected RefVar _RefVar;

		[SerializeField]
		protected UEvent _OnRefVarChanged;

		protected void OnEnable()
		{
			_RefVar.OnValueChanged += Trigger;
		}

		protected void OnDisable()
		{
			_RefVar.OnValueChanged -= Trigger;
		}

		public void Trigger()
		{
			_OnRefVarChanged.Invoke(_RefVar.Value);
		}

	}

}