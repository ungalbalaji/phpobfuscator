using System;
using System.Collections.Generic;
using System.Text;

namespace Obfuscation
{
    /// <summary>
    /// Interface that User Interfaces of the Obfuscator class should impliment in order to recieve
    /// events.
    /// </summary>
    public interface IObfuscatorUI
    {
        /// <summary>
        /// Something changed. 
        /// </summary>
        /// <param name="status">What changed</param>
        void StatusUpdate(string status);
        
        /// <summary>
        /// Obfuscation has successfully completed. 
        /// </summary>
        void Done();
        
        /// <summary>
        /// There was an error running the obfuscation
        /// </summary>
        /// <param name="errorText">What was the error</param>
        void Error(string errorText);
    }
}
