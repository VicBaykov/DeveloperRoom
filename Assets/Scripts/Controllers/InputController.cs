using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputController : Singleton<InputController>
{
    public UnityAction PressedKeyA_Action;
    public UnityAction PressedKeyB_Action;
    public UnityAction PressedKeyC_Action;
    public UnityAction PressedKeyD_Action;
    public UnityAction PressedKeyE_Action;
    public UnityAction PressedKeyF_Action;
    public UnityAction PressedKeyG_Action;
    public UnityAction PressedKeyH_Action;
    public UnityAction PressedKeyI_Action;
    public UnityAction PressedKeyJ_Action;
    public UnityAction PressedKeyK_Action;
    public UnityAction PressedKeyL_Action;
    public UnityAction PressedKeyM_Action;
    public UnityAction PressedKeyN_Action;
    public UnityAction PressedKeyO_Action;
    public UnityAction PressedKeyP_Action;
    public UnityAction PressedKeyQ_Action;
    public UnityAction PressedKeyR_Action;
    public UnityAction PressedKeyS_Action;
    public UnityAction PressedKeyT_Action;
    public UnityAction PressedKeyU_Action;
    public UnityAction PressedKeyV_Action;
    public UnityAction PressedKeyW_Action;
    public UnityAction PressedKeyX_Action;
    public UnityAction PressedKeyY_Action;
    public UnityAction PressedKeyZ_Action;
    public UnityAction PressedKeyAlpha0_Action;
    public UnityAction PressedKeyAlpha1_Action;
    public UnityAction PressedKeyAlpha2_Action;
    public UnityAction PressedKeyAlpha3_Action;
    public UnityAction PressedKeyAlpha4_Action;
    public UnityAction PressedKeyAlpha5_Action;
    public UnityAction PressedKeyAlpha6_Action;
    public UnityAction PressedKeyAlpha7_Action;
    public UnityAction PressedKeyAlpha8_Action;
    public UnityAction PressedKeyAlpha9_Action;
    public UnityAction PressedKeyMinus_Action;
    public UnityAction PressedKeyEquals_Action;
    public UnityAction PressedKeyBackspace_Action;
    public UnityAction PressedKeyLShift_Action;
    public UnityAction PressedKeyRShift_Action;
    public UnityAction PressedKeyLCtrl_Action;
    public UnityAction PressedKeyRCtrl_Action;
    public UnityAction PressedKeyLAlt_Action;
    public UnityAction PressedKeyRAlt_Action;
    public UnityAction PressedKeySpace_Action;
    public UnityAction PressedKeyTab_Action;
    public UnityAction PressMouseKeyRight_Action;
    public UnityAction PressMouseKeyLeft_Action;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PressedKeyA();
        PressedKeyB();
        PressedKeyC();
        PressedKeyD();
        PressedKeyE();
        PressedKeyF();
        PressedKeyG();
        PressedKeyH();
        PressedKeyI();
        PressedKeyJ();
        PressedKeyK();
        PressedKeyL();
        PressedKeyM();
        PressedKeyN();
        PressedKeyO();
        PressedKeyP();
        PressedKeyQ();
        PressedKeyR();
        PressedKeyS();
        PressedKeyT();
        PressedKeyU();
        PressedKeyV();
        PressedKeyW();
        PressedKeyX();
        PressedKeyY();
        PressedKeyZ();
        PressedKeyMinus();
        PressedKeyEquals();
        PressedKeyBackspace();
        PressedKeyAlpha0();
        PressedKeyAlpha1();
        PressedKeyAlpha2();
        PressedKeyAlpha3();
        PressedKeyAlpha4();
        PressedKeyAlpha5();
        PressedKeyAlpha6();
        PressedKeyAlpha7();
        PressedKeyAlpha8();
        PressedKeyAlpha9();
        PressedKeyTab();
        PressedKeySpace();
        PressedKeyRShift();
        PressedKeyLShift();
        PressedKeyRCtrl();
        PressedKeyLCtrl();
        PressedKeyRAlt();
        PressedKeyLAlt();
        PressMouseKeyRight();
        PressMouseKeyLeft();
    }

    void PressedKeyA()
    {
        if (Input.GetKey(KeyCode.A))
            PressedKeyA_Action?.Invoke();
    }
    
    void PressedKeyB()
    {
        if (Input.GetKey(KeyCode.B))
            PressedKeyB_Action?.Invoke();
    }
    
    void PressedKeyC()
    {
        if (Input.GetKey(KeyCode.C))
            PressedKeyC_Action?.Invoke();
    }
    
    void PressedKeyD()
    {
        if (Input.GetKey(KeyCode.D))
            PressedKeyD_Action?.Invoke();
    }
    
    void PressedKeyE()
    {
        if (Input.GetKey(KeyCode.E))
            PressedKeyE_Action?.Invoke();
    }
    
    void PressedKeyF()
    {
        if (Input.GetKey(KeyCode.F))
            PressedKeyF_Action?.Invoke();
    }
    
    void PressedKeyG()
    {
        if (Input.GetKey(KeyCode.G))
            PressedKeyG_Action?.Invoke();
    }
    
    void PressedKeyH()
    {
        if (Input.GetKey(KeyCode.H))
            PressedKeyH_Action?.Invoke();
    }
    
    void PressedKeyI()
    {
        if (Input.GetKeyDown(KeyCode.I))
            PressedKeyI_Action?.Invoke();
    }
    
    void PressedKeyJ()
    {
        if (Input.GetKey(KeyCode.J))
            PressedKeyJ_Action?.Invoke();
    }
    
    void PressedKeyK()
    {
        if (Input.GetKey(KeyCode.K))
            PressedKeyK_Action?.Invoke();
    }
    
    void PressedKeyL()
    {
        if (Input.GetKey(KeyCode.L))
            PressedKeyL_Action?.Invoke();
    }
    
    void PressedKeyM()
    {
        if (Input.GetKey(KeyCode.M))
            PressedKeyM_Action?.Invoke();
    }
    
    void PressedKeyN()
    {
        if (Input.GetKey(KeyCode.N))
            PressedKeyN_Action?.Invoke();
    }
    
    void PressedKeyO()
    {
        if (Input.GetKey(KeyCode.O))
            PressedKeyO_Action?.Invoke();
    }
    
    void PressedKeyP()
    {
        if (Input.GetKey(KeyCode.P))
            PressedKeyP_Action?.Invoke();
    }
    
    void PressedKeyQ()
    {
        if (Input.GetKey(KeyCode.Q))
            PressedKeyQ_Action?.Invoke();
    }
    
    void PressedKeyR()
    {
        if (Input.GetKey(KeyCode.R))
            PressedKeyR_Action?.Invoke();
    }
    
    void PressedKeyS()
    {
        if (Input.GetKey(KeyCode.S))
            PressedKeyS_Action?.Invoke();
    }
    
    void PressedKeyT()
    {
        if (Input.GetKey(KeyCode.T))
            PressedKeyT_Action?.Invoke();
    }
    
    void PressedKeyU()
    {
        if (Input.GetKey(KeyCode.U))
            PressedKeyU_Action?.Invoke();
    }
    
    void PressedKeyV()
    {
        if (Input.GetKey(KeyCode.V))
            PressedKeyV_Action?.Invoke();
    }
    
    void PressedKeyW()
    {
        if (Input.GetKey(KeyCode.W))
            PressedKeyW_Action?.Invoke();
    }
    
    void PressedKeyX()
    {
        if (Input.GetKey(KeyCode.X))
            PressedKeyX_Action?.Invoke();
    }
    
    void PressedKeyY()
    {
        if (Input.GetKey(KeyCode.Y))
            PressedKeyY_Action?.Invoke();
    }
    
    void PressedKeyZ()
    {
        if (Input.GetKey(KeyCode.Z))
            PressedKeyZ_Action?.Invoke();
    }
    
    void PressedKeyAlpha0()
    {
        if (Input.GetKey(KeyCode.Alpha0))
            PressedKeyAlpha0_Action?.Invoke();
    }
    
    void PressedKeyAlpha1()
    {
        if (Input.GetKey(KeyCode.Alpha1))
            PressedKeyAlpha1_Action?.Invoke();
    }
    
    void PressedKeyAlpha2()
    {
        if (Input.GetKey(KeyCode.Alpha2))
            PressedKeyAlpha2_Action?.Invoke();
    }
    
    void PressedKeyAlpha3()
    {
        if (Input.GetKey(KeyCode.Alpha3))
            PressedKeyAlpha3_Action?.Invoke();
    }
    
    void PressedKeyAlpha4()
    {
        if (Input.GetKey(KeyCode.Alpha4))
            PressedKeyAlpha4_Action?.Invoke();
    }
    
    void PressedKeyAlpha5()
    {
        if (Input.GetKey(KeyCode.Alpha5))
            PressedKeyAlpha5_Action?.Invoke();
    }
    
    void PressedKeyAlpha6()
    {
        if (Input.GetKey(KeyCode.Alpha6))
            PressedKeyAlpha6_Action?.Invoke();
    }
    
    void PressedKeyAlpha7()
    {
        if (Input.GetKey(KeyCode.Alpha7))
            PressedKeyAlpha7_Action?.Invoke();
    }
    
    void PressedKeyAlpha8()
    {
        if (Input.GetKey(KeyCode.Alpha8))
            PressedKeyAlpha8_Action?.Invoke();
    }
    
    void PressedKeyAlpha9()
    {
        if (Input.GetKey(KeyCode.Alpha9))
            PressedKeyAlpha9_Action?.Invoke();
    }
    
    void PressedKeyMinus()
    {
        if (Input.GetKey(KeyCode.Minus))
            PressedKeyMinus_Action?.Invoke();
    }
    
    void PressedKeyEquals()
    {
        if (Input.GetKey(KeyCode.Equals))
            PressedKeyEquals_Action?.Invoke();
    }
    
    void PressedKeyBackspace()
    {
        if (Input.GetKey(KeyCode.Backspace))
            PressedKeyBackspace_Action?.Invoke();
    }
    
    void PressedKeyTab()
    {
        if (Input.GetKey(KeyCode.Tab))
            PressedKeyTab_Action?.Invoke();
    }
    
    void PressedKeyRShift()
    {
        if (Input.GetKey(KeyCode.RightShift))
            PressedKeyRShift_Action?.Invoke();
    }
    
    void PressedKeyLShift()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            PressedKeyLShift_Action?.Invoke();
    }
    
    void PressedKeyRCtrl()
    {
        if (Input.GetKey(KeyCode.RightControl))
            PressedKeyRCtrl_Action?.Invoke();
    }
    
    void PressedKeyLCtrl()
    {
        if (Input.GetKey(KeyCode.LeftControl))
            PressedKeyLCtrl_Action?.Invoke();
    }
    
    void PressedKeyRAlt()
    {
        if (Input.GetKey(KeyCode.RightAlt))
            PressedKeyRAlt_Action?.Invoke();
    }
    
    void PressedKeyLAlt()
    {
        if (Input.GetKey(KeyCode.LeftAlt))
            PressedKeyLAlt_Action?.Invoke();
    }
    
    void PressedKeySpace()
    {
        if (Input.GetKey(KeyCode.Space))
            PressedKeySpace_Action?.Invoke();
    }

    void PressMouseKeyRight()
    {
        if (Input.GetMouseButtonDown(1)) 
            PressMouseKeyRight_Action?.Invoke();
    }
    
    void PressMouseKeyLeft()
    {
        if (Input.GetMouseButtonDown(0)) 
            PressMouseKeyLeft_Action?.Invoke();
    }

}
