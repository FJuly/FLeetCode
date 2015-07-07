using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Singleton
    {

        private static Singleton _instance = null;

        /// <summary>
        /// Prevents a default instance of the 
        /// <see cref="Singleton"/> class from being created.
        /// </summary>
        private  Singleton()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static Singleton Instance
        {
            get { return _instance ?? (_instance = new Singleton()); }
        }
    }
}
