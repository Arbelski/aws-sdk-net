/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Options associated with your audio codec.
    /// </summary>
    public partial class AudioCodecOptions
    {
        private string _profile;

        /// <summary>
        /// Gets and sets the property Profile. 
        /// <para>
        /// You can only choose an audio profile when you specify AAC for the value of Audio:Codec.
        /// </para>
        ///  
        /// <para>
        /// Specify the AAC profile for the output file. Elastic Transcoder supports the following
        /// profiles:
        /// </para>
        ///  <ul> <li> <code>auto</code>: If you specify <code>auto</code>, Elastic Transcoder
        /// will select the profile based on the bit rate selected for the output file.</li> <li>
        /// <code>AAC-LC</code>: The most common AAC profile. Use for bitrates larger than 64
        /// kbps.</li> <li> <code>HE-AAC</code>: Not supported on some older players and devices.
        /// Use for bitrates between 40 and 80 kbps.</li> <li> <code>HE-AACv2</code>: Not supported
        /// on some players and devices. Use for bitrates less than 48 kbps.</li> </ul> 
        /// <para>
        /// All outputs in a <code>Smooth</code> playlist must have the same value for <code>Profile</code>.
        /// </para>
        /// </summary>
        public string Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

    }
}