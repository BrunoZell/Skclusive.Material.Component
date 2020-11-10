﻿using Microsoft.AspNetCore.Components;
using Skclusive.Core.Component;
using Skclusive.Material.Core;

namespace Skclusive.Material.Table
{
    public partial class TableBody : MaterialComponent
    {
        public TableBody() : base("TableBody")
        {
        }

        /// <summary>
        /// html component tag to be used as container.
        /// </summary>
        [Parameter]
        public string Component { set; get; } = "tbody";

        protected ITableContentContext TableContentContext => new TableContentContextBuilder()
            .WithPortion(Portion.Body)
            .Build();
    }
}
