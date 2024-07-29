using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour
{
 public void Empty()
    {
        SceneManager.LoadScene("EmptyUI");
    } 
    public void Full()
    {
        SceneManager.LoadScene("chooseUI");
    }    
    public void EmtpyRoom1()
    {
        SceneManager.LoadScene("Emptyroom1");
    }    
    public void EmtpyRoom2()
    {
        SceneManager.LoadScene("Emptyroom2");
    }    
    public void EmtpyRoom3()
    {
        SceneManager.LoadScene("Emptyroom3");
    }  
    public void EmtpyRoom4()
    {
        SceneManager.LoadScene("Emptyroom4");
    }   
    public void EmtpyRoom5()
    {
        SceneManager.LoadScene("Emptyroom5");
    }    
    public void FullRoom1()
    {
        SceneManager.LoadScene("ROOM1");
    }    
    public void FullRoom2()
    {
        SceneManager.LoadScene("ROOM2");
    }    
    public void Back()
    {
        SceneManager.LoadScene("EmptyUI");
    }   
    public void Backll()
    {
        SceneManager.LoadScene("HomeUi");
    }
}
