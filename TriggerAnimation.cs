using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public GameObject sharon;
    public AudioSource source;
    public AudioClip clip0, clip1, clip2, clip3, clip4, clip5, clip6, clip7, clip8, clip9, clip10, clip11, clip12, clip13, clip14, clip15, clip16, clip17, clip18, clip19, clip20, clip21, clip22, clip23, clip24, clip25, clip26, clip27, clip28;
    private int value = 1;
    private void Start()
    {
        StartCoroutine(CallFunctionWithDelay(YourFunction, 30.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 74.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 83.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 100.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 123.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 147.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 175.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 185.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 199.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 230.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 269.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 274.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 310.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 365.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 430.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 439.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 457.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 475.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 504.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 519.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 549.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 560.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 576.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 603.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 612.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 667.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 716.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 734.0f));
        StartCoroutine(CallFunctionWithDelay(YourFunction, 750.0f));
        // StartCoroutine(CallFunctionWithDelay(YourFunction, 60.0f));
        // StartCoroutine(CallFunctionWithDelay(YourFunction, 60.0f));


    }

    private IEnumerator CallFunctionWithDelay(System.Action functionToCall, float delay)
    {
        yield return new WaitForSeconds(delay);
        functionToCall.Invoke();
    }



    private void YourFunction()

    {

        if (value == 1)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip0);
        }
        else if (value == 2)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip1);
        }
        else if (value == 3)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip2);
        }
        else if (value == 4)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip3);
        }
        else if (value == 5)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip4);

        }
        else if (value == 6)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip5);
        }
        else if (value == 7)
        {
            sharon.GetComponent<Animator>().Play("Sitting Victory");
            source.PlayOneShot(clip6);
        }
        else if (value == 8)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip7);
        }
        else if (value == 9)
        {
            sharon.GetComponent<Animator>().Play("Cheering While Sitting");
            source.PlayOneShot(clip8);
        }
        else if (value == 10)
        {
            sharon.GetComponent<Animator>().Play("Sitting Yell");
            source.PlayOneShot(clip9);
        }
        else if (value == 11)
        {
            sharon.GetComponent<Animator>().Play("Sitting Clap");
            source.PlayOneShot(clip10);
        }
        else if (value == 12)
        {
            sharon.GetComponent<Animator>().Play("Fist Pump");
            source.PlayOneShot(clip11);
        }
        else if (value == 13)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip12);
        }
        else if (value == 14)
        {
            sharon.GetComponent<Animator>().Play("Talking");
            source.PlayOneShot(clip13);
        }
        else if (value == 15)
        {
            sharon.GetComponent<Animator>().Play("Sitting Yell");
            source.PlayOneShot(clip14);
        }
        else if (value == 16)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip15);
        }
        else if (value == 17)
        {
            sharon.GetComponent<Animator>().Play("Sitting Clap");
            source.PlayOneShot(clip16);
        }
        else if (value == 18)
        {
            sharon.GetComponent<Animator>().Play("Sitting dis");
            source.PlayOneShot(clip17);
        }
        else if (value == 19)
        {
            sharon.GetComponent<Animator>().Play("Sitting Angry");
            source.PlayOneShot(clip18);
        }
        else if (value == 20)
        {
            sharon.GetComponent<Animator>().Play("Standing Cheering");
            source.PlayOneShot(clip19);
        }
        else if (value == 21)
        {
            sharon.GetComponent<Animator>().Play("Struck In Head");
            source.PlayOneShot(clip20);
        }
        else if (value == 22)
        {
            sharon.GetComponent<Animator>().Play("Sitting Cheering");
            source.PlayOneShot(clip21);
        }
        else if (value == 23)
        {
            sharon.GetComponent<Animator>().Play("Sitting And Pointing");
            source.PlayOneShot(clip22);
        }
        else if (value == 24)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip23);
        }
        else if (value == 25)
        {
            sharon.GetComponent<Animator>().Play("Banging Fist");
            source.PlayOneShot(clip24);
        }
        else if (value == 26)
        {
            sharon.GetComponent<Animator>().Play("Sitting Victory");
            source.PlayOneShot(clip25);
        }
        else if (value == 27)
        {
            sharon.GetComponent<Animator>().Play("Cheering While Sitting");
            source.PlayOneShot(clip26);
        }
        else if (value == 28)
        {
            sharon.GetComponent<Animator>().Play("Fist Pump");
            source.PlayOneShot(clip27);
        }
        else if (value == 29)
        {
            sharon.GetComponent<Animator>().Play("Standing Clap");
            source.PlayOneShot(clip28);
        }


        value = value + 1;

    }


    //     void Update()
    //     {



    //         if (Input.GetButtonDown("0Key"))
    //         {
    //             sharon.GetComponent<Animator>().Play("Sitting Disbelief");
    //         }
    //         if (Input.GetButtonDown("1Key"))
    //         {
    //             sharon.GetComponent<Animator>().Play("Sitting Disapproval");
    //         }
    //         if (Input.GetButtonDown("2Key"))
    //         {
    //             sharon.GetComponent<Animator>().Play("Victory");
    //         }
    //         if (Input.GetButtonDown("3Key"))
    //         {
    //             sharon.GetComponent<Animator>().Play("Sitting Victory");
    //         }
    //         if (Input.GetButtonDown("4Key"))
    //         {
    //             sharon.GetComponent<Animator>().Play("Hip Hop Dancing");
    //         }
    //         if (Input.GetButtonDown("5Key"))
    //         {
    //             sharon.GetComponent<Animator>().Play("Standing Clap");
    //         }
    //         if (Input.GetButtonDown("6Key"))
    //         {
    //             sharon.GetComponent<Animator>().Play("Sitting Victory");
    //         }
    //         if (Input.GetButtonDown("7Key"))
    //         {
    //             sharon.GetComponent<Animator>().Play("Standing Clap");
    //         }


    //     }




}

