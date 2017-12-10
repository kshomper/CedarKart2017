using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour {
    public GameplayController player;
    public GameMaster gm;

    Animator gameOverAnim;
    Animator fadeOutAnim;

	// Use this for initialization
	void Start () {
        gameOverAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        fadeOutAnim = player.Anim;
        fadeOutAnim.SetTrigger("FadeOut");

        if (player != null && (player.Lives <= 0 || gm.timer <=0))
        {
            fadeOutAnim.SetTrigger("FadeOut");
            //Destroy(player.gameObject, 2f);
            //player.gameObject.SetActive(false);
            gameOverAnim.SetTrigger("GameOver");
        }
	}
}
