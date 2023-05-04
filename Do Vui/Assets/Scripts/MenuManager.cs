using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void HintScene()
    {
        SceneManager.LoadScene("HintScene");
    }
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
        UIManager.instance.infomation.SetDialogContent("Kiến trúc máy tính là khoa học về lựa chọn và ghép nối các thành phần cứng của máy tính nhằm đạt được các mục tiêu về hiệu năng cao");
    }
    public void setHDHinf()
    {
        UIManager.instance.infomation.SetDialogContent("Hệ điều hành là thành phần quan trọng trong máy tính, nghiên cứu về các khái niệm và nguyên lý chung về hệ điều hành.");
    }

}
