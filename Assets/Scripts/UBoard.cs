using System;
using UnityEngine;

namespace Assets.Scripts
{
	public class UBoard : MonoBehaviour
	{
		public GameObject prefabGridCell;

		private Vector2Int _size;

		private void Awake () {
			_size = ULevel.Instance.size;
		}

		private void Start () {
			var camera = Camera.main;
			var cameraPos = camera.transform.position;
			var cameraX = (float) _size.x / 2;
			var cameraY = (float) _size.y / 2;
			camera.transform.position = new Vector3( cameraX, cameraY, cameraPos.z ) - new Vector3( 0.5f, 0.5f );
			camera.orthographicSize = (float) _size.y / 2;

			for (int x = 0; x < _size.x; x++) {
				for (int y = 0; y < _size.y; y++) {
					var cell = Instantiate( prefabGridCell, transform );
					var pos = new Vector2( x, y );
					cell.transform.position = pos;
				}
			}
		}
	}
}
