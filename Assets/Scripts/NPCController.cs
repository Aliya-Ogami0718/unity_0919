using UnityEngine;

namespace Aliya
{
    /// <summary>
    /// NPC 控制器
    /// </summary>
    public class NPCController : MonoBehaviour
    {
        [SerializeField, Header("NPC 資料")]
        private DataNPC dataNPC;

        private Animator ani;

        public DataNPC data => dataNPC;

        private void Awake()
        {
            ani = GetComponent<Animator>();
        }
    }
}

