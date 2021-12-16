using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Code : MonoBehaviour
{
    public string sayi1;
    public string sayi2;
    public int sonuc;

    public Text sayi1Text;
    public Text sayi2Text;
    public Text sonucText;

    // Start is called before the first frame update
    void Start()    
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sayi1 = sayi1Text.text;
        sayi2 = sayi2Text.text;
    }

    public void Topla()
    {
        sonuc = int.Parse(sayi1) + int.Parse(sayi2);
        sonucText.text = sonuc.ToString();
    }
    public void Cikar()
    {
        sonuc = int.Parse(sayi1) - int.Parse(sayi2);
        sonucText.text = sonuc.ToString();
    }
    public void Bol()
    {
        sonuc = int.Parse(sayi1) / int.Parse(sayi2);
        sonucText.text = sonuc.ToString();
    }
    public void Carp()
    {
        sonuc = int.Parse(sayi1) * int.Parse(sayi2);
        sonucText.text = sonuc.ToString();
    }


}
