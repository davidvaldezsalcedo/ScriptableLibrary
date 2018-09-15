using System;
using UnityEngine;
using SL.Events;

namespace SL.Variables
{
	[Serializable]
	public abstract class RefVariable<T> : GameEvent
	{
		[SerializeField, GetSet("Value")]
		protected T _Value;

		public T Value
		{
			get
			{
				return _Value;
			}
			set
			{
				_Value = value;
				Trigger();
			}
		}
	}
}
