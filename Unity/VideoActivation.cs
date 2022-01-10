using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI; 

public class VideoActivation : MonoBehaviour
{
    public int numb = 0;
    public float time = 0;
    public float timer = 0;
    public float reactiontime1 = 0;
    public float reactiontime2 = 0;
    public float reactiontime3 = 0;
    public float reactiontime4 = 0;
    public float reactiontime5 = 0;
    public float reactiontime6 = 0;
    public float reactiontime7 = 0;
    public float reactiontime8 = 0;
    public float reactiontime9 = 0;
    public float reactiontime10 = 0;
    public float reactiontime11 = 0;
    public float reactiontime12 = 0;
    public float reactiontime13 = 0;
    public float reactiontime14 = 0;
    public float reactiontime15 = 0;
    public float reactiontime16 = 0;
    public float reactiontime17 = 0;
    public float reactiontime18 = 0;
    public float reactiontime19 = 0;
    public float reactiontime20 = 0;
    public float reactiontime21 = 0;
    public float reactiontime22 = 0;
    public float reactiontime23 = 0;
    public float reactiontime24 = 0;
    public float reactiontime25 = 0;
    public float reactiontime26 = 0;
    public float reactiontime27 = 0;
    public float reactiontime28 = 0;
    public float reactiontime29 = 0;
    public float reactiontime30 = 0;
    public string reactiontime1f;
    public string reactiontime2f;
    public string reactiontime3f;
    public string reactiontime4f;
    public string reactiontime5f;
    public string reactiontime6f;
    public string reactiontime7f;
    public string reactiontime8f;
    public string reactiontime9f;
    public string reactiontime10f;
    public string reactiontime11f;
    public string reactiontime12f;
    public string reactiontime13f;
    public string reactiontime14f;
    public string reactiontime15f;
    public string reactiontime16f;
    public string reactiontime17f;
    public string reactiontime18f;
    public string reactiontime19f;
    public string reactiontime20f;
    public string reactiontime21f;
    public string reactiontime22f;
    public string reactiontime23f;
    public string reactiontime24f;
    public string reactiontime25f;
    public string reactiontime26f;
    public string reactiontime27f;
    public string reactiontime28f;
    public string reactiontime29f;
    public string reactiontime30f;
    public bool timerisrunning = false;
    public bool timeisrunning = false;
    public GameObject survey;
    public GameObject video1;
    public GameObject video2;
    public GameObject video3;
    public GameObject video4;
    public GameObject video5;
    public GameObject video6;
    public GameObject video7;
    public GameObject video8;
    public GameObject video9;
    public GameObject video10;
    public GameObject video11;
    public GameObject video12;
    public GameObject video13;
    public GameObject video14;
    public GameObject video15;
    public GameObject video16;
    public GameObject video17;
    public GameObject video18;
    public GameObject video19;
    public GameObject video20;
    public GameObject video21;
    public GameObject video22;
    public GameObject video23;
    public GameObject video24;
    public GameObject video25;
    public GameObject video26;
    public GameObject video27;
    public GameObject video28;
    public GameObject video29;
    public GameObject video30;
    public GameObject video31;
    public GameObject video32;
    public GameObject video33;
    public GameObject video34;
    public VideoPlayer vid1;
    public VideoPlayer vid2;
    public VideoPlayer vid3;
    public VideoPlayer vid4;
    public VideoPlayer vid5;
    public VideoPlayer vid6;
    public VideoPlayer vid7;
    public VideoPlayer vid8;
    public VideoPlayer vid9;
    public VideoPlayer vid10;
    public VideoPlayer vid11;
    public VideoPlayer vid12;
    public VideoPlayer vid13;
    public VideoPlayer vid14;
    public VideoPlayer vid15;
    public VideoPlayer vid16;
    public VideoPlayer vid17;
    public VideoPlayer vid18;
    public VideoPlayer vid19;
    public VideoPlayer vid20;
    public VideoPlayer vid21;
    public VideoPlayer vid22;
    public VideoPlayer vid23;
    public VideoPlayer vid24;
    public VideoPlayer vid25;
    public VideoPlayer vid26;
    public VideoPlayer vid27;
    public VideoPlayer vid28;
    public VideoPlayer vid29;
    public VideoPlayer vid30;
    public VideoPlayer vid31;
    public VideoPlayer vid32;
    public VideoPlayer vid33;
    public VideoPlayer vid34;
    private bool safe1;
    private bool safe2;
    private bool safe3;
    private bool safe4;
    private bool safe5;
    private bool safe6;
    private bool safe7;
    private bool safe8;
    private bool safe9;
    private bool safe10;
    private bool safe11;
    private bool safe12;
    private bool safe13;
    private bool safe14;
    private bool safe15;
    private bool safe16;
    private bool safe17;
    private bool safe18;
    private bool safe19;
    private bool safe20;
    private bool safe21;
    private bool safe22;
    private bool safe23;
    private bool safe24;
    private bool safe25;
    private bool safe26;
    private bool safe27;
    private bool safe28;
    private bool safe29;
    private bool safe30;
    private bool safe31;
    private bool safe32;
    private bool safe33;
    private bool safe34;
    private string name;
    private string participant;
    private string age;
    private string sex;
    private string handedness;
    private string driving;
    private string rank;
    private string disorder;
    public GameObject name1;
    public GameObject participant1;
    public GameObject age1;
    public GameObject sex1;
    public GameObject handedness1;
    public GameObject driving1;
    public GameObject rank1;
    public GameObject disorder1;
    public GameObject ins;
    public Text instructions;
    private bool soof1;
    private bool seef1;
    private bool flee1;
    private bool kelb;
    private bool kelb1; 
    private float datatime = 0;
    private bool sat;
    private bool failsafe;
    private bool failsafe1;
    private bool failsafe2;
    private bool lifeline; 

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    void Start()
    {      
        video1.active = false;
        video2.active = false;
        video3.active = false;
        video4.active = false;
        video5.active = false;
        video6.active = false;
        video7.active = false;
        video8.active = false;
        video9.active = false;
        video10.active = false;
        video11.active = false;
        video12.active = false;
        video13.active = false;
        video14.active = false;
        video15.active = false;
        video16.active = false;
        video17.active = false;
        video18.active = false;
        video19.active = false;
        video20.active = false;
        video21.active = false;
        video22.active = false;
        video23.active = false;
        video24.active = false;
        video25.active = false;
        video26.active = false;
        video27.active = false;
        video28.active = false;
        video29.active = false;
        video30.active = false;
        video31.active = false;
        video32.active = false;
        video33.active = false;
        video34.active = false;
        ins.active = false;
        PlayerPrefs.SetString("ReactionTime1F", reactiontime1f);
        PlayerPrefs.SetString("ReactionTime2F", reactiontime2f);
        PlayerPrefs.SetString("ReactionTime3F", reactiontime3f);
        PlayerPrefs.SetString("ReactionTime4F", reactiontime4f);
        PlayerPrefs.SetString("ReactionTime5F", reactiontime5f);
        PlayerPrefs.SetString("ReactionTime6F", reactiontime6f);
        PlayerPrefs.SetString("ReactionTime7F", reactiontime7f);
        PlayerPrefs.SetString("ReactionTime8F", reactiontime8f);
        PlayerPrefs.SetString("ReactionTime9F", reactiontime9f);
        PlayerPrefs.SetString("ReactionTime10F", reactiontime10f);
        PlayerPrefs.SetString("ReactionTime11F", reactiontime11f);
        PlayerPrefs.SetString("ReactionTime12F", reactiontime12f);
        PlayerPrefs.SetString("ReactionTime13F", reactiontime13f);
        PlayerPrefs.SetString("ReactionTime14F", reactiontime14f);
        PlayerPrefs.SetString("ReactionTime15F", reactiontime15f);
        PlayerPrefs.SetString("ReactionTime16F", reactiontime16f);
        PlayerPrefs.SetString("ReactionTime17F", reactiontime17f);
        PlayerPrefs.SetString("ReactionTime18F", reactiontime18f);
        PlayerPrefs.SetString("ReactionTime19F", reactiontime19f);
        PlayerPrefs.SetString("ReactionTime20F", reactiontime20f);
        PlayerPrefs.SetString("ReactionTime21F", reactiontime21f);
        PlayerPrefs.SetString("ReactionTime22F", reactiontime22f);
        PlayerPrefs.SetString("ReactionTime23F", reactiontime23f);
        PlayerPrefs.SetString("ReactionTime24F", reactiontime24f);
        PlayerPrefs.SetString("ReactionTime25F", reactiontime25f);
        PlayerPrefs.SetString("ReactionTime26F", reactiontime26f);
        PlayerPrefs.SetString("ReactionTime27F", reactiontime27f);
        PlayerPrefs.SetString("ReactionTime28F", reactiontime28f);
        PlayerPrefs.SetString("ReactionTime29F", reactiontime29f);
        PlayerPrefs.SetString("ReactionTime30F", reactiontime30f);
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void ButtonPress()
    {
        numb = 1;
        name = name1.GetComponent<InputField>().text;
        participant = participant1.GetComponent<InputField>().text;
        age = age1.GetComponent<InputField>().text;
        sex = sex1.GetComponent<InputField>().text;
        handedness = handedness1.GetComponent<InputField>().text;
        driving = driving1.GetComponent<InputField>().text;
        rank = rank1.GetComponent<InputField>().text;
        disorder = disorder1.GetComponent<InputField>().text;
        PlayerPrefs.SetString("Name", name);
        PlayerPrefs.SetString("Participant", participant);
        PlayerPrefs.SetString("Age", age);
        PlayerPrefs.SetString("Sex", sex);
        PlayerPrefs.SetString("Handedness", handedness);
        PlayerPrefs.SetString("Driving", driving);
        PlayerPrefs.SetString("Rank", rank);
        PlayerPrefs.SetString("Disorder", disorder);
        Destroy(survey);
    }

    void Update()
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (failsafe == true)
        {
            if (failsafe2 == true)
            {
                if (Input.GetKeyDown(KeyCode.P))
                {
                    //add this stuff
                    kelb = true;
                    timerisrunning = false;
                    flee1 = false;
                    safe1 = false;
                    seef1 = false;
                    soof1 = false;
                    sat = false;
                    timer = 0;
                    datatime = 0;
                    kelb1 = false;
                    failsafe = false;
                    failsafe2 = false;

                    //add this
                    if (numb == 1)
                    {
                        vid1.Pause();
                    }
                    if (numb == 2)
                    {
                        vid2.Pause();
                    }
                    if (numb == 3)
                    {
                        vid3.Pause();
                    }
                    if (numb == 4)
                    {
                        vid4.Pause();
                    }
                    if (numb == 5)
                    {
                        vid5.Pause();
                        PlayerPrefs.SetString("ReactionTime1F", reactiontime1.ToString());
                        Data.MyTools1.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 6)
                    {
                        vid6.Pause();
                        PlayerPrefs.SetString("ReactionTime2F", reactiontime2.ToString());
                        Data.MyTools2.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 7)
                    {
                        vid7.Pause();
                        PlayerPrefs.SetString("ReactionTime3F", reactiontime3.ToString());
                        Data.MyTools3.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 8)
                    {
                        vid8.Pause();
                        PlayerPrefs.SetString("ReactionTime4F", reactiontime4.ToString());
                        Data.MyTools4.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 9)
                    {
                        vid9.Pause();
                        PlayerPrefs.SetString("ReactionTime5F", reactiontime5.ToString());
                        Data.MyTools5.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 10)
                    {
                        vid10.Pause();
                        PlayerPrefs.SetString("ReactionTime6F", reactiontime6.ToString());
                        Data.MyTools6.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 11)
                    {
                        vid11.Pause();
                        PlayerPrefs.SetString("ReactionTime7F", reactiontime7.ToString());
                        Data.MyTools7.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 12)
                    {
                        vid12.Pause();
                        PlayerPrefs.SetString("ReactionTime8F", reactiontime8.ToString());
                        Data.MyTools8.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 13)
                    {
                        vid13.Pause();
                        PlayerPrefs.SetString("ReactionTime9F", reactiontime9.ToString());
                        Data.MyTools9.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 14)
                    {
                        vid14.Pause();
                        PlayerPrefs.SetString("ReactionTime10F", reactiontime10.ToString());
                        Data.MyTools10.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 15)
                    {
                        vid15.Pause();
                        PlayerPrefs.SetString("ReactionTime11F", reactiontime11.ToString());
                        Data.MyTools11.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 16)
                    {
                        vid16.Pause();
                        PlayerPrefs.SetString("ReactionTime12F", reactiontime12.ToString());
                        Data.MyTools12.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 17)
                    {
                        vid17.Pause();
                        PlayerPrefs.SetString("ReactionTime13F", reactiontime13.ToString());
                        Data.MyTools13.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 18)
                    {
                        vid18.Pause();
                        PlayerPrefs.SetString("ReactionTime14F", reactiontime14.ToString());
                        Data.MyTools14.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 19)
                    {
                        vid19.Pause();
                        PlayerPrefs.SetString("ReactionTime15F", reactiontime15.ToString());
                        Data.MyTools15.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 20)
                    {
                        vid20.Pause();
                        PlayerPrefs.SetString("ReactionTime16F", reactiontime16.ToString());
                        Data.MyTools16.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 21)
                    {
                        vid21.Pause();
                        PlayerPrefs.SetString("ReactionTime17F", reactiontime17.ToString());
                        Data.MyTools17.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 22)
                    {
                        vid22.Pause();
                        PlayerPrefs.SetString("ReactionTime18F", reactiontime18.ToString());
                        Data.MyTools18.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 23)
                    {
                        vid23.Pause();
                        PlayerPrefs.SetString("ReactionTime19F", reactiontime19.ToString());
                        Data.MyTools19.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 24)
                    {
                        vid24.Pause();
                        PlayerPrefs.SetString("ReactionTime20F", reactiontime20.ToString());
                        Data.MyTools20.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 25)
                    {
                        vid25.Pause();
                        PlayerPrefs.SetString("ReactionTime21F", reactiontime21.ToString());
                        Data.MyTools21.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 26)
                    {
                        vid26.Pause();
                        PlayerPrefs.SetString("ReactionTime22F", reactiontime22.ToString());
                        Data.MyTools22.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 27)
                    {
                        vid27.Pause();
                        PlayerPrefs.SetString("ReactionTime23F", reactiontime23.ToString());
                        Data.MyTools23.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 28)
                    {
                        vid28.Pause();
                        PlayerPrefs.SetString("ReactionTime24F", reactiontime24.ToString());
                        Data.MyTools24.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 29)
                    {
                        vid29.Pause();
                        PlayerPrefs.SetString("ReactionTime25F", reactiontime25.ToString());
                        Data.MyTools25.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 30)
                    {
                        vid30.Pause();
                        PlayerPrefs.SetString("ReactionTime26F", reactiontime26.ToString());
                        Data.MyTools26.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 31)
                    {
                        vid31.Pause();
                        PlayerPrefs.SetString("ReactionTime27F", reactiontime27.ToString());
                        Data.MyTools27.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 32)
                    {
                        vid32.Pause();
                        PlayerPrefs.SetString("ReactionTime28F", reactiontime28.ToString());
                        Data.MyTools28.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 33)
                    {
                        vid33.Pause();
                        PlayerPrefs.SetString("ReactionTime29F", reactiontime29.ToString());
                        Data.MyTools29.DEV_AppendDefaultsToReport();
                    }
                    if (numb == 34)
                    {
                        vid34.Pause();
                        PlayerPrefs.SetString("ReactionTime30F", reactiontime30.ToString());
                        Data.MyTools30.DEV_AppendDefaultsToReport();
                    }
                }
            }          
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (kelb == true)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                numb += 1;
                kelb = false;
                failsafe1 = false;
                lifeline = false;
            }
        }
        if (kelb1 == true)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                numb += 1;
                kelb1 = false;
                failsafe1 = false;
                lifeline = false;
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (numb == 1)
        {
            ins.active = true;
            instructions.text = string.Format("Practice Trial \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;                   
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }             
            }
            
            if (flee1 == true)
            {
                video1.active = true;
                if (ins.active == true)
                {
                    video1.active = true;
                    ins.active = false;
                }
                if (safe1 == false)
                {
                    vid1.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid1.Play();
                    soof1 = true;
                    failsafe2 = true;
                }             
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }            
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid1.Pause();
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    failsafe = false;
                    failsafe2 = false;
                }                 
            }
        }

        if (numb == 2)
        {
            video1.active = false;
            ins.active = true;
            instructions.text = string.Format("Practice Trial \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            } 
            if (flee1 == true)
            {
                video2.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video2.active = true;
                }

                if (safe1 == false)
                {
                    vid2.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid2.Play();
                    soof1 = true;
                    failsafe2 = true;           
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid2.Pause();
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    failsafe = false;
                    failsafe2 = false;
                }
            }
        }

        if (numb == 3)
        {
            video2.active = false;
            ins.active = true;
            instructions.text = string.Format("Practice Trial \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }                
            }
            if (flee1 == true)
            {
                video3.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video3.active = true;
                }

                if (safe1 == false)
                {
                    vid3.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid3.Play();
                    soof1 = true;
                    failsafe2 = true;
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid3.Pause();
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    failsafe = false;
                    failsafe2 = false;
                }              
            }
        }

        if (numb == 4)
        {
            video3.active = false;
            ins.active = true;
            instructions.text = string.Format("Practice Trial \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video4.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video4.active = true;
                }

                if (safe1 == false)
                {
                    vid4.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid4.Play();
                    soof1 = true;
                    failsafe2 = true;
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid4.Pause();
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    failsafe = false;
                    failsafe2 = false;
                }
            }
        }

        if (numb == 5)
        {
            video4.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 1 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video5.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video5.active = true;
                }

                if (safe1 == false)
                {
                    vid5.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid5.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid5.Pause();
                    reactiontime1 = 25;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    failsafe2 = false;
                    PlayerPrefs.SetString("ReactionTime1F", reactiontime1.ToString());
                    Data.MyTools1.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime1 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime1U", reactiontime1.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools1.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }

        if (numb == 6)
        {
            video5.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 2 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video6.active = true;
                
                if (safe1 == false)
                {
                    safe1 = true;
                    vid6.Play();
                    timeisrunning = true;
                }
                if (time > 0.3)
                {
                    if (lifeline == false)
                    {
                        lifeline = true;
                        vid6.Pause();
                        time = 0;
                    }
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid6.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid6.Pause();
                    reactiontime2 = 25;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    failsafe2 = false;
                    PlayerPrefs.SetString("ReactionTime2F", reactiontime2.ToString());
                    Data.MyTools2.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime2 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime2U", reactiontime2.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools2.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }

        if (numb == 7)
        {
            video6.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 3 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video7.active = true;
                
                if (safe1 == false)
                {
                    vid7.Play();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (time > 0.3)
                {
                    if (lifeline == false)
                    {
                        lifeline = true;
                        vid7.Pause();
                        time = 0;
                    }
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid7.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >24.9975)
                {
                    timer = 0;
                    vid7.Pause();
                    reactiontime3 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    failsafe2 = false;
                    PlayerPrefs.SetString("ReactionTime3F", reactiontime3.ToString());
                    Data.MyTools3.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime3 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime3U", reactiontime3.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools3.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }

        if (numb == 8)
        {
            video7.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 4 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video8.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video8.active = true;
                }

                if (safe1 == false)
                {
                    vid8.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid8.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid8.Pause();
                    reactiontime4 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    failsafe2 = false;
                    PlayerPrefs.SetString("ReactionTime4F", reactiontime4.ToString());
                    Data.MyTools4.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime4 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime4U", reactiontime4.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools4.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }

        if (numb == 9)
        {
            video8.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 5 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video9.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video9.active = true;
                }

                if (safe1 == false)
                {
                    vid9.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid9.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid9.Pause();
                    reactiontime5 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    failsafe2 = false;
                    PlayerPrefs.SetString("ReactionTime5F", reactiontime5.ToString());
                    Data.MyTools5.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime5 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime5U", reactiontime5.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools5.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 10)
        {
            video9.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 6 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video10.active = true;
               
                if (safe1 == false)
                {
                    vid10.Play();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (time > 0.3)
                {
                    if (lifeline == false)
                    {
                        lifeline = true;
                        vid10.Pause();
                        time = 0;
                    }
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid10.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid10.Pause();
                    reactiontime6 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime6F", reactiontime6.ToString());
                    Data.MyTools6.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime6 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime6U", reactiontime6.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools6.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 11)
        {
            video10.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 7 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video11.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video11.active = true;
                }

                if (safe1 == false)
                {
                    vid11.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid11.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid11.Pause();
                    reactiontime7 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime7F", reactiontime6.ToString());
                    Data.MyTools7.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime7 += Time.deltaTime;
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime7U", reactiontime7.ToString());
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools7.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 12)
        {
            video11.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 8 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video12.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video12.active = true;
                }

                if (safe1 == false)
                {
                    vid12.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid12.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid12.Pause();
                    reactiontime8 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime8F", reactiontime6.ToString());
                    Data.MyTools8.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime8 += Time.deltaTime;
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime8U", reactiontime8.ToString());
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools8.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 13)
        {
            video12.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 9 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video13.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video13.active = true;
                }

                if (safe1 == false)
                {
                    vid13.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid13.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid13.Pause();
                    reactiontime9 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    failsafe2 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime9F", reactiontime6.ToString());
                    Data.MyTools9.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime9 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime9U", reactiontime9.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools9.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 14)
        {
            video13.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 10 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video14.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video14.active = true;
                }

                if (safe1 == false)
                {
                    vid14.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid14.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid14.Pause();
                    reactiontime10 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime10F", reactiontime6.ToString());
                    Data.MyTools10.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime10 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime10U", reactiontime10.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools10.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 15)
        {
            video14.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 11 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video15.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video15.active = true;
                }

                if (safe1 == false)
                {
                    vid15.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid15.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid15.Pause();
                    reactiontime11 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    failsafe2 = false;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime11F", reactiontime6.ToString());
                    Data.MyTools11.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime11 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime11U", reactiontime11.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools11.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 16)
        {
            video15.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 12 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video16.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video16.active = true;
                }

                if (safe1 == false)
                {
                    vid16.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid16.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid16.Pause();
                    reactiontime12 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    failsafe2 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime12F", reactiontime6.ToString());
                    Data.MyTools12.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime12 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime12U", reactiontime12.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools12.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 17)
        {
            video16.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 13 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video17.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video17.active = true;
                }

                if (safe1 == false)
                {
                    vid17.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid17.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid17.Pause();
                    reactiontime13 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime13F", reactiontime6.ToString());
                    Data.MyTools13.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime13 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime13U", reactiontime13.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools13.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 18)
        {
            video17.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 14 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video18.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video18.active = true;
                }

                if (safe1 == false)
                {
                    vid18.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid18.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid18.Pause();
                    reactiontime14 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime14F", reactiontime6.ToString());
                    Data.MyTools14.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime14 += Time.deltaTime;
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime14U", reactiontime14.ToString());
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools14.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 19)
        {
            video18.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 15 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video19.active = true;
                
                if (safe1 == false)
                {
                    vid19.Play();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (time > 0.3)
                {
                    if (lifeline == false)
                    {
                        lifeline = true;
                        vid19.Pause();
                        time = 0;
                    }
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid19.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid19.Pause();
                    reactiontime15 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime15F", reactiontime6.ToString());
                    Data.MyTools15.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime15 += Time.deltaTime;
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime15U", reactiontime15.ToString());
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools15.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 20)
        {
            video19.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 16 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video20.active = true;
                
                if (safe1 == false)
                {
                    vid20.Play();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (time > 0.3)
                {
                    if (lifeline == false)
                    {
                        lifeline = true;
                        vid20.Pause();
                        time = 0;
                    }
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid20.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid20.Pause();
                    reactiontime16 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime16F", reactiontime6.ToString());
                    Data.MyTools16.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime16 += Time.deltaTime;
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime16U", reactiontime16.ToString());
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools16.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }

        if (numb == 21)
        {
            video20.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 17 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video21.active = true;
                
                if (safe1 == false)
                {
                    vid21.Play();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (time > 0.3)
                {
                    if (lifeline == false)
                    {
                        lifeline = true;
                        vid21.Pause();
                        time = 0;
                    }
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid21.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid21.Pause();
                    reactiontime17 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime17F", reactiontime6.ToString());
                    Data.MyTools17.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime17 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime17U", reactiontime17.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools17.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 22)
        {
            video21.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 18 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video22.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video22.active = true;
                }

                if (safe1 == false)
                {
                    vid22.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid22.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid22.Pause();
                    reactiontime18 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    failsafe2 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime18F", reactiontime6.ToString());
                    Data.MyTools18.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime18 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime18U", reactiontime18.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools18.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 23)
        {
            video22.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 19 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video23.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video23.active = true;
                }

                if (safe1 == false)
                {
                    vid23.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid23.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid23.Pause();
                    reactiontime19 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    failsafe2 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime19F", reactiontime6.ToString());
                    Data.MyTools19.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime19 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime19U", reactiontime19.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools19.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 24)
        {
            video23.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 20 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video24.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video24.active = true;
                }

                if (safe1 == false)
                {
                    vid24.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid24.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid24.Pause();
                    reactiontime20 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime20F", reactiontime6.ToString());
                    Data.MyTools20.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime20 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime20U", reactiontime20.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools20.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 25)
        {
            video24.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 21 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video25.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video25.active = true;
                }

                if (safe1 == false)
                {
                    vid25.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid25.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid25.Pause();
                    reactiontime21 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    failsafe2 = false;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime21F", reactiontime6.ToString());
                    Data.MyTools21.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime21 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime21U", reactiontime21.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools21.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 26)
        {
            video25.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 22 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video26.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video26.active = true;
                }

                if (safe1 == false)
                {
                    vid26.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid26.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid26.Pause();
                    reactiontime22 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    failsafe2 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime22F", reactiontime6.ToString());
                    Data.MyTools22.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime22 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime22U", reactiontime22.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools22.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 27)
        {
            video26.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 23 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video27.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video27.active = true;
                }

                if (safe1 == false)
                {
                    vid27.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid27.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid27.Pause();
                    reactiontime23 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    failsafe2 = false;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime23F", reactiontime6.ToString());
                    Data.MyTools23.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime23 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime23U", reactiontime23.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools23.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 28)
        {
            video27.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 24 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video28.active = true;
                
                if (safe1 == false)
                {
                    vid28.Play();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (time > 0.3)
                {
                    if (lifeline == false)
                    {
                        lifeline = true;
                        vid28.Pause();
                        time = 0;
                    }
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid28.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid28.Pause();
                    reactiontime24 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime24F", reactiontime6.ToString());
                    Data.MyTools24.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime24 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime24U", reactiontime24.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools24.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 29)
        {
            video28.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 25 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     RIGHT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video29.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video29.active = true;
                }

                if (safe1 == false)
                {
                    vid29.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid29.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid29.Pause();
                    reactiontime25 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime25F", reactiontime6.ToString());
                    Data.MyTools25.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime25 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime25U", reactiontime25.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools25.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 30)
        {
            video29.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 26 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video30.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video30.active = true;
                }

                if (safe1 == false)
                {
                    vid30.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid30.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid30.Pause();
                    reactiontime26 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    failsafe2 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime26F", reactiontime6.ToString());
                    Data.MyTools26.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime26 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime26U", reactiontime26.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools26.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }

        if (numb == 31)
        {
            video30.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 27 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video31.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video31.active = true;
                }

                if (safe1 == false)
                {
                    vid31.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid31.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid31.Pause();
                    reactiontime27 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    failsafe2 = false;
                    PlayerPrefs.SetString("ReactionTime27F", reactiontime6.ToString());
                    Data.MyTools27.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime27 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime27U", reactiontime27.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools27.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }

        if (numb == 32)
        {
            video31.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 28 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video32.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video32.active = true;
                }

                if (safe1 == false)
                {
                    vid32.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid32.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid32.Pause();
                    reactiontime28 = 25;
                    sat = false;
                    failsafe2 = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime28F", reactiontime6.ToString());
                    Data.MyTools28.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime28 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime28U", reactiontime28.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools28.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 33)
        {
            video32.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 29 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video33.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video33.active = true;
                }

                if (safe1 == false)
                {
                    vid33.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid33.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid33.Pause();
                    reactiontime29 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    failsafe2 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime29F", reactiontime6.ToString());
                    Data.MyTools29.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime29 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime29U", reactiontime29.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools29.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }
        }
        if (numb == 34)
        {
            video33.active = false;
            ins.active = true;
            instructions.text = string.Format("Trial 30 \n \n Press Q to begin the video trial \n \n Once pressed, you have 5 seconds to view the sorroundings before the video begins \n\n Your task is to press P when you believe it is the safest time to switch to the     LEFT     lane \n\n Then, press Y to move back to the instructions page for the next trial");

            if (failsafe1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    failsafe = true;
                    ins.active = false;
                    flee1 = true;
                    time = 0;
                    failsafe1 = true;
                }
            }
            if (flee1 == true)
            {
                video34.active = true;
                if (ins.active == true)
                {
                    ins.active = false;
                    video34.active = true;
                }

                if (safe1 == false)
                {
                    vid34.Pause();
                    safe1 = true;
                    timeisrunning = true;
                }
                if (timeisrunning == true)
                {
                    time += Time.deltaTime;
                }
                if (time >= 4.9975)
                {
                    time = 0;
                    timeisrunning = false;
                    vid34.Play();
                    soof1 = true;
                    sat = true;
                    failsafe2 = true;

                    if (seef1 == false)
                    {
                        timerisrunning = true;
                        seef1 = true;
                    }
                }
                if (soof1 == true)
                {
                    timer += Time.deltaTime;
                }
                if (timer >= 24.9975)
                {
                    timer = 0;
                    vid34.Pause();
                    reactiontime30 = 25;
                    sat = false;
                    datatime = 0;
                    failsafe2 = false;
                    failsafe = false;
                    timerisrunning = false;
                    soof1 = false;
                    kelb1 = true;
                    flee1 = false;
                    seef1 = false;
                    safe1 = false;
                    PlayerPrefs.SetString("ReactionTime30F", reactiontime6.ToString());
                    Data.MyTools30.DEV_AppendDefaultsToReport();
                }
                if (timerisrunning == true)
                {
                    reactiontime30 += Time.deltaTime;
                    PlayerPrefs.SetString("ReactionTime30U", reactiontime30.ToString());
                }
                if (sat == true)
                {
                    datatime += Time.deltaTime;
                }
                if (datatime >= 0.0125)
                {
                    Data.MyTools30.DEV_AppendDefaultsToReport();
                    datatime = 0;
                }
            }      
        }
        if (numb == 35)
        {
            video34.active = false;
            ins.active = true;
            instructions.text = string.Format("Congradulations! You have successfully completed the experiment! \n\n Thank you for taking the time to participate. You may now press ESCAPE on the keyboard to exit the experiment. \n\n Have a wonderful day!");
            if (Input.GetKey("escape"))
            {
                Application.Quit();
            }
        }
    } 
}
