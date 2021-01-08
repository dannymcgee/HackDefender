using UnityEngine;

namespace Assets.Scripts
{
	public class ULevel : MonoBehaviour
	{
		public Vector2Int size;
		public Vector2Int playerSpawn;

		public static ULevel Instance => GameObject
			.FindWithTag( "GameController" )
			.GetComponent<ULevel>();
	}
}
