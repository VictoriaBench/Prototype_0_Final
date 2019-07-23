using UnityEngine.Audio; //Ref audio features (for sound)
using System;//allows us to searh through the system
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //Array of sounds
    public AudioSound[] sounds;

    private void Start()
    {
        // Play("BG Sound");
        FindObjectOfType<SoundManager>().Play("BG Sound"); //find name of sound
    }

    void Awake()
    {
        foreach (AudioSound s in sounds) //adds audioSource for each sound looped through
        {
            //Audio source components
            s.source = gameObject.AddComponent<AudioSource>();//adds audio source for all sounds in array
            s.source.clip = s.soundClip;

            s.source.pitch = s.pitch;   //controlling the pitch
            s.source.volume = s.volume; //controlling the volume

            s.source.loop = s.loop;     //loop sound if loop is checked
        }
    }

    public void Play (string name)
    {
        AudioSound s = Array.Find(sounds, sound => sound.name == name); //name & find the name of the sound in array
        if (s == null)
        {
            print("Sound:" + name + " doesn't exist!");
            return; //continue if sound is not found
        }
            
        s.source.Play(); //play sound according to the name (in inspector)

    }
}
