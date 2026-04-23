using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace W4Activity
{
    public class DialogueButtonW4 : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Button _button;
        [SerializeField] private GameObject characterIMG;

        public void SetupButton (PlayerReplyW4 reply)
        {
            _text.text = reply.line;
            characterIMG.GetComponent<SetNewImage>().SetDesiredImage(reply.portrait);

            _button.onClick.AddListener(delegate
            {
                DialogueAdvancerW4._Instance.ChooseDialogue(reply.nextNode);
            });
        }
    }
}