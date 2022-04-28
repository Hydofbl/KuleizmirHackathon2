using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogCheck : MonoBehaviour
{
    public GameObject diyalog321,diyalog322, diyalog621, diyalog622, diyalog821, diyalog822;
    //Tam bir amele i�iyle ��zd�m, uykulu kafayla s�k�nt� ��karmadan nas�l yapar�m derken en temizinin b�yle oldu�unu d���nd�m

    //scene'de g�rd���n gibi t�m diyaloglar ses dosyalar�(audio source) ile birlikte haz�r. Biz bu script ile i�ine girdi�imiz bloktaki bulunan(bizim koydu�umuz) trigger'a giriyor ve ismine bakarak hangisi oldu�unu anl�yor.

    //Bu sonras�nda hangi ekibin gitti�ine g�re ekip ad� ve yine bizim �nceden koydu�umuz ekip seslerine g�re telsiz mesaj�n� �al�yor.
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "diyalog32")
        {
            if (other.gameObject.name == "Player")
            {
                diyalog321.GetComponent<DialogueTrigger>().triggerDialogue();
                diyalog321.GetComponent<AudioSource>().Play();
            }
            else
            {
                diyalog322.GetComponent<DialogueTrigger>().triggerDialogue();
                diyalog322.GetComponent<AudioSource>().Play();

            }
        }
        else if (gameObject.name == "diyalog62")
        {
            if (other.gameObject.name == "Player")
            {
                diyalog621.GetComponent<DialogueTrigger>().triggerDialogue();
                diyalog621.GetComponent<AudioSource>().Play();
            }
            else
            {
                diyalog622.GetComponent<DialogueTrigger>().triggerDialogue();
                diyalog622.GetComponent<AudioSource>().Play();
            }
        }
        else if (gameObject.name == "diyalog82")
        {
            if (other.gameObject.name == "Player")
            {
                diyalog821.GetComponent<DialogueTrigger>().triggerDialogue();
                diyalog821.GetComponent<AudioSource>().Play();
            }          
            else       
            {          
                diyalog822.GetComponent<DialogueTrigger>().triggerDialogue();
                diyalog822.GetComponent<AudioSource>().Play();
            }
        }
    }
}
