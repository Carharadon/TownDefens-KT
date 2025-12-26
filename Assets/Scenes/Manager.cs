using System.Runtime.CompilerServices;
using TMPro;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [Header("UI")]

    public TextMeshProUGUI WheatCounter;

    [Header("Таймеры")]
    public float PTaimer;
    private float _curPTaimer = 0f;
    public bool inPTimer = false;

    public float EatTaimer = 0f;
    private float _curEatTaimer = 0f;
    public bool inEatTaimer = false;

    public float NTaimer;
    private float _curNTaimer = 0f;
    public bool inNTaimer = false;

    public float AttackTaimer = 0f;
    private float _curAttackTaimer = 0f;
    public bool inAttackTaimer = false;

    [Header("Настройки")]

    public int WheatBaseProdaction;
    public int PeasantsCoust;
    public int PeasantsProdaction;
    public int WarriorsCoust;
    public int WarriorsEat;
    public int[] EnimyCountInWafe;

    private int _warriorsCount = 0;
    private int _peasentsCount = 0;

    void Update()
    {
        _curPTaimer += Time.deltaTime;
        _curEatTaimer += Time.deltaTime;
        _curNTaimer += Time.deltaTime;
        _curAttackTaimer += Time.deltaTime;
    }
}
