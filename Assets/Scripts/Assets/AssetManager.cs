using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetManager : MonoBehaviour
{
    public AssetLink[] AssetPack;

    public GameObject GetGameObjectAsset(ushort id)
    {
        if (AssetPack == null) return null;

        for (int i = 0; i < AssetPack.Length; i++)
        {
            if (AssetPack[i].AssetId == id)
            {
                return AssetPack[i].gameObject;
            }
        }

        return null;
    }
}
