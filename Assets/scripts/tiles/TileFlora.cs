using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class TileFlora : Tile
{
    public Tile decorationTile;
    public string decorationTilemapTag;

	// Use this for initialization
	public override bool StartUp (Vector3Int location, ITilemap tilemap, GameObject go)
    {
        bool result = base.StartUp(location, tilemap, go);

        if(result)
        {
            Tilemap decorationTilemap = GameObject.FindGameObjectWithTag(decorationTilemapTag).GetComponent<Tilemap>();
            decorationTilemap.SetTile(location, decorationTile);
        }
        return result;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

#if UNITY_EDITOR
    // The following is a helper that adds a menu item to create a FloraTile Asset
    [MenuItem("Assets/Create/FloraTile")]
    public static void CreateFloraTile()
    {
        string path = EditorUtility.SaveFilePanelInProject("Save Flora Tile", "New Flora Tile", "Asset", "Save Flora Tile", "Assets");
        if (path == "")
            return;
        AssetDatabase.CreateAsset(ScriptableObject.CreateInstance<TileFlora>(), path);
    }
#endif
}
