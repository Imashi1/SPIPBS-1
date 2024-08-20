using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Importar el espacio de nombres TextMeshPro

public class Soundcon : MonoBehaviour {
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
    public TextMeshProUGUI displayText; // Cambiar a TextMeshProUGUI
    string btnName;

 // Use this for initialization
 void Start () {
        myAudioSource = GetComponent<AudioSource>();
  
 }
 
 // Update is called once per frame
 void Update () {
  if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "MyButton1":
                        myAudioSource.clip = aClips[0];
                        myAudioSource.Play();
                        displayText.text = "Se hizo clic en el Palo"; // Mostrar texto en la pantalla
                        print("boton1");
                        break;
                    case "MyButton2":
                        myAudioSource.clip = aClips[1];
                        myAudioSource.Play();
                        displayText.text = "Se hizo clic en la mochila "; // Mostrar texto en la pantalla

                        print("boton2");

                        break;
                    case "MyButton3":
                        myAudioSource.clip = aClips[2];
                        myAudioSource.Play();
                        displayText.text = "Se hizo clic en la taza"; // Mostrar texto en la pantalla

                        print("boton3");
                        break;
                    case "MyButton4":
                        myAudioSource.clip = aClips[3];
                        myAudioSource.Play();
                        displayText.text = "Se hizo clic en la caja"; // Mostrar texto en la pantalla
                        
                        print("boton4");
                        break;
                    case "MyButton5":
                        myAudioSource.clip = aClips[4];
                        myAudioSource.Play();
                        displayText.text = "Se hizo clic en la pelota"; // Mostrar texto en la pantalla

                        print("boton5");

                        break;
                    case "MyButton6":
                        myAudioSource.clip = aClips[5];
                        myAudioSource.Play();
                        displayText.text = "Se hizo clic en el gorro"; // Mostrar texto en la pantalla

                        print("boton6");
                        break;
                    default:
                        break;

                }
            }
        }
        
 }
}