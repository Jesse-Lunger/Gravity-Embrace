using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI prommptTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void updateText(string promptMessage){
        prommptTxt.text = promptMessage;
    }

}
