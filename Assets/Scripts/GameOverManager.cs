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
        float endTimer = 2f;
        if (player != null && (player.Lives <= 0 || gm.timer <=0))
        {
            endTimer -= Time.deltaTime;
            fadeOutAnim = player.Anim;
            fadeOutAnim.SetTrigger("FadeOut");
            if(endTimer < 0)
            {
                player.gameObject.SetActive(false);
            }
            gameOverAnim.SetTrigger("GameOver");
        }
	}
}
