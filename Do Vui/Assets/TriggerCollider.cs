using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour
{
    public int hintnub;
    int curhint;
    private void Awake()
    {
        curhint = 0;
    }
    public void ClickBtn()
    {
        UIManager.instance.dialog.Show(false);
    }
    public void InfBtn()
    {
        UIManager.instance.dialog.Show(true);
    }
    public void ReadDone()
    {
        curhint += hintnub;
        UIManager.instance.mess.Show(false);
        UIManager.instance.numbHintTex.text = curhint.ToString();
    }
    public void ReReadHint()
    {
        UIManager.instance.change.Show(false);
    }
    public void GetHintNumb()
    {
        Debug.Log(curhint);
        if (curhint == 4)
        {

            UIManager.instance.change.SetDialogContent("Bạn đã thu thập được"+curhint +" gợi ý. \nBạn có muốn bắt đầu thử thách ngay bây giở không?");
            UIManager.instance.change.Show(true);
        }
    }
}
