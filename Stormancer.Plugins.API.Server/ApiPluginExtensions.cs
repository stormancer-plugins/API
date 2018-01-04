﻿using Stormancer.Server.API;
using Stormancer.Core;

namespace Stormancer
{
    public static class ApiPluginExtensions
    {
        /// <summary>
        /// Adds a controller to the scene.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="scene"></param>
        public static void AddController<T>(this ISceneHost scene) where T : ControllerBase
        {
            
            //Create a  factory for the controller
            var factory = new ControllerFactory<T>(scene);
            //Add the controllers built by the factory to the scene.
            factory.RegisterControllers();
        
        }
        public static IRegistrationBuilder InstancePerRequest(this IRegistrationBuilder builder)
        {
            return builder.InstancePerNamedLifetimeScope("request");
        }

    }
}
