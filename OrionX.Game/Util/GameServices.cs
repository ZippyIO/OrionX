// OrionX.Game Disclaimer
// ------------------------------------------------------
// OrionX.Game is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: GameServices.cs
// * Date: 28/12/2015
// * Time: 4:14 PM

using Microsoft.Xna.Framework;

namespace OrionX.Game.Util
{
    public class GameServices
    {
        #region Variables and Properties


        /// <summary>
        /// The GameService container
        /// </summary>
        private static GameServiceContainer container;

        /// <summary>
        /// Gets the GameServiceContainer instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static GameServiceContainer Instance
        {
            get
            {
                if (container == null)
                {
                    container = new GameServiceContainer();
                }
                return container;
            }
        }

        #endregion

        #region Methods Region

        //Get the GameService
        //Usage: GameService.GetService<GraphicsDevice>()

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetService<T>()
        {
            return (T)Instance.GetService(typeof(T));
        }

        //Adds a GameService
        //Usage: GameService.AddService"<GraphicsDevice>"(GraphicsDevice);

        /// <summary>
        /// Adds the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="service">The service.</param>
        public static void AddService<T>(T service)
        {
            Instance.AddService(typeof(T), service);
        }

        //Removes a GameService
        //Usage: GameService.RemoveService<GraphicsDevice>(GraphicsDevice);

        /// <summary>
        /// Removes the service.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static void RemoveService<T>()
        {
            Instance.RemoveService(typeof(T));
        }

        #endregion
    }
}
