using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text timeText, numbHintTex;
    public Text questionText;
    public Dialog dialog, mess, infomation, change, stop, notify, result;
    //public PauseManager pausebtn;
    public AnswerButton[] answerButtons;
    public Slider music, sound;
    private void Awake() {
        MakeSingleton();
    }

    public void SetTimeText(string content){
        if(timeText){
            timeText.text = content;
        }
    }

    public void SetQuestionText(string content){
        if(questionText){
            questionText.text = content;
        }
    }

    public void ShuffleAnswers(){
        if(answerButtons != null && answerButtons.Length > 0){
            for (int i = 0; i < answerButtons.Length; i++)
            {
                if(answerButtons[i]){
                    answerButtons[i].tag = "Untagged";
                }
            }

            int randIdx = Random.Range(0, answerButtons.Length);

            if(answerButtons[randIdx]){
                answerButtons[randIdx].tag = "RightAnswer";
            }
        }
    }

    public void MakeSingleton(){
        if(instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }
}
