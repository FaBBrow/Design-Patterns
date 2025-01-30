using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StateController : MonoBehaviour
{
  [SerializeField] private TextMeshProUGUI statetext;
  private Istate CurrentState;
  

  private void Start()
  {
    CurrentState = new IdleState();
    statetext.text = CurrentState.toString();
  }

  private void Update()
  {
    CurrentState.Handle(this);
  
    
  }

  public void SetState(Istate state)
  {
    CurrentState = state;
    statetext.text = CurrentState.toString();
  }
}
