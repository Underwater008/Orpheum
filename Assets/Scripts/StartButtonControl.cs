using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StartButtonControl : MonoBehaviour {
  public AppleRotate appRotate;
  public PuzzleSequenceControl puzzleSeqControl;
  public DecayPuzzleControl decayPuzzleControl;
  public Transform posAfterClick;

  public SoundManager soundManager;

  // Start is called before the first frame update
  void Start() {
  }

  // Update is called once per frame
  void Update() {

  }

  public void OnClick() {
    //if (appRotate == null) { Debug.Log("app rotate null"); return; }

    if (appRotate.GetComponent<AppleRotate>().isStart == true) { 
      Debug.Log("pressed first button");
    soundManager.PlayAudioClick();
    soundManager.PlayAudioRotate();
    transform.DOMove(posAfterClick.position, 1).OnComplete(() => {
      //appRotate.isStart = false;
      Debug.Log("2");
      appRotate.StartTheFirstStage();
    });
  }
    else if (puzzleSeqControl.GetComponent<PuzzleSequenceControl>().isEndingSeuence == true) {
      //GameManager.Instance.isGameStart = false;
      Debug.Log("pressed Ending first button");
      soundManager.PlayAudioClick();
      soundManager.PlayAudioRotate();
      transform.DOMove(posAfterClick.position, 1).OnComplete(() => {
      puzzleSeqControl.StartTheFirstStage();
      });
      }
    else if (decayPuzzleControl.GetComponent<DecayPuzzleControl>().isDecay == true) {
      Debug.Log("pressed Decay first button");
      soundManager.PlayAudioClick();
      soundManager.PlayAudioRotate();
      transform.DOMove(posAfterClick.position, 1).OnComplete(() => {
        decayPuzzleControl.StartTheFirstStage();
        
      });
    }
  }
}
