using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Realm.Path.RNRealmPath
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNRealmPathModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNRealmPathModule"/>.
        /// </summary>
        internal RNRealmPathModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNRealmPath";
            }
        }
    }
}
