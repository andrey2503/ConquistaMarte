using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
	public AudioSource audiosource;
	public int delay = 0;

    void Start()
    {
        AudioSource audiosource = GetComponent<AudioSource>();
		
		someOtherMethodInAMonoBehaviour();
    }

    IEnumerator playSoundAfterTenSeconds()
    {
        yield return new WaitForSeconds(delay);
        audiosource.Play();
    }

    // then elsewhere when you want to invoke it:

    void someOtherMethodInAMonoBehaviour()
    {
        StartCoroutine(playSoundAfterTenSeconds());
    }

}