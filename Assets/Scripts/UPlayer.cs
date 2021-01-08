using System;
using UnityEngine;

namespace Assets.Scripts
{
	public class UPlayer : MonoBehaviour
	{
		private void Start () {
			transform.position = (Vector3) (Vector3Int) ULevel.Instance.playerSpawn;
		}
	}
}
