using UnityEngine;

public class SoundEffect : MonoBehaviour {

    private AudioSource sound;

	// Use this for initialization
	void Start () {
        sound = gameObject.GetComponent<AudioSource>();
	}

    public void playSoundEffect(){
        sound.PlayOneShot(sound.clip);

    }

}
