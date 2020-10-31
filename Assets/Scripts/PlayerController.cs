using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    #region Player Stats
    public int maxHealth = 100;
    public int currentHealth = 100;
    public int score = 0;
    #endregion

    #region Player Sprites
    private Image playerSpriteImage;
    private Sprite currentSprite;
    #endregion

    private void Awake()
    {
        playerSpriteImage = GetComponent<Image>();
    }
}
