using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static partial class GFunc
{
    //! 카메라 사이즈를 리턴하는 함수
    public static Vector2 GetCameraSize()
    {
        Vector2 camerasize = Vector2.zero;
        //하프사이즈라 2를 곱함
        camerasize.y = Camera.main.orthographicSize * 2f;
        camerasize.x = camerasize.y * Camera.main.aspect;
        return camerasize;
    } //GetCameraSize

    //! 텍스트메쉬프로 형태의 컴포넌트의 텍스트를 설정하는 함수
    public static void SetTmpText(this GameObject obj_, string text_)
    {
        TMP_Text tmpTxt = obj_.GetComponent<TMP_Text>();
        if (tmpTxt == null || tmpTxt == default(TMP_Text))
        {
            return;
        }       // if: 가져올 텍스트메쉬 컴포넌트가 없는 경우

        // 가져올 텍스트메쉬 컴포넌트가 존재하는 경우
        tmpTxt.text = text_;
    }       // SetTextMeshPro()
}
