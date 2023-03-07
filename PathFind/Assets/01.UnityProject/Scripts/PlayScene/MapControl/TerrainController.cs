using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour
{
    private const string TILE_FRONT_RENDERER_OBJ_NAME = "FrontRenderer";
    private TerrainType terrainType = TerrainType.NONE;
    private MapBoard mapControler = default;
    public bool isPassable { get; private set; } = false;
    public int TileIdx1D { get; private set; } = -1;
    public Vector2Int TileIdx2D { get; private set; } = default;
    #region ��ã�� �˰����� ���� ����
    private SpriteRenderer frontRenderer = default;
    private Color defaultColor = default;
    private Color selectedColor = default;
    private Color searchColor = default;
    private Color inactiveColor = default;
    #endregion // ��ã�� �˰����� ���� ����

    private void Awake()
    {
        frontRenderer = gameObject.FindChildComponent<SpriteRenderer>(TILE_FRONT_RENDERER_OBJ_NAME);
        GFunc.Assert(frontRenderer != null || frontRenderer != default);

        defaultColor = new Color(1f, 1f, 1f, 1f);
        selectedColor = new Color(236f / 255f, 130f / 255f, 20f / 255f, 1f);
        searchColor = new Color(0f, 192f / 255f, 0f, 1f);
        inactiveColor = new Color(128f / 255f, 128f / 255f, 128f / 255f, 1f);
    } //Awake

    //! ���������� �ʱ� �����Ѵ�.
    public void SetupTerrain(MapBoard mapControler_, TerrainType type_, int tileIdx1D_)
    {
        terrainType = type_;
        mapControler = mapControler_;
        TileIdx1D = tileIdx1D_;
        TileIdx2D = mapControler.GetTileIdx2D(TileIdx1D);

        string prefabName = string.Empty;
        switch (type_)
        {
            case TerrainType.PLAIN_PASS:
                prefabName = RDefine.TERRAIN_PREF_PLAIN;
                isPassable = true;
                break;
            case TerrainType.OCEAN_N_PASS:
                prefabName = RDefine.TERRAIN_PREF_OCEAN;
                isPassable = false;
                break;
            default:
                prefabName = "Tile_Default";
                isPassable = false;
                break;
        } // switch : Ÿ���� Ÿ�Ժ��� �ٸ� ������ �Ѵ�.

        this.name = string.Format("{0}_{1}", prefabName, TileIdx1D);
    } //SetupTerrain

    //! ������ Front ������ �����Ѵ�.
    public void SetTileActiveColor(RDefine.TileStatusColor tileStatus)
    {
        switch (tileStatus)
        {
            case RDefine.TileStatusColor.SELECTED:
                frontRenderer.color = selectedColor;
                break;
            case RDefine.TileStatusColor.SEARCH:
                frontRenderer.color = searchColor;
                break;
            case RDefine.TileStatusColor.INACTIVE:
                frontRenderer.color = inactiveColor;
                break;
            default:
                frontRenderer.color = defaultColor;
                break;
        }
    } //SetTileActiveColor
}
