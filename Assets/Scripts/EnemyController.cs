using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    #region Enemy Stats
    public int maxHealth = 10;
    public int currentHealth = 10;
    #endregion

    #region Enemy Sprites
    private Image enemySpriteImage;
    private Sprite currentSprite;
    #endregion

    private void Awake()
    {
        enemySpriteImage = GetComponent<Image>();
    }
}
