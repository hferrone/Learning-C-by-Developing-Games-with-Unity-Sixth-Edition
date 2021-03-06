using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// IMPORTANT!
/// 
/// This first script will be a long one, so I've put comments to separate out each
/// Time for Action sections.
///
/// If you need to find a specific one in the book, use the table of contents and the
/// Time for Action name :)
/// 
/// </summary>
public class LearningCurve : MonoBehaviour
{
    // Time for action - making a variable private
    private int currentAge = 30;
    public int addedAge = 1;

    // Time for action - playing with different types
    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        // Time for action - creating a variable
        Debug.Log(30 + 1);
        Debug.Log(currentAge + 1);

        // Time for action - creating a simple method
        ComputeAge();

        // Time for action - creating interpolated strings
        Debug.Log($"A string can have variables like {firstName} inserted directly!");

        // Time for action - executing incorrect type operations
        //Debug.Log(firstName * pi);

        // Time for action - defining a simple method
        //GenerateCharacter();

        // Time for action - adding a return type
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);

        // Time for action - capturing return values
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", characterLevel));
    }

    public int GenerateCharacter(string name, int level)
    {
        // Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        // Time for action - adding a return type
        return level += 5;
    }

    /// <summary>
    /// Time for action - adding comments
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
}
