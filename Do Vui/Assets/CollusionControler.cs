using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollusionControler : MonoBehaviour
{
    //public GameObject messenger;
    TriggerCollider numb;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("State"))
        {
            MessengerBoxCOntroller();
            
        }
        if (collision.gameObject.name == "WomanState")
            UIManager.instance.mess.SetDialogContent("Vai trò chính của CPU (Central Processing Unit) trong một máy tính là Thực hiện phép tính số họcThực hiện phép tính logic" +
                "Điều khiển hoạt động của hệ thống Quản lý tài nguyên Điều khiển hoạt động của các thiết bị ngoại vi");
        if (collision.gameObject.name == "Well")
            UIManager.instance.mess.SetDialogContent("Vai trò chính của BUS địa chỉ trong một hệ thống máy tính là định vị và truyền tải địa chỉ của bộ nhớ và các thiết bị ngoại vi khác trong hệ thống. Cụ thể đó là : Định vị bộ nhớ, Định vị các thiết bị ngoại vi, Truyền tải địa chỉ, Quản lý giao tiếp");
        if (collision.gameObject.name == "ShineRune")
            UIManager.instance.mess.SetDialogContent("Vai trò chính của BUS dữ liệu trong một hệ thống máy tính là Truyền tải dữ liệu giữa CPU và bộ nhớ, truyền tải dữ liệu giữa CPU và các thiết bị ngoại vi, truyền tải dữ liệu giữa các thành phần nội bộ của hệ thống, Quản lý giao tiếp dữ liệu. Tóm lại, vai trò chính của BUS dữ liệu là truyền tải dữ liệu giữa các thành phần trong hệ thống máy tính, đồng thời quản lý giao tiếp dữ liệu giữa các thành phần này để đảm bảo hoạt động chính xác của hệ thống.");
        if (collision.gameObject.name == "Chest")
            UIManager.instance.mess.SetDialogContent("Vai trò chính của BUS điều khiển trong một hệ thống máy tính là định hướng, điều khiển và đồng bộ hoạt động của các thành phần khác nhau trong hệ thống. Nó điều khiển hoạt động của CPU, điều khiển truyền tải dữ liệu giữa CPU và các thiết bị ngoại vi, điều khiển truyền tải dữ liệu giữa CPU và bộ nhớ, điều khiển tín hiệu ngắt (Interrupt), điều khiển các tín hiệu bộ điều khiển ngoại vi");
        
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Teleport"))
        {
            UIManager.instance.change.SetDialogContent("Bạn đã thu thập được " + UIManager.instance.numbHintTex.text + " gợi ý. \nBạn có muốn bắt đầu thử thách ngay bây giở không?");
            UIManager.instance.change.Show(true);


        }
    }
    void MessengerBoxCOntroller()
    {
        UIManager.instance.mess.Show(true);
    }

}
