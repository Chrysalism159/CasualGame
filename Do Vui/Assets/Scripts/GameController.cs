using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int scorePerQuestion;
    int m_correct;
    int m_rightCount;
    int m_answered;
    float m_percent;
    QuestionManager numb;
    //public Button btns;

    private void Awake() {
        m_correct = 0;
        m_answered = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        UIManager.instance.SetTimeText(m_correct.ToString());
        
        CreateQuestion();

        //StartCoroutine(TimeCountingDown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateQuestion(){
        
        Debug.Log(m_answered);
        Debug.Log("Phan tram kien thuc: " + m_percent + "%");
        Debug.Log("Ty le tra loi dung: " + m_correct + "/" + m_answered);
        QuestionData qs = QuestionManager.instance.GetRandomQuestion();

        if(qs != null){
            UIManager.instance.SetQuestionText(qs.question);

            string[] wrongAnswers = new string[] {qs.answerA, qs.answerB, qs.answerC};

            UIManager.instance.ShuffleAnswers();

            var temp = UIManager.instance.answerButtons;

            if(temp != null && temp.Length >0){
                int wrongAnswerCount = 0;

                for (int i = 0; i < temp.Length; i++)
                {
                    int answerId = i;

                    if(string.Compare(temp[i].tag, "RightAnswer") == 0){
                        temp[i].SetAnswerText(qs.rightAswer);       
                    }
                    else{
                        temp[i].SetAnswerText(wrongAnswers[wrongAnswerCount]);
                        wrongAnswerCount++;        
                    }

                    temp[answerId].btnComp.onClick.RemoveAllListeners();
                    temp[answerId].btnComp.onClick.AddListener(() => CheckRightAnswerEvent(temp[answerId]));
                }
            }
        }
    }

    void CheckRightAnswerEvent(AnswerButton answerButton){
        
        m_answered = m_answered + 1;
        if (answerButton.CompareTag("RightAnswer")){
            m_correct += scorePerQuestion;
            UIManager.instance.SetTimeText(m_correct.ToString());
            m_percent = (m_correct / m_answered) * 100;
            Debug.Log("ban da tra loi dung\n");
          
            
            //}
        }
        //else{

        //    //UIManager.instance.dialog.Show(true);
            
        //    //AudioController.instance.PlayLoseSound();
        //    //Debug.Log(m_answered);
        //}
       
        CreateQuestion();
    }

    //IEnumerator TimeCountingDown(){
    //    yield return new WaitForSeconds(1);
    //    if(m_curTime > 0){
    //        StartCoroutine(TimeCountingDown());
    //        m_curTime--;
    //        UIManager.instance.SetTimeText("00 : " + m_curTime);
    //    }
    //    else{
    //        UIManager.instance.dialog.SetDialogContent("Đã hết thời gian, bạn đã thua! Trò chơi kết thúc");
    //        UIManager.instance.dialog.Show(true);
    //        StopAllCoroutines();
    //        AudioController.instance.PlayLoseSound();
    //    }
    //}

    public void Replay(){
        AudioController.instance.StopMusic();
        SceneManager.LoadScene("GamePlay");
    }
    public void Pause()
    {
        UIManager.instance.stop.Show(true);
    }
    public void Continue()
    {
        UIManager.instance.stop.Show(false);
    }
    public void Notify()
    {
        UIManager.instance.notify.Show(true);
    }
    public void HideNotify()
    {
        UIManager.instance.notify.Show(false);
    }
    public void Result()
    {
        UIManager.instance.result.Show(true);
        if (m_correct/m_answered < 3)
        {
            UIManager.instance.result.SetDialogContent("Bạn đã trả lời được: " + m_correct + "/" + m_answered + "\nLượng kiến thức của bạn quá ít!");
        }
        else if (m_correct / m_answered >= 3 && m_correct / m_answered < 7)
        {
            UIManager.instance.result.SetDialogContent("Bạn đã trả lời được: " + m_correct + "/" + m_answered + "\nHãy tiếp tục hơn nữa nhé!");
        }
        else
        {
            UIManager.instance.result.SetDialogContent("Bạn đã trả lời được: " + m_correct + "/" + m_answered + "\nTuyệt vời!");
        }
        
    }
    //public void ()
    //{
    //    UIManager.instance.notify.Show(false);
    //}
    public void Exit(){
        Application.Quit();
    }
}
