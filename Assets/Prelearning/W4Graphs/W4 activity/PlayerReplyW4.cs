using System;
using UnityEngine;
using Unity.VisualScripting;

namespace W4Activity
{
    [Serializable][Inspectable]
    public class PlayerReplyW4
    {
        //---------------------------------------------------------------------
        // Variables
        //---------------------------------------------------------------------
        [Inspectable] public string line;
        [Inspectable] public Sprite portrait;
        [Inspectable] public DialogueNodeW4 nextNode;
    }
}