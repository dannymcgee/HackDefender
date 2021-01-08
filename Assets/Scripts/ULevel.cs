using UnityEngine;

namespace Assets.Scripts
{
	public class ULevel : MonoBehaviour
	{
		public Vector2Int size;
		public Vector2Int playerSpawn;
		public Vector2Int[] enemySpawns;

		public static ULevel Instance => GameObject
			.FindWithTag( "GameController" )
			.GetComponent<ULevel>();
	}
}
