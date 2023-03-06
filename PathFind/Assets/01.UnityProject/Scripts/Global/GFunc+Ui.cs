using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static partial class GFunc
{
    //! ī�޶� ����� �����ϴ� �Լ�
    public static Vector2 GetCameraSize()
    {
        Vector2 camerasize = Vector2.zero;
        //����������� 2�� ����
        camerasize.y = Camera.main.orthographicSize * 2f;
        camerasize.x = camerasize.y * Camera.main.aspect;
        return camerasize;
    } //GetCameraSize

    //! �ؽ�Ʈ�޽����� ������ ������Ʈ�� �ؽ�Ʈ�� �����ϴ� �Լ�
    public static void SetTmpText(this GameObject obj_, string text_)
    {
        TMP_Text tmpTxt = obj_.GetComponent<TMP_Text>();
        if (tmpTxt == null || tmpTxt == default(TMP_Text))
        {
            return;
        }       // if: ������ �ؽ�Ʈ�޽� ������Ʈ�� ���� ���

        // ������ �ؽ�Ʈ�޽� ������Ʈ�� �����ϴ� ���
        tmpTxt.text = text_;
    }       // SetTextMeshPro()
}
