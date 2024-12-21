using TMPro;
using UnityEngine;

namespace Aliya
{
    /// <summary>
    /// Hugging Face �޲z��
    /// </summary>
    /// �ƪ��ֱ���Ctrl+K+D
    public class HuggingFaceManager : MonoBehaviour

    {
        [SerializeField, Header("�n���ʪ�NPC")]
        private NPCController npc;

        private string key = "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";
        private string model = "https://api-inference.huggingface.co/models/sentence-transformers/all-MiniLM-L6-v2";

        private TMP_InputField inputFieldPlayer;

        private void Awake()
        {
            inputFieldPlayer = GameObject.Find("��J���").GetComponent<TMP_InputField>();
            inputFieldPlayer.onEndEdit.AddListener(PlayerInput);
        }
        private void PlayerInput(string input)
        {
            print($"<color=#3f3>���a��J : {input}</color>");
        }
    }

}
