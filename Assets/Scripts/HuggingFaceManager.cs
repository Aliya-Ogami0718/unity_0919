using TMPro;
using UnityEngine;

namespace Aliya
{
    /// <summary>
    /// Hugging Face 管理器
    /// </summary>
    /// 排版快捷鍵Ctrl+K+D
    public class HuggingFaceManager : MonoBehaviour

    {
        [SerializeField, Header("要互動的NPC")]
        private NPCController npc;

        private string key = "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";
        private string model = "https://api-inference.huggingface.co/models/sentence-transformers/all-MiniLM-L6-v2";

        private TMP_InputField inputFieldPlayer;

        private void Awake()
        {
            inputFieldPlayer = GameObject.Find("輸入欄位").GetComponent<TMP_InputField>();
            inputFieldPlayer.onEndEdit.AddListener(PlayerInput);
        }
        private void PlayerInput(string input)
        {
            print($"<color=#3f3>玩家輸入 : {input}</color>");
        }
    }

}
