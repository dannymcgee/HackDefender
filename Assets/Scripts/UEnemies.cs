using System;
using UnityEngine;

namespace Assets.Scripts
{
	public class UEnemies : MonoBehaviour
	{
		public UEnemy enemyPrefab;

		private void Start () {
			foreach (var spawn in ULevel.Instance.enemySpawns) {
				var enemy = Instantiate(
					enemyPrefab,
					spawn.ToPosition(),
					Quaternion.identity,
					transform );
			}
		}
	}
}
