using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class gaze : MonoBehaviour
{

    public AudioSource[] soundFX;
    bool m_ToggleChange;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;

            if (go.CompareTag("hasInfo") && m_ToggleChange == true)
            {
                soundFX[0].Play();
                print("hi");
                m_ToggleChange = false;

            }

        }
        else
        {
            CloseAll();
        }
    }


    void OpenInfo(InfoBehaivoir desiredInfo)
    {
        
    }

    void CloseAll()
    {
        print("bye");
        soundFX[0].Stop();
        m_ToggleChange = true;
    }

}