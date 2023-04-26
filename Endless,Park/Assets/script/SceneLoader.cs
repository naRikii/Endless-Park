using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] public int SceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
     
    }
    public void customSceneLoadByIndex()
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void begin()
    {
        SceneManager.LoadScene("scene1");
    }
    public void goback()
    {
        SceneManager.LoadScene("SampleScene 1");
    }
    public void quit()
    {
        Application.Quit(); 
    }
    public void levelone()
    {
        SceneManager.LoadScene("scene2");
    }
    public void leveltwo()
    {
        SceneManager.LoadScene("scene3");
    }
    public void subsect1()
    {
        SceneManager.LoadScene("scene4-1");
    }
    public void subsect2()
    {
        SceneManager.LoadScene("scene4-2");
    }
    public void apartment()
    {
        SceneManager.LoadScene("scene4-3");
    }
    public void room1()
    {
        SceneManager.LoadScene("room1");
    }
    public void room2()
    {
        SceneManager.LoadScene("room2");
    }
    public void room3()
    {
        SceneManager.LoadScene("room3");
    }
    public void room4()
    {
        SceneManager.LoadScene("room4");
    }
    public void Cookiezi()
    {
        SceneManager.LoadScene("room2s");
    }
     public void rrtyui()
    {
        SceneManager.LoadScene("room2ss");
    }
   public void airportwall()
    {
        SceneManager.LoadScene("airport");
    }
    public void airportway()
    {
        SceneManager.LoadScene("hallway");
    }
    public void airplane()
    {
        SceneManager.LoadScene("airplane");
    }
    public void sitdown()
    {
        SceneManager.LoadScene("sitting");
    }
    public void takeoff()
    {
        SceneManager.LoadScene("takenoff");
    }
   public void path21()
    {
        SceneManager.LoadScene("lonely");
    }
    public void path22()
    {
        SceneManager.LoadScene("path2-2");
    }
    public void path23()
    {
        SceneManager.LoadScene("path2-3");
    }
    public void path24()
    {
        SceneManager.LoadScene("path2-4");
    }
    public void resetreset()
    {
        SceneManager.LoadScene("literallyjustablackscreenlol");
    }
    public void well()
    {
        SceneManager.LoadScene("well");
    }
    public void review()
    {
        SceneManager.LoadScene("outside");
    }
    public void path41()
    {
        SceneManager.LoadScene("demonstration");
    }
    public void path411()
    {
        SceneManager.LoadScene("inside");
    }
}
