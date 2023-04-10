using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class IMusic : MonoBehaviour
{
   
    [SerializeField] private AudioClip[] _sounds;
    [SerializeField] private AudioSource _sourse;
    [SerializeField] private Button _pause;
    [SerializeField] private Slider _volume;
    [SerializeField] private Button _cont;
    [SerializeField] private Button _next;
    [SerializeField] private TMP_Text _music;
   
    private int i;
     // Start is called before the first frame update
    void Start()
    {
        i = 0;
        _pause.onClick.AddListener(Pause);
        _cont.onClick.AddListener(Continnue);
        _next.onClick.AddListener(SecondTrack);
        _sourse.PlayOneShot(_sounds[i]);
    }

    // Update is called once per frame
    void Update()
    {
        _sourse.volume = _volume.value;
         switch(i)
        {
            case 0:
                _music.text = "Pivo";
                break;
            case 1:
                _music.text = "Vodka";
                break;
            case 2:
                _music.text = "Vodochka";
                break;
            case 3:
                _music.text = "Kolbasa";
                break;
            case 4:
                _music.text = "Sel`dochka";
                break;
        }

    }
    private void Pause()
    {
        _sourse.Pause();
        Debug.Log("Pause");
    }
    private void Continnue()
    {

        _sourse.Play();
        Debug.Log("Continue");


    }
    private void SecondTrack()
    {
        if (i <= 3)
        {
            _sourse.Stop();
            _sourse.PlayOneShot(_sounds[i + 1]);
            i++;
        }
        else
        {
            _sourse.Stop();
            _sourse.PlayOneShot(_sounds[0]);
            i=0;
        }
        Debug.Log("PIVO");
    }
}