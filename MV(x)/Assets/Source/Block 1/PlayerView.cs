using UnityEngine;
using UnityEngine.UI;

namespace Source.Block_1
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Text healthText;
        [SerializeField] private SpriteRenderer playerImage;

        public void UpdateHealthDisplay(int currentHealth, int maxHealth)
        {
            healthText.text = $"HP: {currentHealth}/{maxHealth}";
        }

        public void UpdatePlayerAppearance(bool isDead)
        {
            if (isDead)
            {
                playerImage.color = Color.red;  
            }
            else
            {
                playerImage.color = Color.white; 
            }
        }
    }
}