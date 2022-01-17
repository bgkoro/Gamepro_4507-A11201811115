using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Perilaku : MonoBehaviour
{
    
    public Text PowerupText;
    private string PowerNum;

    void OnCollisionEnter2D(Collision2D coll){
if (coll.gameObject.tag == "enemyTag"){
     if(PowerNum == "Off"){
        Debug.Log("Game Over");
        Die();
     }else{

     }
    }
else if(coll.gameObject.tag == "finishTag"){
    Debug.Log("FINISHH !!!");
    Finish();
    }
}

    // Start is called before the first frame update
    void Start()
    {
        

        PowerNum = "Off";
        PowerupText.text = "Power Up : " +PowerNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Die(){
        Debug.Log("GAME OVER");
        SceneManager.LoadScene ("Gameover");
    }
    void Finish(){
        Debug.Log("Finish");
        SceneManager.LoadScene ("Finish");
    }
    

    private void OnTriggerEnter2D(Collider2D Powerup){

        if(Powerup.tag =="powerupTag"){

        PowerNum = "On";
        Destroy(Powerup.gameObject);
        PowerupText.text = "Power Up : " +PowerNum;

        }
    }
}
