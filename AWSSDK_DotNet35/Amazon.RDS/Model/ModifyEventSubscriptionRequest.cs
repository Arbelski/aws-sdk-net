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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyEventSubscription operation.
    /// Modifies an existing RDS event notification subscription. Note that you cannot modify
    /// the source identifiers using this call; to change source identifiers for a subscription,
    /// use the <a>AddSourceIdentifierToSubscription</a> and <a>RemoveSourceIdentifierFromSubscription</a>
    /// calls.
    /// 
    ///  
    /// <para>
    /// You can see a list of the event categories for a given SourceType in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a>
    /// topic in the Amazon RDS User Guide or by using the <b>DescribeEventCategories</b>
    /// action.
    /// </para>
    /// </summary>
    public partial class ModifyEventSubscriptionRequest : AmazonRDSRequest
    {
        private bool? _enabled;
        private List<string> _eventCategories = new List<string>();
        private string _snsTopicArn;
        private string _sourceType;
        private string _subscriptionName;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  A Boolean value; set to <b>true</b> to activate the subscription. 
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventCategories. 
        /// <para>
        ///  A list of event categories for a SourceType that you want to subscribe to. You can
        /// see a list of the categories for a given SourceType in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a>
        /// topic in the Amazon RDS User Guide or by using the <b>DescribeEventCategories</b>
        /// action. 
        /// </para>
        /// </summary>
        public List<string> EventCategories
        {
            get { return this._eventCategories; }
            set { this._eventCategories = value; }
        }

        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this._eventCategories != null && this._eventCategories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the SNS topic created for event notification. The
        /// ARN is created by Amazon SNS when you create a topic and subscribe to it. 
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        ///  The type of source that will be generating the events. For example, if you want to
        /// be notified of events generated by a DB instance, you would set this parameter to
        /// db-instance. if this value is not specified, all events are returned. 
        /// </para>
        ///  
        /// <para>
        /// Valid values: db-instance | db-parameter-group | db-security-group | db-snapshot
        /// </para>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        /// The name of the RDS event notification subscription.
        /// </para>
        /// </summary>
        public string SubscriptionName
        {
            get { return this._subscriptionName; }
            set { this._subscriptionName = value; }
        }

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this._subscriptionName != null;
        }

    }
}