using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    [Range(0,1)]
    public float musicVolume;
    [Range(0,1)]
    public float soundVolume;
    public AudioSource musicAus;
    public AudioSource soundAus;
    public AudioClip[] backgroundMusics;
    public AudioClip rightSound;
    public AudioClip loseSound;
    public AudioClip winsound;

    private void Awake() {
        MakeSingleton();
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayBackgroundMusic();
    }

    private void Update() {
        if(musicAus && soundAus){
            musicAus.volume = musicVolume;
            soundAus.volume = soundVolume;
        }
    }

    public void PlayBackgroundMusic(){
        if(musicAus && backgroundMusics != null && backgroundMusics.Length > 0){
            int RandIdx = Random.Range(0, backgroundMusics.Length);

            if(backgroundMusics[RandIdx]){
                musicAus.clip = backgroundMusics[RandIdx];
                musicAus.volume = musicVolume;
                musicAus.Play();
            }
        }
    }

    public void PlaySound(AudioClip sound){
        if(soundAus && sound){
            soundAus.volume = soundVolume;
            soundAus.PlayOneShot(sound);
        }
    }

    public void PlayRightSound(){
        PlaySound(rightSound);
    }

    public void PlayLoseSound(){
        PlaySound(loseSound);
    }

    public void PlayWinSound(){
        PlaySound(winsound);
    }

    public void StopMusic(){
        if(musicAus){
            musicAus.Stop();
        }
    }
    public void ContinueMusic()
    {
        if (musicAus)
        {
            musicAus.Play();
        }
    }
    void MakeSingleton(){
        if(instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }
}
