using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapControler : MonoBehaviour
{
    protected string tileMapObjName = default;
    protected MapBoard mapController = default;
    protected Tilemap tileMap = default;
    protected List<GameObject> allTileObjs = default;

    //! Awake Ÿ�ӿ� �ʱ�ȭ �� ������ ��ӹ��� Ŭ�������� �������Ѵ�.
    public virtual void InitAwake(MapBoard mapControler_)
    {
        mapController = mapControler_;
        tileMap = gameObject.FindChildComponent<Tilemap>(tileMapObjName);

        // ���簢�� ���·� �ʱ�ȭ �� Ÿ���� ĳ���ؼ� ������ �ִ´�.
        allTileObjs = tileMap.gameObject.GetChildrenObjs();
        if (allTileObjs.IsValid())
        {
            allTileObjs.Sort(GFunc.ComPareTileObjToLocalPos2D);
        }
        else { allTileObjs = new List<GameObject>(); }

        /* Todo */
    } //InitAwake
} // class TileMapControler
