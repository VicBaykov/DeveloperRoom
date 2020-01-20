using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathTree : MonoBehaviour
{
    public Color m_evaluating;

    public Color m_succeeded;

    public Color m_failed;

    public Selector m_rootNode;

    public ActionNode m_node2A;

    public Inverter m_node2B;

    public ActionNode m_node2C;

    public ActionNode m_node3;

    public GameObject m_rootNodeBox;
    public GameObject m_node2ABox;
    public GameObject m_node2BBox;
    public GameObject m_node2CBox;
    public GameObject m_node3Box;

    public int m_targetValue = 20;
    public int m_currentValue = 0;

    [SerializeField] private Text m_valueLabel;
    
    // Start is called before the first frame update
    void Start()
    {
        m_node3 = new ActionNode(NotEqualToTarget);
        m_node2A = new ActionNode(AddTen);
        m_node2B = new Inverter(m_node3);
        m_node2C = new ActionNode(AddTen);

        List<Node> rootChildren = new List<Node>();
        rootChildren.Add(m_node2A);
        rootChildren.Add(m_node2B);
        rootChildren.Add(m_node2C);

        m_rootNode = new Selector(rootChildren);
        m_valueLabel.text = m_currentValue.ToString();
        m_rootNode.Evaluate();
        UpdateBoxes();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateBoxes()
    {
        if (m_rootNode.nodeState == NodeStates.SUCCESS)
            SetSucceeded(m_rootNodeBox);
        else if (m_rootNode.nodeState == NodeStates.FAILURE)
            SetFailed(m_rootNodeBox);
        if (m_node2A.nodeState == NodeStates.SUCCESS)
            SetSucceeded(m_node2ABox);
        else if (m_node2A.nodeState == NodeStates.FAILURE)
            SetFailed(m_node2ABox);
        if (m_node2B.nodeState == NodeStates.SUCCESS)
            SetSucceeded(m_node2BBox);
        else if (m_node2B.nodeState == NodeStates.FAILURE)
            SetFailed(m_node2BBox);
        if (m_node2C.nodeState == NodeStates.SUCCESS)
            SetSucceeded(m_node2CBox);
        else if (m_node2C.nodeState == NodeStates.FAILURE)
            SetFailed(m_node2CBox);
        if (m_node3.nodeState == NodeStates.SUCCESS)
            SetSucceeded(m_node3Box);
        else if (m_node3.nodeState == NodeStates.FAILURE)
            SetFailed(m_node3Box);
    }

    private NodeStates NotEqualToTarget()
    {
        if (m_currentValue != m_targetValue)
            return NodeStates.SUCCESS;
        else
            return NodeStates.FAILURE;   
    }

    private NodeStates AddTen()
    {
        m_currentValue += 10;
        m_valueLabel.text = m_currentValue.ToString();
        if (m_currentValue == m_targetValue)
            return NodeStates.SUCCESS;
        else
        {
            return NodeStates.FAILURE;
        }
    }

    void SetSucceeded(GameObject go)
    {
        go.GetComponent<Renderer>().material.color = m_succeeded;
    }

    void SetFailed(GameObject go)
    {
        go.GetComponent<Renderer>().material.color = m_failed;
    }
}

