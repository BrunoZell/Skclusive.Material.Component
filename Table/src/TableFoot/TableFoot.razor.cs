﻿using Microsoft.AspNetCore.Components;
using Skclusive.Core.Component;
using Skclusive.Material.Core;

namespace Skclusive.Material.Table
{
    public partial class TableFoot : MaterialComponent
    {
        public TableFoot() : base("TableFoot")
        {
        }

        /// <summary>
        /// html component tag to be used as container.
        /// </summary>
        [Parameter]
        public string Component { set; get; } = "tfoot";

        protected ITableContentContext TableContentContext => new TableContentContextBuilder()
            .WithPortion(Portion.Foot)
            .Build();
    }
}
