using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Cake : MonoBehaviour
{
    public GameObject TextBox;
    public TextMeshProUGUI Text;
    public string npcText;
    public bool isF;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TextBox.SetActive(true);
            Text.text = npcText;
            isF=true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (isF)
        {
            TextBox.SetActive(false);
            GameObject One = this.gameObject;
            One.SetActive(false);
        }
    }
}
