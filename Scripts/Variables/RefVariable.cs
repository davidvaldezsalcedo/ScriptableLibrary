using System;
using UnityEngine;

namespace SL
{
	[Serializable]
	public abstract class RefVariable<T> : ScriptableObject
	{
		public event Action OnValueChanged = delegate { };

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
				OnValueChanged();
			}
		}	
	}
}
