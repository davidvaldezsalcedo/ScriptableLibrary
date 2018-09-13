using System;
using UnityEngine;

namespace SL.Events
{
	[CreateAssetMenu(menuName = "SL/Events/GameEvent")]
	public class GameEvent : ScriptableObject
	{
		public event Action Listeners;

		public void Trigger()
		{
			if(Listeners != null)
			{
				Listeners();
			}
		}
	}
}
