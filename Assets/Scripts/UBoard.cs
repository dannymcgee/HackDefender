using System;
using UnityEngine;

namespace Assets.Scripts
{
	public class UBoard : MonoBehaviour
	{
		public GameObject prefabGridCell;
		public Vector2Int size;

		private void Start () {
			var camera = Camera.main;
			var cameraPos = camera.transform.position;
			var cameraX = (float) size.x / 2;
			var cameraY = (float) size.y / 2;
			camera.transform.position = new Vector3( cameraX, cameraY, cameraPos.z ) - new Vector3( 0.5f, 0.5f );
			camera.orthographicSize = (float) size.y / 2;

			for (int x = 0; x < size.x; x++) {
				for (int y = 0; y < size.y; y++) {
					var cell = Instantiate( prefabGridCell, transform );
					var pos = new Vector2( x, y );
					cell.transform.position = pos;
				}
			}
		}
	}
}
