using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarPartida1 : MonoBehaviour
{
    [System.Serializable]
    public struct SaveData
    {
        public float vidaG;
        public int puntaje;
        public int nivel;
        public float velocidad;
    }
    [SerializeField] private SaveData saveData;
    public float vidaG;
    public int puntaje;
    public int nivel;
    public float velocidad;
    bool esguardado = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!esguardado)
        {
            ScriptVida.vidaInicial = (float)100;
            Puntaje.puntajeValor = 900;
            NivelBase.nivel = 0;
            SimpleSampleCharacterControl.m_moveSpeed = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        vidaG = ScriptVida.vidaInicial;
        puntaje = Puntaje.puntajeValor;
        velocidad = SimpleSampleCharacterControl.m_moveSpeed;
        nivel = NivelBase.nivel;
    }

    public void OnLoad(string data)
    {
        SaveData saveData = JsonUtility.FromJson<SaveData>(data);
        ScriptVida.vidaInicial = saveData.vidaG;
        Puntaje.puntajeValor = 900;
        NivelBase.nivel = saveData.nivel;
        SimpleSampleCharacterControl.m_moveSpeed = saveData.velocidad;
        esguardado = true;
    }

    public string OnSave()
    {
        return JsonUtility.ToJson(new SaveData() { vidaG = this.vidaG, puntaje = this.puntaje, nivel = this.nivel, velocidad = this.velocidad });
    }

    public bool OnSaveCondition()
    {
        return true;
    }
}

