using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MenuStart");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void PlayOption()
    {
        SceneManager.LoadScene("OptionMenu");
    }
    public void PlaySetting()
    {
        SceneManager.LoadScene("SoundScenes");
    }
    public void PlayPauseSetting()
    {
        SceneManager.LoadScene("PauseMenu");
    }
    public void EXIT()
    {
        Application.Quit();
    }
    public void setMMTinf()
    {
        UIManager.instance.infomation.SetDialogContent("Mạng máy tính là cơ sở của giao tiếp trong CNTT, là  một tập hợp các máy tính được kết nối với nhau để chúng có thể chia sẻ thông tin");
    }
    public void setKTMTinf()
    {
        UIManager.instance.infomation.SetDialogContent("Đồ họa máy tính có liên quan đến một số lĩnh vực như đại số, hình học giải tích, hình học họa hình, quang học,...đặc biệt là chế tạo phần cứng");
    }
    public void setHDHinf()
    {
        UIManager.instance.infomation.SetDialogContent("Hệ điều hành là thành phần quan trọng trong máy tính, nghiên cứu về các khái niệm và nguyên lý chung về hệ điều hành.");
    }

}
