using System;
using UnityEngine;

namespace Assets.Scripts
{
	public class UPlayer : MonoBehaviour
	{
		private void Start () {
			transform.position = ULevel.Instance.playerSpawn.ToPosition();
		}
	}
}
