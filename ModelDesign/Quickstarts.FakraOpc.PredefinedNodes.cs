/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Text;
using System.IO;
using Opc.Ua;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1515 // Consider making public types internal
#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1028 // Enum Storage should be Int32

namespace Quickstarts.FakraOpc
{
    #region _ClassName_ Declarations
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class PredefinedNodes
    {
        #region PredefinedNodes Declarations
        // <summary/>
        public static NodeStateCollection Load(ISystemContext context)
        {
            byte[] initializationBuffer = Convert.FromBase64String(
               "AQAAAB8AAABodHRwOi8vc2NobGV1bmlnZXIuY29tL0RlZmF1bHQv/////wwAAAAEYAAQCAAAAAEACwAA" +
               "AEFydGljbGVUeXBlAQEwAAA6/////wQAAAAVYIkLAgAAAAEACQAAAEFydGljbGVJZAEBMQAALgBEAE4x" +
               "AAAAAAf/////AQH/////AAAAABVgiQsCAAAAAQALAAAAQXJ0aWNsZU5hbWUBATIAAC4ARABOMgAAAAAM" +
               "/////wEB/////wAAAAAVYIkLAgAAAAEADQAAAEFydGljbGVOdW1iZXIBATMAAC4ARABOMwAAAAAM////" +
               "/wEB/////wAAAAAVYIkLAgAAAAEADQAAAENhbkJlUHJvZHVjZWQBATQAAC4ARABONAAAAAAB/////wEB" +
               "/////wAAAAAEYAAQCAAAAAEACwAAAEpvYkluZm9UeXBlAQFIAAA6/////woAAAAVYIkLAgAAAAEABQAA" +
               "AEpvYklkAQFJAAAuAEQATkkAAAAAB/////8BAf////8AAAAAFWCJCwIAAAABAAcAAABKb2JOYW1lAQFK" +
               "AAAuAEQATkoAAAAADP////8BAf////8AAAAAFWCJCwIAAAABAAsAAABKb2JRdWFudGl0eQEBSwAALgBE" +
               "AE5LAAAAAAf/////AQH/////AAAAABVgiQsCAAAAAQANAAAAR29vZFBhcnRDb3VudAEBTAAALgBEAE5M" +
               "AAAAAAf/////AQH/////AAAAABVgiQsCAAAAAQAMAAAAQmFkUGFydENvdW50AQFNAAAuAEQATk0AAAAA" +
               "B/////8BAf////8AAAAAFWCJCwIAAAABAA0AAABCYXRjaFF1YW50aXR5AQFOAAAuAEQATk4AAAAAB///" +
               "//8BAf////8AAAAAFWCJCwIAAAABAAoAAABCYXRjaENvdW50AQFPAAAuAEQATk8AAAAAB/////8BAf//" +
               "//8AAAAAFWCJCwIAAAABAAkAAABBcnRpY2xlSWQBAVAAAC4ARABOUAAAAAAH/////wEB/////wAAAAAV" +
               "YIkLAgAAAAEACAAAAEpvYlN0YXRlAQFRAAAuAEQATlEAAAAABv////8BAf////8AAAAAFWCJCwIAAAAB" +
               "AA4AAABBY3RpdmF0aW9uVGltZQEBUgAALgBEAFBSAAAAAA3/////AQH/////AAAAAARgABAIAAAAAQAL" +
               "AAAASm9iTGlzdFR5cGUBAUAAADr/////AAAAAARgABAIAAAAAQAPAAAAQXJ0aWNsZUxpc3RUeXBlAQFB" +
               "AAA6/////wAAAAAEYAAQCAAAAAEABwAAAE1hY2hpbmUDAQAHAAAATWFjaGluZQA6/////wgAAAAVYIkL" +
               "AgAAAAEAEAAAAFByb2R1Y3Rpb25TdGF0dXMBAUIAAC4ARABOQgAAAAAG/////wEB/////wAAAAAVYIkL" +
               "AgAAAAEADgAAAEFjdGl2ZUpvYlN0YXRlAQFDAAAuAEQATkMAAAAABv////8BAf////8AAAAABGCACwEA" +
               "AAABAAcAAABKb2JMaXN0AQFEAAAvAQFAAABORAAAAP////8AAAAABGCACwEAAAABAAsAAABBcnRpY2xl" +
               "TGlzdAEBRQAALwEBQQAATkUAAAD/////AAAAACRhggkEAAAAAQAGAAAAQWRkSm9iAwEABgAAAEFkZEpv" +
               "YgMAAAAADgAAAEFkZCBhIG5ldyBqb2IuAC8BAQAAAE4BAf////8CAAAAF2CpCwIAAAAAAA4AAABJbnB1" +
               "dEFyZ3VtZW50cwEBBgAALgBEAE4GAAAAlgQAAAABACoBARYAAAAHAAAASm9iTmFtZQAM/////wAAAAAA" +
               "AQAqAQEaAAAACwAAAEpvYlF1YW50aXR5AAf/////AAAAAAABACoBARwAAAANAAAAQmF0Y2hRdWFudGl0" +
               "eQAH/////wAAAAAAAQAqAQEYAAAACQAAAEFydGljbGVJZAAH/////wAAAAAAAQAoAQEAAAABAAAAAAAA" +
               "AAEB/////wAAAAAXYKkLAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBBwAALgBEAE4HAAAAlgEAAAAB" +
               "ACoBARQAAAAFAAAASm9iSWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAAJGGCCwQA" +
               "AAABAAsAAABBY3RpdmF0ZUpvYgEBRgADAAAAAB4AAABBY3RpdmF0ZSBhIGpvYiBmb3IgcHJvZHVjdGlv" +
               "bi4ALwEBRgAATkYAAAABAf////8BAAAAF2CpCwIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBRwAALgBE" +
               "AE5HAAAAlgEAAAABACoBARQAAAAFAAAASm9iSWQAB/////8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf//" +
               "//8AAAAAJGGCCwQAAAABAAkAAABEZWxldGVKb2IBAQIAAwAAAAAeAAAARGVsZXRlIGEgam9iIGZyb20g" +
               "dGhlIG1hY2hpbmUuAC8BAQIAAE4CAAAAAQH/////AQAAABdgqQsCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
               "dHMBAQMAAC4ARABOAwAAAJYBAAAAAQAqAQEUAAAABQAAAEpvYklkAAf/////AAAAAAABACgBAQAAAAEA" +
               "AAAAAAAAAQH/////AAAAACRhggsEAAAAAQAOAAAAR2VuZXJhdGVSZXBvcnQBAQkAAwAAAAAXAAAAR2Vu" +
               "ZXJhdGUgYSByZXBvcnQgZmlsZS4ALwEBCQAATgkAAAABAf////8CAAAAF2CpCwIAAAAAAA4AAABJbnB1" +
               "dEFyZ3VtZW50cwEBCgAALgBEAE4KAAAAlgMAAAABACoBARQAAAAFAAAASm9iSWQAB/////8AAAAAAAEA" +
               "KgEBFAAAAAUAAABTY29wZQAG/////wAAAAAAAQAqAQEWAAAABwAAAFNjb3BlSWQAB/////8AAAAAAAEA" +
               "KAEBAAAAAQAAAAAAAAABAf////8AAAAAF2CpCwIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAQsAAC4A" +
               "RABOCwAAAJYBAAAAAQAqAQEdAAAADgAAAFJlcG9ydEZpbGVOb2RlABH/////AAAAAAABACgBAQAAAAEA" +
               "AAAAAAAAAQH/////AAAAACRgABAIAAAAAQAaAAAAU3lzdGVtQ3ljbGVTdGF0dXNFdmVudFR5cGUBAQwA" +
               "AwAAAAArAAAAQW4gZXZlbnQgcmFpc2VkIHdoZW4gYSBzeXN0ZW0gY3ljbGUgc3RhcnRzLgEAUgj/////" +
               "AQAAABVgiQsCAAAAAQAHAAAAQ3ljbGVJZAEBDQAALgBEAE4NAAAAAAz/////AQH/////AAAAAARgABAI" +
               "AAAAAQAVAAAAV2lyZUZpbmlzaGVkRXZlbnRUeXBlAQETAAEA+Qf/////BQAAABVgiQsCAAAAAQAFAAAA" +
               "Sm9iSWQBARQAAC4ARABOFAAAAAAH/////wEB/////wAAAAAVYIkLAgAAAAEAEwAAAEJhdGNoU2VxdWVu" +
               "Y2VOdW1iZXIBARUAAC4ARABOFQAAAAAH/////wEB/////wAAAAAVYIkLAgAAAAEAEgAAAFdpcmVTZXF1" +
               "ZW5jZU51bWJlcgEBFgAALgBEAE4WAAAAAAf/////AQH/////AAAAABVgiQsCAAAAAQANAAAAR29vZFBh" +
               "cnRDb3VudAEBFwAALgBEAE4XAAAAAAf/////AQH/////AAAAABVgiQsCAAAAAQAMAAAAQmFkUGFydENv" +
               "dW50AQEYAAAuAEQAThgAAAAAB/////8BAf////8AAAAABGAAEAgAAAABABYAAABCYXRjaEZpbmlzaGVk" +
               "RXZlbnRUeXBlAQHoCwEA+Qf/////BAAAABVgiQsCAAAAAQATAAAAQmF0Y2hTZXF1ZW5jZU51bWJlcgEB" +
               "BAAALgBEAE4EAAAAAAf/////AQH/////AAAAABVgiQsCAAAAAQAFAAAASm9iSWQBAQUAAC4ARABOBQAA" +
               "AAAH/////wEB/////wAAAAAVYIkLAgAAAAEADQAAAEdvb2RQYXJ0Q291bnQBARkAAC4ARABOGQAAAAAH" +
               "/////wEB/////wAAAAAVYIkLAgAAAAEADAAAAEJhZFBhcnRDb3VudAEBGgAALgBEAE4aAAAAAAf/////" +
               "AQH/////AAAAAARgABAIAAAAAQAUAAAASm9iRmluaXNoZWRFdmVudFR5cGUBAR4AAQD5B/////8DAAAA" +
               "FWCJCwIAAAABAAUAAABKb2JJZAEBHwAALgBEAE4fAAAAAAf/////AQH/////AAAAABVgiQsCAAAAAQAN" +
               "AAAAR29vZFBhcnRDb3VudAEBIAAALgBEAE4gAAAAAAf/////AQH/////AAAAABVgiQsCAAAAAQAMAAAA" +
               "QmFkUGFydENvdW50AQEhAAAuAEQATiEAAAAAB/////8BAf////8AAAAABGAAEAgAAAABABMAAABKb2JT" +
               "dG9wcGVkRXZlbnRUeXBlAQEiAAEA+Qf/////AwAAABVgiQsCAAAAAQAFAAAASm9iSWQBASMAAC4ARABO" +
               "IwAAAAAH/////wEB/////wAAAAAVYIkLAgAAAAEADQAAAEdvb2RQYXJ0Q291bnQBASQAAC4ARABOJAAA" +
               "AAAH/////wEB/////wAAAAAVYIkLAgAAAAEADAAAAEJhZFBhcnRDb3VudAEBJQAALgBEAE4lAAAAAAf/" +
               "////AQH/////AAAAAARgABAIAAAAAQAaAAAAUHJvZHVjdGlvblN0YXJ0ZWRFdmVudFR5cGUBASYAAQD5" +
               "B/////8DAAAAFWCJCwIAAAABAAUAAABKb2JJZAEBJwAALgBEAE4nAAAAAAf/////AQH/////AAAAABVg" +
               "iQsCAAAAAQANAAAAR29vZFBhcnRDb3VudAEBKAAALgBEAE4oAAAAAAf/////AQH/////AAAAABVgiQsC" +
               "AAAAAQAMAAAAQmFkUGFydENvdW50AQEpAAAuAEQATikAAAAAB/////8BAf////8AAAAABGAAEAgAAAAB" +
               "ABoAAABQcm9kdWN0aW9uU3RvcHBlZEV2ZW50VHlwZQEBKgABAPkH/////wMAAAAVYIkLAgAAAAEABQAA" +
               "AEpvYklkAQErAAAuAEQATisAAAAAB/////8BAf////8AAAAAFWCJCwIAAAABAA0AAABHb29kUGFydENv" +
               "dW50AQEsAAAuAEQATiwAAAAAB/////8BAf////8AAAAAFWCJCwIAAAABAAwAAABCYWRQYXJ0Q291bnQB" +
               "AS0AAC4ARABOLQAAAAAH/////wEB/////wAAAAA="
            );
            using (MemoryStream stream = new MemoryStream(initializationBuffer))
            {
                NodeStateCollection predefinedNodes = new NodeStateCollection();
                predefinedNodes.LoadFromBinary(context, stream, true);
                return predefinedNodes;
            }
        }
        #endregion
    }
    #endregion
}