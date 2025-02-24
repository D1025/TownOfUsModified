using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TownOfUs.Patches.Lobby
{
    public class AbstractPagingBehaviour : MonoBehaviour
    {
        public AbstractPagingBehaviour(IntPtr ptr) : base(ptr)
        {
        }

        private int _page;

        public virtual int MaxPerPage => 20;
        // public virtual IEnumerable<T> Targets { get; }

        public virtual int PageIndex
        {
            get => _page;
            set
            {
                _page = value;
                OnPageChanged();
            }
        }

        public virtual int MaxPageIndex => throw new NotImplementedException();
        // public virtual int MaxPages => Targets.Count() / MaxPerPage;

        public virtual void OnPageChanged() => throw new NotImplementedException();

        public virtual void Start() => OnPageChanged();

    

        /// <summary>
        /// Loops around if you go over the limits.<br/>
        /// Attempting to go up a page while on the first page will take you to the last page and vice versa.
        /// </summary>
        public virtual void Cycle(bool increment)
        {
            var change = increment ? 1 : -1;
            PageIndex = Mathf.Clamp(PageIndex + change, 0, MaxPageIndex);
        }
    }
}
