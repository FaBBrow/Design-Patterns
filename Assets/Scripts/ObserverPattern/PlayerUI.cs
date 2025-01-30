using System;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI healthtext;
   
   private void Start()
   {
     
      healthtext.text = PlayerStats.instance.Health.ToString();
      PlayerStats.instance.onHealthChanged += changeUI;
   }

  

   public void changeUI()
   {
      healthtext.text = PlayerStats.instance.Health.ToString();
   }
}
