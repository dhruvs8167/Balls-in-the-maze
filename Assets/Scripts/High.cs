
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class High : MonoBehaviour {
    private int time = 0;
    public Text timer;
    public Text high;
   

    // Use this for initialization
    public void Start () {
        
            time = 0;
            InvokeRepeating("IncrimentTime", 1, 1);
        
    }

     
        
   public void IncrimentTime()
    {
        time += 1;
        timer.text = "Time: " + time;
        high.text = "Your Score -->  " + time;
    }
    
    public void Stop()
    {
        CancelInvoke();
    }
}
