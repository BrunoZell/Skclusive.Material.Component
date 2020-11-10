﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Skclusive.Core.Component;
using Skclusive.Material.Core;

namespace Skclusive.Material.List
{
    public partial class ListItemIcon : MaterialComponent
    {
        public ListItemIcon() : base("ListItemIcon")
        {
        }

        /// <summary>
        /// html component tag to be used as container.
        /// </summary>
        [Parameter]
        public string Component { set; get; } = "div";

        [CascadingParameter]
        public IListContext ListContext { set; get; }

        protected override IEnumerable<string> Classes
        {
            get
            {
                foreach (var item in base.Classes)
                    yield return item;

                if (ListContext?.AlignItems == AlignItems.FlexStart)
                    yield return $"{nameof(AlignItems)}-{nameof(AlignItems.FlexStart)}";
            }
        }
    }
}
