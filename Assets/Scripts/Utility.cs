using UnityEngine;

namespace Assets.Scripts
{
	public static class Utility
	{
		public static Vector3 ToPosition ( this Vector2Int coords ) {
			return (Vector3) (Vector3Int) coords;
		}
	}
}
