﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Skclusive.Core.Component;
using Skclusive.Material.Core;
using Skclusive.Material.Transition;

namespace Skclusive.Material.Modal
{
    public static class ModalExtension
    {
        public static void TryAddModalServices(this IServiceCollection services, IMaterialConfig config)
        {
            services.TryAddMaterialTransitionServices(config);

            services.TryAddTransient<TrapFocusHelper>();

            services.TryAddStyleTypeProvider<ModalStyleProvider>();

            services.TryAddScriptTypeProvider<ModalScriptProvider>();
        }
    }
}
