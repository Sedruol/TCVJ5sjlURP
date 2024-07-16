using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlHUD : MonoBehaviour
{
    public GameObject parteVerde;
    public GameObject panelLose;
    public Slider sliderHUD;
    public Image imgHUD;
    public TextMeshProUGUI tmpHUD;
    public Button btnHUD;
    public Sprite newSprite;
    public float damage = 20;
    public float health = 10;
    private float playerHP = 100;
    //timer 1
    private float timer;
    private int minutes;
    private int sec;
    //timer 2
    private int secondsToCount = 1;
    private float seconds = 0;
    private int number;
    private void Awake()
    {
        //timer 3
        //InvokeRepeating(funcion que llamaremos, retraso inicial en segundos, intervalo entre cada repeticion en segundos)
        //InvokeRepeating("UsingInvokeRepeating", 1, 1);
    }
    private void Start()
    {
        imgHUD.sprite = newSprite;
    }
    private void UsingInvokeRepeating()
    {
        number++;//number=0+1=1 | number=1+1=2 | number=2+1=3
    }

    // Update is called once per frame
    void Update()
    {

        //timer 1
        timer += Time.deltaTime;
        minutes = Mathf.FloorToInt(timer / 60);//5,4=5 | 8,9 = 8
        //65 segundos->65/60=1,...->minutes=1 | 185 segundos->185/60=3,...->minutes=3
        sec = Mathf.FloorToInt(timer % 60);//32 % 60 = 32 | 75 % 60 = 15
        tmpHUD.text = "Time: " + minutes.ToString("00") + ":" + sec.ToString("00");
        //if (timer >= 59.9f)//timer=60.001
        //{
        //    timer = 0;//timer=0
        //    minutes++;//minutes=1
        //}
        //tmpHUD.text = "Time: " + minutes.ToString("00") + ":" + timer.ToString("00");

        //timer = 10.5672
        //text= Time: 00:10
        //=======================================================
        //timer 2
        //seconds += Time.deltaTime;//seconds = 1.01, seconds=1.0001
        //if (seconds >= secondsToCount)//1.01>=1? Si | 1.0001>=1? Si
        //{
        //    seconds = 0;//seconds=0
        //    number++;//number=0+1=1 | number=1+1=2
        //}
        //tmpHUD.text = "Time: " + number.ToString();
        //=======================================================
        //timer 3
        //tmpHUD.text = "Time: " + number.ToString();


        //=======================================================
        //Cambiar vida del slider con clicks
        //if (Input.GetButtonDown("Fire1") && playerHP > 0)
        //{
        //    playerHP -= damage;
        //    sliderHUD.value = (playerHP / 100);
        //    Debug.Log("left click");
        //}
        //else if (Input.GetButtonDown("Fire2") && playerHP > 0)
        //{
        //    playerHP += health;
        //    sliderHUD.value = (playerHP / 100);
        //    Debug.Log("right click");
        //}
        //panelLose.activeSelf:
        //true: el panelLose esta activado
        //false: el panelLose esta desactivado
        if (playerHP <= 0 && !panelLose.activeSelf)//panelLose.activeSelf == false
        {
            panelLose.SetActive(true);
            parteVerde.SetActive(false);
            Time.timeScale = 0;
            Debug.Log("Perdiste manco");
        }
    }
    public void LoseHP()
    {
        if (playerHP > 0)
        {//playerHP=100
            playerHP -= damage;//playerHP=100-20=80
            sliderHUD.value = (playerHP / 100);//100/100=1 | 80/100 = 0.8
        }
    }
    public void GainHP()
    {
        //if (playerHP < 100 && playerHP > 0)
        //{//playerHP=80
        //    playerHP += health;//playerHP=80+10=90
        //    sliderHUD.value = (playerHP / 100);//90/100=0.9 | 109/100=1.09
        //}
        if (playerHP > 0)
        {//playerHP=99
            playerHP += health;//playerHP=99+10=109
            if (playerHP >= 100) playerHP = 100;//109>=100? Si, playerHP=100
            sliderHUD.value = (playerHP / 100);//100/100=1
        }
    }

    public void PrintText()
    {
        Debug.Log("cambio de vida");
    }
}