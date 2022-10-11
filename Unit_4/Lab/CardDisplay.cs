uisng Systems.Collections;
using Systems.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : Monobehavior
{
    public Card card;
    public Text nameText;
    public Text descriptionText;
    
    public Image artwork;
    
    public Text manaText;
    public Text attackText;
    public Text healthText;
    
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        
        artwork.sprite = card.artwork;
        
        manaText.text = card.manaCost.ToString();
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
        
    }
}
