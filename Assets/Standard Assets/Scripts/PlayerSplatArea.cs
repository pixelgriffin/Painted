using UnityEngine;
using System.Collections;

public class PlayerSplatArea : MonoBehaviour {

	private TerrainData terr;

	private float[,,] splatData;

	void Start () {
		terr = Terrain.activeTerrain.terrainData;

		splatData = new float[terr.alphamapWidth, terr.alphamapHeight, terr.alphamapLayers];
		for(int x = 0; x < terr.alphamapWidth; x++)
		{
			for(int y = 0; y < terr.alphamapHeight; y++)
			{
				splatData[x, y, 0] = 1;
				splatData[x, y, 1] = 0;
			}
		}
		terr.SetAlphamaps(0, 0, splatData);
	}

	void Update () {
		float x = (gameObject.transform.position.x - Terrain.activeTerrain.GetPosition().x) / terr.size.x;
		float z = (gameObject.transform.position.z - Terrain.activeTerrain.GetPosition().z) / terr.size.z;

		x *= terr.heightmapWidth;
		z *= terr.heightmapHeight;

		Debug.Log("terrX: " + (int)x + " terrZ: " + (int)z);

		splatData[(int)z, (int)x, 0] = 0;
		splatData[(int)z, (int)x, 1] = 1;

		terr.SetAlphamaps(0, 0, splatData);
	}
}
